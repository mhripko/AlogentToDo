namespace AlogentToDo
{
    partial class ToolBarView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBarView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonAddToDo = new System.Windows.Forms.ToolStripButton();
            this.buttonEditToDo = new System.Windows.Forms.ToolStripButton();
            this.buttonDeleteToDo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonLogo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLogo,
            this.toolStripSeparator1,
            this.buttonAddToDo,
            this.buttonEditToDo,
            this.buttonDeleteToDo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(487, 60);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonAddToDo
            // 
            this.buttonAddToDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddToDo.Image = global::AlogentToDo.Properties.Resources.add_icon_32;
            this.buttonAddToDo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAddToDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddToDo.Name = "buttonAddToDo";
            this.buttonAddToDo.Size = new System.Drawing.Size(36, 57);
            this.buttonAddToDo.Text = "Add ToDo Item";
            this.buttonAddToDo.ToolTipText = "Add a new To Do Item";
            // 
            // buttonEditToDo
            // 
            this.buttonEditToDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEditToDo.Image = global::AlogentToDo.Properties.Resources.edit_icon_32;
            this.buttonEditToDo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditToDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditToDo.Name = "buttonEditToDo";
            this.buttonEditToDo.Size = new System.Drawing.Size(36, 57);
            this.buttonEditToDo.Text = "Edit To Do Item";
            this.buttonEditToDo.ToolTipText = "Edit Selected To Do Item";
            // 
            // buttonDeleteToDo
            // 
            this.buttonDeleteToDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDeleteToDo.Image = global::AlogentToDo.Properties.Resources.delete_icon_32;
            this.buttonDeleteToDo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDeleteToDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDeleteToDo.Name = "buttonDeleteToDo";
            this.buttonDeleteToDo.Size = new System.Drawing.Size(36, 57);
            this.buttonDeleteToDo.Text = "Delete To Do Item";
            this.buttonDeleteToDo.ToolTipText = "Delete Selected To Do Item";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // buttonLogo
            // 
            this.buttonLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLogo.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogo.Image")));
            this.buttonLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(53, 57);
            this.buttonLogo.Text = "Alogent";
            // 
            // ToolBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolBarView";
            this.Size = new System.Drawing.Size(487, 60);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonAddToDo;
        private System.Windows.Forms.ToolStripButton buttonDeleteToDo;
        private System.Windows.Forms.ToolStripButton buttonEditToDo;
        private System.Windows.Forms.ToolStripButton buttonLogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
