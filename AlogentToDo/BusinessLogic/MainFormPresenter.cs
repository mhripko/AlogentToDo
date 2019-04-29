using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlogentToDo.MainForm;
using AlogentToDo.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AlogentToDo
{
    class MainFormPresenter
    {
        private readonly IMainFormView mainFormView;
        private readonly IToDoListManager toDoListManager;
        //private readonly ToDoLoader toDoLoader;
        //private readonly List<ToDo> todos;

        private readonly IToDoListView toDoListView;
        private readonly IToolbarView toolbarView;
        private readonly IMessageBoxDisplayService messageBoxDisplayService;
        private readonly ISettingsService settingsService;
        private readonly IToolbarCommand[] commands;

        public MainFormPresenter(IMainFormView mainFormView,
            IToDoListManager toDoListManager,
            IMessageBoxDisplayService messageBoxDisplayService,
            ISettingsService settingsService,
            ISystemInformationService systemInformationService,
            IToolbarCommand[] commands)
        {
            toDoListView = mainFormView.ToDoListView;
            toolbarView = mainFormView.ToolbarView;
            toolbarView.SetCommands(commands);

            this.mainFormView = mainFormView;
            mainFormView.Load += MainFormViewOnLoad;
            mainFormView.FormClosed += MainFormViewOnFormClosed;
            mainFormView.HelpRequested += OnHelpRequested;
            mainFormView.KeyUp += MainFormViewOnKeyUp;

            this.toDoListManager = toDoListManager;
            this.messageBoxDisplayService = messageBoxDisplayService;
            this.settingsService = settingsService;
            this.commands = commands;

            if (!systemInformationService.IsHighContrastColourScheme)
            {
                mainFormView.BackColor = Color.White;
            }
        }

        private void MainFormViewOnKeyUp(object sender, KeyEventArgs keyEventArgs)
        {
            var command = commands.FirstOrDefault(c => c.ShortcutKey == keyEventArgs.KeyCode);
            if (command != null)
            {
                command.Execute();
                keyEventArgs.Handled = true;
            }
        }

        private void MainFormViewOnLoad(object sender, EventArgs eventArgs)
        {
            Utils.LoadToDosToDataGridView(toDoListManager.ToDos, toDoListView);

            if (settingsService.FirstRun)
            {
                messageBoxDisplayService.Show("Welcome to Alogent To Do! Select a new/blank row to Add, select any row to Edit/F2 or Delete");
                settingsService.FirstRun = false;
                settingsService.Save();
            }

        }
        private void OnHelpRequested(object sender, HelpEventArgs hlpevent)
        {
            messageBoxDisplayService.Show("To Do List\r\n\r\n" +
                "Keyboard Commands:\r\n" +
                "1. To ADD a To Do item, enter it on the last row.\r\n" +
                "2. To EDIT a To Do item, select the item and press F2.\r\n" +
                "3. To DELETE a To Do item, select the item and press DELETE.\r\n " +
                "4. For Help press F1.\r\n\r\nn" +
                "Tip: Make Sure a Row is Highlighted/Selected in order to Delete or Edit.\r\n" );
        }

        private void MainFormViewOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            toDoListManager.Save();
        }
    }
}
