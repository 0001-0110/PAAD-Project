namespace PAAD.HMI.Extensions
{
    internal static class ControlExtensions
    {
        private static Dictionary<Control, ErrorProvider> errorProviders = new Dictionary<Control, ErrorProvider>();

        public static bool SetErrorIf(this Control control, bool condition, string errorMessage)
        {
            if (!errorProviders.ContainsKey(control))
                errorProviders.Add(control, new ErrorProvider());

            errorProviders[control].SetError(control, condition ? errorMessage : string.Empty);
            return condition;
        }
    }
}
