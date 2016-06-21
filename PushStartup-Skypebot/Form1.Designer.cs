namespace PushStartup_Skypebot
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonlogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveMessage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonAddContacts = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxWelcomeMessage = new System.Windows.Forms.RichTextBox();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.buttonSkypeSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchStr = new System.Windows.Forms.TextBox();
            this.checkedListBoxSearchUsers = new System.Windows.Forms.CheckedListBox();
            this.tabPageMesaageTemplate = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxReports = new System.Windows.Forms.ListBox();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.tabPageSkypeUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewSkypeUsers = new System.Windows.Forms.DataGridView();
            this.toolStripButtonskypeusers = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabPageMesaageTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.tabPageSkypeUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkypeUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonlogin,
            this.toolStripButtonSaveMessage,
            this.toolStripButtonSaveReport,
            this.toolStripButtonskypeusers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonlogin
            // 
            this.toolStripButtonlogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonlogin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonlogin.Image")));
            this.toolStripButtonlogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonlogin.Name = "toolStripButtonlogin";
            this.toolStripButtonlogin.Size = new System.Drawing.Size(50, 24);
            this.toolStripButtonlogin.Text = "Login";
            this.toolStripButtonlogin.Click += new System.EventHandler(this.toolStripButtonlogin_Click);
            // 
            // toolStripButtonSaveMessage
            // 
            this.toolStripButtonSaveMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonSaveMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveMessage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveMessage.Image")));
            this.toolStripButtonSaveMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveMessage.Name = "toolStripButtonSaveMessage";
            this.toolStripButtonSaveMessage.Size = new System.Drawing.Size(112, 24);
            this.toolStripButtonSaveMessage.Text = "Save Messages";
            // 
            // toolStripButtonSaveReport
            // 
            this.toolStripButtonSaveReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveReport.Image")));
            this.toolStripButtonSaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveReport.Name = "toolStripButtonSaveReport";
            this.toolStripButtonSaveReport.Size = new System.Drawing.Size(93, 24);
            this.toolStripButtonSaveReport.Text = "Save Report";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(821, 447);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 27);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(821, 472);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageLogin);
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageMesaageTemplate);
            this.tabControlMain.Controls.Add(this.tabPageReports);
            this.tabControlMain.Controls.Add(this.tabPageSkypeUsers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(821, 447);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Size = new System.Drawing.Size(813, 418);
            this.tabPageLogin.TabIndex = 4;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.splitContainerMain);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(813, 418);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 3);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.buttonAddContacts);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonSend);
            this.splitContainerMain.Panel1.Controls.Add(this.richTextBoxWelcomeMessage);
            this.splitContainerMain.Panel1.Controls.Add(this.labelWelcomeMessage);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonSkypeSearch);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSearchStr);
            this.splitContainerMain.Panel1MinSize = 10;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.checkedListBoxSearchUsers);
            this.splitContainerMain.Size = new System.Drawing.Size(807, 412);
            this.splitContainerMain.SplitterDistance = 146;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonAddContacts
            // 
            this.buttonAddContacts.Location = new System.Drawing.Point(613, 104);
            this.buttonAddContacts.Name = "buttonAddContacts";
            this.buttonAddContacts.Size = new System.Drawing.Size(162, 28);
            this.buttonAddContacts.TabIndex = 11;
            this.buttonAddContacts.Text = "&Add To Contacts";
            this.buttonAddContacts.UseVisualStyleBackColor = true;
            this.buttonAddContacts.Click += new System.EventHandler(this.buttonAddContacts_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(613, 57);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(162, 28);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Sen&d Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxWelcomeMessage
            // 
            this.richTextBoxWelcomeMessage.Location = new System.Drawing.Point(175, 57);
            this.richTextBoxWelcomeMessage.Name = "richTextBoxWelcomeMessage";
            this.richTextBoxWelcomeMessage.Size = new System.Drawing.Size(402, 70);
            this.richTextBoxWelcomeMessage.TabIndex = 9;
            this.richTextBoxWelcomeMessage.Text = "Hi. Wecome ";
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.Location = new System.Drawing.Point(22, 57);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(147, 40);
            this.labelWelcomeMessage.TabIndex = 8;
            this.labelWelcomeMessage.Text = "Welcome(Opening)   Message";
            // 
            // buttonSkypeSearch
            // 
            this.buttonSkypeSearch.Location = new System.Drawing.Point(613, 12);
            this.buttonSkypeSearch.Name = "buttonSkypeSearch";
            this.buttonSkypeSearch.Size = new System.Drawing.Size(162, 28);
            this.buttonSkypeSearch.TabIndex = 7;
            this.buttonSkypeSearch.Text = "&Search In Skype";
            this.buttonSkypeSearch.UseVisualStyleBackColor = true;
            this.buttonSkypeSearch.Click += new System.EventHandler(this.buttonSkypeSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search String";
            // 
            // textBoxSearchStr
            // 
            this.textBoxSearchStr.Location = new System.Drawing.Point(175, 18);
            this.textBoxSearchStr.Name = "textBoxSearchStr";
            this.textBoxSearchStr.Size = new System.Drawing.Size(402, 22);
            this.textBoxSearchStr.TabIndex = 5;
            // 
            // checkedListBoxSearchUsers
            // 
            this.checkedListBoxSearchUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxSearchUsers.FormattingEnabled = true;
            this.checkedListBoxSearchUsers.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxSearchUsers.Name = "checkedListBoxSearchUsers";
            this.checkedListBoxSearchUsers.Size = new System.Drawing.Size(807, 262);
            this.checkedListBoxSearchUsers.TabIndex = 0;
            this.checkedListBoxSearchUsers.UseCompatibleTextRendering = true;
            // 
            // tabPageMesaageTemplate
            // 
            this.tabPageMesaageTemplate.Controls.Add(this.dataGridView1);
            this.tabPageMesaageTemplate.Location = new System.Drawing.Point(4, 25);
            this.tabPageMesaageTemplate.Name = "tabPageMesaageTemplate";
            this.tabPageMesaageTemplate.Size = new System.Drawing.Size(813, 418);
            this.tabPageMesaageTemplate.TabIndex = 3;
            this.tabPageMesaageTemplate.Text = "Mesaage Template";
            this.tabPageMesaageTemplate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.splitContainer1);
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(813, 418);
            this.tabPageReports.TabIndex = 1;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxReports);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewReports);
            this.splitContainer1.Size = new System.Drawing.Size(807, 412);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxReports
            // 
            this.listBoxReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReports.FormattingEnabled = true;
            this.listBoxReports.ItemHeight = 16;
            this.listBoxReports.Location = new System.Drawing.Point(0, 0);
            this.listBoxReports.Name = "listBoxReports";
            this.listBoxReports.Size = new System.Drawing.Size(171, 412);
            this.listBoxReports.TabIndex = 0;
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReports.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowTemplate.Height = 24;
            this.dataGridViewReports.Size = new System.Drawing.Size(632, 412);
            this.dataGridViewReports.TabIndex = 0;
            // 
            // tabPageSkypeUsers
            // 
            this.tabPageSkypeUsers.Controls.Add(this.dataGridViewSkypeUsers);
            this.tabPageSkypeUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPageSkypeUsers.Name = "tabPageSkypeUsers";
            this.tabPageSkypeUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkypeUsers.Size = new System.Drawing.Size(813, 418);
            this.tabPageSkypeUsers.TabIndex = 2;
            this.tabPageSkypeUsers.Text = "Skype Users";
            this.tabPageSkypeUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSkypeUsers
            // 
            this.dataGridViewSkypeUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkypeUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSkypeUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSkypeUsers.Name = "dataGridViewSkypeUsers";
            this.dataGridViewSkypeUsers.RowTemplate.Height = 24;
            this.dataGridViewSkypeUsers.Size = new System.Drawing.Size(807, 412);
            this.dataGridViewSkypeUsers.TabIndex = 0;
            // 
            // toolStripButtonskypeusers
            // 
            this.toolStripButtonskypeusers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonskypeusers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonskypeusers.Image")));
            this.toolStripButtonskypeusers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonskypeusers.Name = "toolStripButtonskypeusers";
            this.toolStripButtonskypeusers.Size = new System.Drawing.Size(144, 24);
            this.toolStripButtonskypeusers.Text = "Update Skype Users";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 521);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "PushStartup-SkypeBot";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabPageMesaageTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageReports.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.tabPageSkypeUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkypeUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageSkypeUsers;
        private System.Windows.Forms.DataGridView dataGridViewSkypeUsers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxReports;
        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.TabPage tabPageMesaageTemplate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBoxWelcomeMessage;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.Button buttonSkypeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchStr;
        private System.Windows.Forms.CheckedListBox checkedListBoxSearchUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonlogin;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveMessage;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveReport;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.Button buttonAddContacts;
        private System.Windows.Forms.ToolStripButton toolStripButtonskypeusers;
    }
}

