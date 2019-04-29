using System.Collections.Generic;


namespace AlogentToDo
{
    /// <summary>
    /// The static Utils class provides utility functions for the business, keeping business logic out
    /// of the code of the form.
    /// </summary>
    static class Utils
    {
        /// <summary>
        /// AddRow will setup a new blank row for the user.
        /// </summary>
        /// <param name="toDoListView"></param>
        public static void AddRow(IToDoListView toDoListView)
        {
            toDoListView.AddRow();
        }

        /// <summary>
        /// Load the To Do list into the View.  The is called by the Presenter in a Model-View-Presenter setup.
        /// </summary>
        /// <param name="todos"></param>
        /// <param name="toDoListView"></param>
        public static void LoadToDosToDataGridView(IEnumerable<ToDo> todos, IToDoListView toDoListView)
        {
            toDoListView.LoadToDos(todos);
        }

        /// <summary>
        /// DeleteRow will remove one or more selected rows.
        /// </summary>
        /// <param name="toDoListView"></param>
        public static void DeleteRow(IToDoListView toDoListView)
        {
            toDoListView.RemoveRow();
        }

        /// <summary>
        /// EditRow will allow editing in the selected row.
        /// </summary>
        /// <param name="toDoListView"></param>
        public static void EditRow(IToDoListView toDoListView)
        {
            toDoListView.EditRow();
        }


    }
}
