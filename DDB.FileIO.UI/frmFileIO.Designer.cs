namespace DDB.FileIO.UI
{
    partial class frmFileIO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSave = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblTimer = new ToolStripStatusLabel();
            lblTimer2 = new ToolStripStatusLabel();
            txtTextArea = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(490, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSave, mnuFileSaveAs });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(114, 22);
            mnuFileNew.Text = "&New";
            mnuFileNew.Click += mnuFileNew_Click;
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(114, 22);
            mnuFileOpen.Text = "&Open";
            mnuFileOpen.Click += mnuFileOpen_Click;
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.Size = new Size(114, 22);
            mnuFileSave.Text = "&Save";
            mnuFileSave.Click += mnuFileSave_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(114, 22);
            mnuFileSaveAs.Text = "Save &As";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(44, 20);
            mnuHelp.Text = "&Help";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblTimer, lblTimer2 });
            statusStrip1.Location = new Point(0, 514);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(490, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 17);
            lblStatus.Text = "Status here";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 17);
            // 
            // lblTimer2
            // 
            lblTimer2.Name = "lblTimer2";
            lblTimer2.Size = new Size(37, 17);
            lblTimer2.Text = "Timer";
            lblTimer2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTextArea
            // 
            txtTextArea.Dock = DockStyle.Fill;
            txtTextArea.Location = new Point(0, 24);
            txtTextArea.Name = "txtTextArea";
            txtTextArea.Size = new Size(490, 490);
            txtTextArea.TabIndex = 2;
            txtTextArea.Text = "";
            txtTextArea.TextChanged += txtTextArea_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmFileIO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 536);
            Controls.Add(txtTextArea);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmFileIO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File I/O";
            Load += frmFileIO_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripMenuItem mnuHelp;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private RichTextBox txtTextArea;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblTimer;
        private ToolStripStatusLabel lblTimer2;
    }
}