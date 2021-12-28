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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listFriendlyGuilds = new RSBot.Theme.Controls.ListView();
            this.columnFriendlyGuilds = new System.Windows.Forms.ColumnHeader();
            this.chatCommandersContext = new System.Windows.Forms.ContextMenu();
            this.menuRemove = new System.Windows.Forms.MenuItem();
            this.btnAddFriendlyGuild = new RSBot.Theme.Material.Button();
            this.txtFriendlyGuild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioGuildlist = new System.Windows.Forms.CheckBox();
            this.radioZerkers = new System.Windows.Forms.CheckBox();
            this.chatCommandChatBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.targetSupportCheckBox = new System.Windows.Forms.CheckBox();
            this.aiTargetingCheckbox = new System.Windows.Forms.CheckBox();
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
            this.addToListBtn = new RSBot.Theme.Material.Button();
            this.playnameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 467);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listFriendlyGuilds);
            this.groupBox5.Controls.Add(this.btnAddFriendlyGuild);
            this.groupBox5.Controls.Add(this.txtFriendlyGuild);
            this.groupBox5.Location = new System.Drawing.Point(13, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 155);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Friendly Guild(s)";
            // 
            // listFriendlyGuilds
            // 
            this.listFriendlyGuilds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnFriendlyGuilds});
            this.listFriendlyGuilds.ContextMenu = this.chatCommandersContext;
            this.listFriendlyGuilds.FullRowSelect = true;
            this.listFriendlyGuilds.HideSelection = false;
            this.listFriendlyGuilds.Location = new System.Drawing.Point(6, 19);
            this.listFriendlyGuilds.Name = "listFriendlyGuilds";
            this.listFriendlyGuilds.Size = new System.Drawing.Size(179, 104);
            this.listFriendlyGuilds.TabIndex = 0;
            this.listFriendlyGuilds.UseCompatibleStateImageBehavior = false;
            this.listFriendlyGuilds.View = System.Windows.Forms.View.Details;
            // 
            // columnFriendlyGuilds
            // 
            this.columnFriendlyGuilds.Text = "Name";
            this.columnFriendlyGuilds.Width = 176;
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
            // btnAddFriendlyGuild
            // 
            this.btnAddFriendlyGuild.Depth = 0;
            this.btnAddFriendlyGuild.Font = new System.Drawing.Font("Wingdings 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (2)));
            this.btnAddFriendlyGuild.Icon = null;
            this.btnAddFriendlyGuild.Location = new System.Drawing.Point(141, 128);
            this.btnAddFriendlyGuild.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.btnAddFriendlyGuild.Name = "btnAddFriendlyGuild";
            this.btnAddFriendlyGuild.Primary = true;
            this.btnAddFriendlyGuild.Raised = true;
            this.btnAddFriendlyGuild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddFriendlyGuild.SingleColor = System.Drawing.Color.SeaGreen;
            this.btnAddFriendlyGuild.Size = new System.Drawing.Size(44, 20);
            this.btnAddFriendlyGuild.TabIndex = 1;
            this.btnAddFriendlyGuild.Text = "P";
            this.btnAddFriendlyGuild.UseVisualStyleBackColor = true;
            this.btnAddFriendlyGuild.Click += new System.EventHandler(this.btnAddFriendlyGuild_Click);
            // 
            // txtFriendlyGuild
            // 
            this.txtFriendlyGuild.Location = new System.Drawing.Point(6, 129);
            this.txtFriendlyGuild.Name = "txtFriendlyGuild";
            this.txtFriendlyGuild.Size = new System.Drawing.Size(116, 20);
            this.txtFriendlyGuild.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.label1.Location = new System.Drawing.Point(19, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Feature works when bot is not running";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioGuildlist);
            this.groupBox4.Controls.Add(this.radioZerkers);
            this.groupBox4.Controls.Add(this.chatCommandChatBox);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(13, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // radioGuildlist
            // 
            this.radioGuildlist.Location = new System.Drawing.Point(6, 67);
            this.radioGuildlist.Name = "radioGuildlist";
            this.radioGuildlist.Size = new System.Drawing.Size(188, 18);
            this.radioGuildlist.TabIndex = 3;
            this.radioGuildlist.Text = "Ignore from guildlist";
            this.radioGuildlist.UseVisualStyleBackColor = true;
            this.radioGuildlist.CheckedChanged += new System.EventHandler(this.radioGuildlist_CheckedChanged);
            // 
            // radioZerkers
            // 
            this.radioZerkers.Location = new System.Drawing.Point(6, 44);
            this.radioZerkers.Name = "radioZerkers";
            this.radioZerkers.Size = new System.Drawing.Size(173, 17);
            this.radioZerkers.TabIndex = 2;
            this.radioZerkers.Text = "Target zerkers first";
            this.radioZerkers.UseVisualStyleBackColor = true;
            this.radioZerkers.CheckedChanged += new System.EventHandler(this.radioZerkers_CheckedChanged);
            // 
            // chatCommandChatBox
            // 
            this.chatCommandChatBox.Location = new System.Drawing.Point(6, 19);
            this.chatCommandChatBox.Name = "chatCommandChatBox";
            this.chatCommandChatBox.Size = new System.Drawing.Size(188, 19);
            this.chatCommandChatBox.TabIndex = 1;
            this.chatCommandChatBox.Text = "Use Chat Commands";
            this.chatCommandChatBox.UseVisualStyleBackColor = true;
            this.chatCommandChatBox.CheckedChanged += new System.EventHandler(this.chatCommandChatBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.targetSupportCheckBox);
            this.groupBox3.Controls.Add(this.aiTargetingCheckbox);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 70);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Targeting mode";
            // 
            // targetSupportCheckBox
            // 
            this.targetSupportCheckBox.Location = new System.Drawing.Point(6, 40);
            this.targetSupportCheckBox.Name = "targetSupportCheckBox";
            this.targetSupportCheckBox.Size = new System.Drawing.Size(210, 24);
            this.targetSupportCheckBox.TabIndex = 2;
            this.targetSupportCheckBox.Text = "Target Support for Target Leader";
            this.targetSupportCheckBox.UseVisualStyleBackColor = true;
            this.targetSupportCheckBox.CheckedChanged += new System.EventHandler(this.targetSupportCheckBox_CheckedChanged);
            // 
            // aiTargetingCheckbox
            // 
            this.aiTargetingCheckbox.Location = new System.Drawing.Point(6, 19);
            this.aiTargetingCheckbox.Name = "aiTargetingCheckbox";
            this.aiTargetingCheckbox.Size = new System.Drawing.Size(119, 24);
            this.aiTargetingCheckbox.TabIndex = 0;
            this.aiTargetingCheckbox.Text = "Use Ai-Targeting";
            this.aiTargetingCheckbox.UseVisualStyleBackColor = true;
            this.aiTargetingCheckbox.CheckedChanged += new System.EventHandler(this.aiTargetingCheckbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.targetLeaderTextBox);
            this.groupBox2.Controls.Add(this.addToTargetListBtn);
            this.groupBox2.Controls.Add(this.targetLeaderList);
            this.groupBox2.Location = new System.Drawing.Point(481, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Leader";
            // 
            // targetLeaderTextBox
            // 
            this.targetLeaderTextBox.Location = new System.Drawing.Point(9, 79);
            this.targetLeaderTextBox.Name = "targetLeaderTextBox";
            this.targetLeaderTextBox.Size = new System.Drawing.Size(116, 20);
            this.targetLeaderTextBox.TabIndex = 7;
            // 
            // addToTargetListBtn
            // 
            this.addToTargetListBtn.Depth = 0;
            this.addToTargetListBtn.Font = new System.Drawing.Font("Wingdings 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (2)));
            this.addToTargetListBtn.Icon = null;
            this.addToTargetListBtn.Location = new System.Drawing.Point(144, 79);
            this.addToTargetListBtn.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.addToTargetListBtn.Name = "addToTargetListBtn";
            this.addToTargetListBtn.Primary = true;
            this.addToTargetListBtn.Raised = true;
            this.addToTargetListBtn.SingleColor = System.Drawing.Color.SeaGreen;
            this.addToTargetListBtn.Size = new System.Drawing.Size(44, 20);
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
            this.targetLeaderList.Size = new System.Drawing.Size(179, 54);
            this.targetLeaderList.TabIndex = 0;
            this.targetLeaderList.UseCompatibleStateImageBehavior = false;
            this.targetLeaderList.View = System.Windows.Forms.View.Details;
            // 
            // colname
            // 
            this.colname.Text = "Name";
            this.colname.Width = 176;
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
            this.groupBox1.Location = new System.Drawing.Point(257, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 148);
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
            this.tracePlayerList.Size = new System.Drawing.Size(179, 97);
            this.tracePlayerList.TabIndex = 0;
            this.tracePlayerList.UseCompatibleStateImageBehavior = false;
            this.tracePlayerList.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 175;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Depth = 0;
            this.addToListBtn.Font = new System.Drawing.Font("Wingdings 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (2)));
            this.addToListBtn.Icon = null;
            this.addToListBtn.Location = new System.Drawing.Point(141, 122);
            this.addToListBtn.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Primary = true;
            this.addToListBtn.Raised = true;
            this.addToListBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addToListBtn.SingleColor = System.Drawing.Color.SeaGreen;
            this.addToListBtn.Size = new System.Drawing.Size(44, 20);
            this.addToListBtn.TabIndex = 1;
            this.addToListBtn.Text = "P";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // playnameTextBox
            // 
            this.playnameTextBox.Location = new System.Drawing.Point(6, 122);
            this.playnameTextBox.Name = "playnameTextBox";
            this.playnameTextBox.Size = new System.Drawing.Size(116, 20);
            this.playnameTextBox.TabIndex = 4;
            // 
            // Main
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(719, 467);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox5;
        private RSBot.Theme.Controls.ListView listFriendlyGuilds;
        private System.Windows.Forms.ColumnHeader columnFriendlyGuilds;
        private RSBot.Theme.Material.Button btnAddFriendlyGuild;
        private System.Windows.Forms.TextBox txtFriendlyGuild;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox radioZerkers;
        private System.Windows.Forms.CheckBox radioGuildlist;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox aiTargetingCheckbox;
        private System.Windows.Forms.CheckBox chatCommandChatBox;
        private System.Windows.Forms.CheckBox targetSupportCheckBox;

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