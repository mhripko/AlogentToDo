using AlogentToDo.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AlogentToDo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var todoForm = new MainForm();
            var toDoListManager = new ToDoListManager(Settings.Default.ToDoFileName);
            var messageBoxDisplayService = new MessageBoxDisplayService();
            var settingsService = new SettingsService();
            var systemInformationService = new SystemInformationService();

            var commands = new IToolbarCommand[]
            {
                new LogoCommand(todoForm.ToDoListView,messageBoxDisplayService,toDoListManager),
                new AddToDoCommand(todoForm.ToDoListView,messageBoxDisplayService,toDoListManager),
                new EditToDoCommand(todoForm.ToDoListView,messageBoxDisplayService,toDoListManager),
                new DeleteToDoCommand(todoForm.ToDoListView,messageBoxDisplayService,toDoListManager),
            };

            var presenter = new MainFormPresenter(todoForm,
                toDoListManager,
                messageBoxDisplayService,
                settingsService,
                systemInformationService,
                commands);

            Application.Run(todoForm);
        }

        /// <summary>
        /// CurrentDomainOnUnhandledException will handle any error not picked up in code anywhere else.
        /// </summary>
        /// <param name="sender">An object that threw the error</param>
        /// <param name="e">An error object with the exception information</param>
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format("Sorry, something went wrong.\r\n" +
                "{0}\r\n" +
                "Please contact support.",
                ((Exception)e.ExceptionObject).Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.ExceptionObject);

            MessageBox.Show(message, "Unexpected Error");

        }

        /// <summary>
        /// ApplicationOnThreadException handles any error thrown from any thread.
        /// </summary>
        /// <param name="sender">An object that threw the error</param>
        /// <param name="e">An error object with the exception information</param>
        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var message = String.Format("Sorry, something went wrong.\r\n" +
              "{0}\r\n" +
              "Please contact support.",
                e.Exception.Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.Exception);

            MessageBox.Show(message, "Unexpected Error");
        }
    }
}
