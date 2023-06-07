namespace PAAD.HMI.Extensions
{
    internal static class ControlExtensions
    {
        public static bool SetErrorIf(this Control control, ErrorProvider errorProvider, bool condition, string errorMessage)
        {
            errorProvider.SetError(control, condition ? errorMessage : string.Empty);
            return condition;
        }
    }
}
