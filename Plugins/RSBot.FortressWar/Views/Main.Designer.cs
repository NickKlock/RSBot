using System.ComponentModel;

namespace FortressWar.Views
{
    partial class Main
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.playnameTextBox = new System.Windows.Forms.TextBox();
            this.addToListBtn = new RSBot.Theme.Material.Button();
            this.tracePlayerList = new RSBot.Theme.Controls.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.playnameTextBox);
            this.panel1.Controls.Add(this.addToListBtn);
            this.panel1.Controls.Add(this.tracePlayerList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 459);
            this.panel1.TabIndex = 0;
            // 
            // playnameTextBox
            // 
            this.playnameTextBox.Location = new System.Drawing.Point(105, 175);
            this.playnameTextBox.Name = "playnameTextBox";
            this.playnameTextBox.Size = new System.Drawing.Size(153, 20);
            this.playnameTextBox.TabIndex = 4;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Depth = 0;
            this.addToListBtn.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (2)));
            this.addToListBtn.Icon = null;
            this.addToListBtn.Location = new System.Drawing.Point(264, 175);
            this.addToListBtn.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Primary = true;
            this.addToListBtn.Raised = true;
            this.addToListBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addToListBtn.SingleColor = System.Drawing.Color.LightSlateGray;
            this.addToListBtn.Size = new System.Drawing.Size(57, 20);
            this.addToListBtn.TabIndex = 1;
            this.addToListBtn.Text = "a";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // tracePlayerList
            // 
            this.tracePlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnName});
            this.tracePlayerList.FullRowSelect = true;
            this.tracePlayerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.tracePlayerList.HideSelection = false;
            this.tracePlayerList.Location = new System.Drawing.Point(6, 19);
            this.tracePlayerList.Name = "tracePlayerList";
            this.tracePlayerList.Size = new System.Drawing.Size(315, 146);
            this.tracePlayerList.TabIndex = 1;
            this.tracePlayerList.UseCompatibleStateImageBehavior = false;
            this.tracePlayerList.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 300;
            // 
            // Main
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(719, 459);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox playnameTextBox;

        private RSBot.Theme.Controls.ListView tracePlayerList;

        private RSBot.Theme.Material.Button addToListBtn;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnName;


        #endregion
    }
}