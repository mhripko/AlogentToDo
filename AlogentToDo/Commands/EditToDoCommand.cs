using AlogentToDo.Properties;

namespace AlogentToDo
{
    class EditToDoCommand : CommandBase
    {
        private readonly IToDoListView toDoListView;
        private readonly IMessageBoxDisplayService messageBoxDisplayService;
        private readonly IToDoListManager toDoListManager;

        public EditToDoCommand(IToDoListView toDoListView, 
            IMessageBoxDisplayService messageBoxDisplayService,
            IToDoListManager toDoListManager)
        {
            this.toDoListView = toDoListView;
            this.messageBoxDisplayService = messageBoxDisplayService;
            this.toDoListManager = toDoListManager;
            Icon = Resources.edit_icon_32;
            ToolTip = "Edit selected To Do item";
        }

        public override void Execute()
        {
            Utils.EditRow(toDoListView);
        }
    }
}
