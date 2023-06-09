using Microsoft.IdentityModel.Tokens;

namespace PAAD.HMI.Extensions
{
    // This file is containing extensions for multiple types, but they all are linked to validating the fields

    internal static class ErrorProviderExtensions
    {
        private class Validator
        {
            private Control control;
            private Predicate<Control> predicate;
            private string errorMessage;
            private ErrorProvider errorProvider;

            public static Validator Create<TControl>(TControl control, Predicate<TControl> predicate, string errorMessage) where TControl : notnull, Control
            {
                Predicate<Control> controlPredicate = control => predicate((TControl)control);
                return new Validator(control, controlPredicate, errorMessage);
            }

            private Validator(Control control, Predicate<Control> predicate, string errorMessage)
            {
                this.control = control;
                this.predicate = predicate;
                this.errorMessage = errorMessage;
                errorProvider = new ErrorProvider();
            }

            public bool IsValid()
            {
                bool isValid = predicate(control);
                errorProvider.SetError(control, isValid ? string.Empty : errorMessage);
                return isValid;
            }
        }

        private static Dictionary<Form, ICollection<Validator>> validators = new Dictionary<Form, ICollection<Validator>>();

        public static void SetValidator<TControl>(this TControl control, Predicate<TControl> predicate, string errorMessage) where TControl : notnull, Control
        {
            if (errorMessage.IsNullOrEmpty())
                throw new ArgumentNullException("You can't have an empty error message");

            Form controlForm = control.FindForm();
            Validator validator = Validator.Create(control, predicate, errorMessage);

            if (!validators.ContainsKey(controlForm))
                validators.Add(controlForm, new List<Validator>());
            validators[controlForm].Add(validator);
        }

        public static bool IsFormValid(this Form form)
        {
            if (!validators.ContainsKey(form))
                // Nothing to validate, evrything is ok
                return true;

            bool isValid = true;
            foreach (Validator validator in validators[form])
                // We keep validating everything even if one failed because we want to diaplay all errors to the user
                isValid &= validator.IsValid();

            return isValid;
        }
    }
}
