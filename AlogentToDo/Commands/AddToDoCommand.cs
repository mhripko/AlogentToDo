using AlogentToDo.Properties;

namespace AlogentToDo
{
    class AddToDoCommand : CommandBase
    {
        private readonly IToDoListView toDoListView;
        private readonly IMessageBoxDisplayService messageBoxDisplayService;
        private readonly IToDoListManager toDoListManager;

        public AddToDoCommand(
            IToDoListView toDoListView,
            IMessageBoxDisplayService messageBoxDisplayService,
            IToDoListManager toDoListManager)
        {
            this.toDoListView = toDoListView;
            this.messageBoxDisplayService = messageBoxDisplayService;
            this.toDoListManager = toDoListManager;
            Icon = Resources.add_icon_32;
            ToolTip = "Add a new To Do List item";
        }

        public override void Execute()
        {
            Utils.AddRow(toDoListView);
        }
    }
}
