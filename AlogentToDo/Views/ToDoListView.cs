using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlogentToDo
{
    public partial class ToDoListView : UserControl, IToDoListView
    {
        public ToDoListView()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += (s, a) => OnSelectionChanged();
        }

        /// <summary>
        /// SelectedRow will return the Selected DataGridViewRow
        /// </summary>
        public DataGridViewRow SelectedRow
        {
            get
            {
                return SelectedRow;
            }
        }

        /// <summary>
        /// Add Row will move the selected row down to the Last Row so you can add new data.
        /// </summary>
        public void AddRow()
        {
            dataGridView1.AllowUserToAddRows = true;
            int rowIndex = dataGridView1.CurrentRow.Index;
            if (!dataGridView1.Rows[rowIndex].IsNewRow)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    try
                    {
                        dataGridView1.Rows[row.Index].Selected = false;
                    }
                    catch (InvalidOperationException e)
                    {
                        // We could warn user about trying to delete an invalid row, but
                        // instead we will just take no action.
                    }

                }
                var lastRow = dataGridView1.Rows[dataGridView1.RowCount - 1];
                lastRow.Selected = true;
                dataGridView1.CurrentCell = lastRow.Cells[1];
                dataGridView1.Refresh();
            }
        }

        /// <summary>
        /// EditRow will select the row in the datagrid and allow editing.
        /// </summary>
        public void EditRow()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
        }


        /// <summary>
        /// RemoveRow will delete the selected row.
        /// </summary>
        public void RemoveRow()
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            bool isSelectedIndex = dataGridView1.Rows[rowIndex].Selected;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Rows[0].Selected = true;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    try
                    {
                        if (!dataGridView1.Rows[row.Index].IsNewRow)
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                        }
                        else
                        {
                            dataGridView1.AllowUserToAddRows = false;
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        // We could warn user about trying to delete an invalid row, but
                        // instead we will just take no action.
                    }

                }
            }

        }

        /// <summary>
        /// SelectRow will select the datagridview row.
        /// </summary>
        /// <param name="id"></param>
        public void SelectRow(int id)
        {
            // not right but ok for now.
            dataGridView1.Rows[0].Selected = true;
        }

        /// <summary>
        /// LoadToDos will load the To Do list from storage.
        /// </summary>
        /// <param name="toDos"></param>
        public void LoadToDos(IEnumerable<ToDo> toDos)
        {
            toDoBindingSource.DataSource = toDos;
        }

        public event EventHandler SelectionChanged;

        protected virtual void OnSelectionChanged()
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// IToDoListView is our interface for the ToDoListView.  For sipmlicity, it's included in the ToDoListView
    /// </summary>
    public interface IToDoListView
    {
        DataGridViewRow SelectedRow { get; }

        void AddRow();
        void EditRow();
        void RemoveRow();
        void SelectRow(int id);
        void LoadToDos(IEnumerable<ToDo> toDos);

        event EventHandler SelectionChanged;
    }
}
