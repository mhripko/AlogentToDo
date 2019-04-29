using System;
using System.Drawing;
using System.Windows.Forms;
using static AlogentToDo.MainForm;

namespace AlogentToDo
{
    public partial class MainForm : Form, IMainFormView
    {
        private readonly ToDoListView todolistView;

        public MainForm()
        {
            InitializeComponent();
            todolistView = new ToDoListView() { Dock = DockStyle.Fill };
            splitContainer1.Panel2.Controls.Add(todolistView);
        }

        private void OnFormLoad(object sender, EventArgs e)        {        }

        public IToDoListView ToDoListView { get { return todolistView; } }

        public IToolbarView ToolbarView { get { return toolBarView; } }

        /// <summary>
        /// ShowToDoListView will show the to do list.
        /// </summary>
        public void ShowToDoListView()
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(todolistView);
        }

        /// <summary>
        /// IMainFormView is our interface code for our UI.  For simplicity I put into the MainForm class file.
        /// </summary>
        public interface IMainFormView
        {
            event EventHandler Load;
            event FormClosedEventHandler FormClosed;
            event HelpEventHandler HelpRequested;
            event KeyEventHandler KeyUp;

            IToDoListView ToDoListView { get; }
            IToolbarView ToolbarView { get; }
            Color BackColor { get; set; }
            void ShowToDoListView();
        }
    }
}
