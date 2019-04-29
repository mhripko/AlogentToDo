using AlogentToDo.Properties;

namespace AlogentToDo
{
    class LogoCommand : CommandBase
    {
        private readonly IToDoListView toDoListView;
        private readonly IMessageBoxDisplayService messageBoxDisplayService;
        private readonly IToDoListManager toDoListManager;

        public LogoCommand(IToDoListView toDoListView,
            IMessageBoxDisplayService messageBoxDisplayService,
            IToDoListManager toDoListManager)
        {
            this.toDoListView = toDoListView;
            this.messageBoxDisplayService = messageBoxDisplayService;
            this.toDoListManager = toDoListManager;
            Icon = Resources.alogent_logo;
            ToolTip = "Alogent To Do List";
        }

        public override void Execute()
        {
            messageBoxDisplayService.Show("To Do List\r\n\r\n" +
                "Keyboard Commands:\r\n" +
                "1. To ADD a To Do item, enter it on the last row.\r\n" +
                "2. To EDIT a To Do item, select the item and press F2.\r\n" +
                "3. To DELETE a To Do item, select the item and press DELETE.\r\n " +
                "4. For Help press F1.\r\n\r\nn" +
                "Tip: Make Sure a Row is Highlighted/Selected in order to Delete or Edit.\r\n");
        }
    }
}
