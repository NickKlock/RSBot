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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.targetLeaderTextBox = new System.Windows.Forms.TextBox();
            this.addToTargetListBtn = new RSBot.Theme.Material.Button();
            this.targetLeaderList = new RSBot.Theme.Controls.ListView();
            this.colname = new System.Windows.Forms.ColumnHeader();
            this.targetLeaderContext = new System.Windows.Forms.ContextMenu();
            this.menuRemoveTarget = new System.Windows.Forms.MenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tracePlayerList = new RSBot.Theme.Controls.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.chatCommandersContext = new System.Windows.Forms.ContextMenu();
            this.menuRemove = new System.Windows.Forms.MenuItem();
            this.addToListBtn = new RSBot.Theme.Material.Button();
            this.playnameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 459);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.targetLeaderTextBox);
            this.groupBox2.Controls.Add(this.addToTargetListBtn);
            this.groupBox2.Controls.Add(this.targetLeaderList);
            this.groupBox2.Location = new System.Drawing.Point(17, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Leader";
            // 
            // targetLeaderTextBox
            // 
            this.targetLeaderTextBox.Location = new System.Drawing.Point(9, 89);
            this.targetLeaderTextBox.Name = "targetLeaderTextBox";
            this.targetLeaderTextBox.Size = new System.Drawing.Size(152, 20);
            this.targetLeaderTextBox.TabIndex = 7;
            // 
            // addToTargetListBtn
            // 
            this.addToTargetListBtn.Depth = 0;
            this.addToTargetListBtn.Font = new System.Drawing.Font("Wingdings 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (2)));
            this.addToTargetListBtn.Icon = null;
            this.addToTargetListBtn.Location = new System.Drawing.Point(186, 89);
            this.addToTargetListBtn.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.addToTargetListBtn.Name = "addToTargetListBtn";
            this.addToTargetListBtn.Primary = true;
            this.addToTargetListBtn.Raised = true;
            this.addToTargetListBtn.SingleColor = System.Drawing.Color.SeaGreen;
            this.addToTargetListBtn.Size = new System.Drawing.Size(57, 20);
            this.addToTargetListBtn.TabIndex = 1;
            this.addToTargetListBtn.Text = "P";
            this.addToTargetListBtn.UseVisualStyleBackColor = true;
            this.addToTargetListBtn.Click += new System.EventHandler(this.addToTargetListBtn_Click);
            // 
            // targetLeaderList
            // 
            this.targetLeaderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.colname});
            this.targetLeaderList.ContextMenu = this.targetLeaderContext;
            this.targetLeaderList.FullRowSelect = true;
            this.targetLeaderList.Location = new System.Drawing.Point(9, 19);
            this.targetLeaderList.Name = "targetLeaderList";
            this.targetLeaderList.Size = new System.Drawing.Size(234, 54);
            this.targetLeaderList.TabIndex = 0;
            this.targetLeaderList.UseCompatibleStateImageBehavior = false;
            this.targetLeaderList.View = System.Windows.Forms.View.Details;
            // 
            // colname
            // 
            this.colname.Text = "Name";
            this.colname.Width = 225;
            // 
            // targetLeaderContext
            // 
            this.targetLeaderContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuRemoveTarget});
            // 
            // menuRemoveTarget
            // 
            this.menuRemoveTarget.Index = 0;
            this.menuRemoveTarget.Text = "Remove";
            this.menuRemoveTarget.Click += new System.EventHandler(this.menuRemoveTarget_Remove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tracePlayerList);
            this.groupBox1.Controls.Add(this.addToListBtn);
            this.groupBox1.Controls.Add(this.playnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat Commander(s)";
            // 
            // tracePlayerList
            // 
            this.tracePlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnName});
            this.tracePlayerList.ContextMenu = this.chatCommandersContext;
            this.tracePlayerList.FullRowSelect = true;
            this.tracePlayerList.HideSelection = false;
            this.tracePlayerList.Location = new System.Drawing.Point(6, 19);
            this.tracePlayerList.Name = "tracePlayerList";
            this.tracePlayerList.Size = new System.Drawing.Size(234, 146);
            this.tracePlayerList.TabIndex = 0;
            this.tracePlayerList.UseCompatibleStateImageBehavior = false;
            this.tracePlayerList.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 225;
            // 
            // chatCommandersContext
            // 
            this.chatCommandersContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.menuRemove});
            // 
            // menuRemove
            // 
            this.menuRemove.Index = 0;
            this.menuRemove.Text = "Remove";
            this.menuRemove.Click += new System.EventHandler(this.menuRemove_Remove);
            // 
            // addToListBtn
            // 
            this.addToListBtn.Depth = 0;
            this.addToListBtn.Font = new System.Drawing.Font("Wingdings 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (2)));
            this.addToListBtn.Icon = null;
            this.addToListBtn.Location = new System.Drawing.Point(183, 171);
            this.addToListBtn.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Primary = true;
            this.addToListBtn.Raised = true;
            this.addToListBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addToListBtn.SingleColor = System.Drawing.Color.SeaGreen;
            this.addToListBtn.Size = new System.Drawing.Size(57, 20);
            this.addToListBtn.TabIndex = 1;
            this.addToListBtn.Text = "P";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // playnameTextBox
            // 
            this.playnameTextBox.Location = new System.Drawing.Point(6, 171);
            this.playnameTextBox.Name = "playnameTextBox";
            this.playnameTextBox.Size = new System.Drawing.Size(152, 20);
            this.playnameTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(719, 459);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ContextMenu targetLeaderContext;

        private System.Windows.Forms.ContextMenu chatCommandersContext;
        private System.Windows.Forms.TextBox targetLeaderTextBox;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader colname;
        private RSBot.Theme.Material.Button addToTargetListBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private RSBot.Theme.Controls.ListView targetLeaderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox playnameTextBox;
        private RSBot.Theme.Controls.ListView tracePlayerList;
        private RSBot.Theme.Material.Button addToListBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuItem menuRemove;
        private System.Windows.Forms.MenuItem menuRemoveTarget;

        #endregion
    }
}