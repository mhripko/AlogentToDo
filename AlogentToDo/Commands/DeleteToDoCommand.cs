using AlogentToDo.Properties;

namespace AlogentToDo
{
    /// <summary>
    /// DeleteToDoCommand is an example of Command.  In C#, when we want to keep code out of
    /// the Icon and Menubar definition, it makes sense to turn them into a Command Pattern so
    /// the classes can be separated from the UI definitions.
    /// </summary>
    class DeleteToDoCommand : CommandBase
    {
        private readonly IToDoListView toDoListView;
        private readonly IMessageBoxDisplayService messageBoxDisplayService;
        private readonly IToDoListManager toDoListManager;

        /// <summary>
        /// DeleteToDoCommand is the command called by the icon to delete a To Do item.
        /// </summary>
        /// <param name="toDoListView">The UI View of To Do list</param>
        /// <param name="messageBoxDisplayService">A simple service for showing UI messages</param>
        /// <param name="toDoListManager">A Manager class to manage to do list operations</param>
        public DeleteToDoCommand(IToDoListView toDoListView,
            IMessageBoxDisplayService messageBoxDisplayService,
            IToDoListManager toDoListManager)
        {
            this.toDoListView = toDoListView;
            this.messageBoxDisplayService = messageBoxDisplayService;
            this.toDoListManager = toDoListManager;
            Icon = Resources.delete_icon_32;
            ToolTip = "This will delete any selected/highlighted rows.";
        }

        /// <summary>
        /// Execute the command.  This calls the utility class which handles the To List deletetion.
        /// </summary>
        public override void Execute()
        {
            Utils.DeleteRow(toDoListView);
        }
    }
}
