namespace PreferenceTest.Core.Handlers
{
    public interface INotificationHandler
    {
        void ShowToast(string message);
        void ShowSnackbar(string message);
    }
}
