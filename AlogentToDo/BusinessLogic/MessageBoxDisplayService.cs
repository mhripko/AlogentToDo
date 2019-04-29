using System.Windows.Forms;

namespace AlogentToDo
{
    /// <summary>
    /// The Message Box Display Service is used to show messages to the user in the model message box window.
    /// 
    /// This keeps business logic messages out of the code-behind of the forms!
    /// </summary>
    internal class MessageBoxDisplayService : IMessageBoxDisplayService
    {
        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }

    internal interface IMessageBoxDisplayService
    {
        void Show(string message);
    }
}
