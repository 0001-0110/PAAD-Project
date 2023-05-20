namespace PAAD.HMI.Utilities
{
    public static class MessageBoxUtility
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
