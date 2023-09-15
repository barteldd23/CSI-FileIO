namespace DDB.FileIO.UI
{ // test after connection
    public partial class frmFileIO : Form
    {
        const string INITIAL_DIRECTORY = @"C:\Users\Dean\Desktop\FVTC\C#Intermediate\";
        string fileName = @"C:\Users\Dean\Desktop\FVTC\C#Intermediate\";
        string strLastSavedText = string.Empty;

        public frmFileIO()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            var result = checkSaveChanges();

            if (result != DialogResult.Cancel)
            {
                //load new frmFileIO
                txtTextArea.Text = string.Empty;
                fileName = INITIAL_DIRECTORY;
                lblStatus.Text = string.Empty;
                strLastSavedText = lblStatus.Text;
            }


        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            var result = checkSaveChanges();

            if (result != DialogResult.Cancel)
            {

                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = INITIAL_DIRECTORY;
                    openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        // Read the File and set as LastSavedText;
                        StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                        fileName = openFileDialog.FileName;
                        string contents = streamReader.ReadToEnd();
                        txtTextArea.Text = contents;
                        strLastSavedText = txtTextArea.Text;

                        lblStatus.Text = fileName;
                        lblStatus.ForeColor = Color.Blue;

                        streamReader.Close();
                        streamReader = null;
                    }
                    else
                    {
                        throw new Exception("No file selected.");
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                    lblStatus.ForeColor = Color.Red;
                }

            }


        }

        public DialogResult checkSaveChanges()
        //Method returns a Dialog result: yes, no, cancel.
        //Purpose is to determine if the user hits cancel, Then dont execute the code like New File or Open File.
        //Then Returns back to form without saving and without doing anything.
        {
            DialogResult result = DialogResult.No;
            //Check if document has been changed
            if (txtTextArea.Text != string.Empty && txtTextArea.Text != strLastSavedText)
            {
                //prompt new form load to ask if you want to save
                string message = "Would you like to save the current file?";
                string caption = "Closing Current File";
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                }

            }
            return result;

        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public void SaveChanges()
        {
            // Never was saved, prompt for new directory path and name
            if (fileName == INITIAL_DIRECTORY)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save File as";
                saveFileDialog.InitialDirectory = INITIAL_DIRECTORY;
                saveFileDialog.Filter = "Text File|*.txt|All File Types|*.*";


                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = saveFileDialog.FileName;
                        StreamWriter streamWriter = new StreamWriter(fileName);
                        streamWriter.WriteLine(txtTextArea.Text);
                        strLastSavedText = txtTextArea.Text;

                        streamWriter.Close();
                        streamWriter = null;
                        lblStatus.Text = $"{fileName} saved.";
                        lblStatus.ForeColor = Color.Blue;
                    }
                    else
                    {
                        throw new Exception("No file selected.");
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                    lblStatus.ForeColor = Color.Red;
                }
            }
            else // file is already created, write over it.
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(fileName);
                    streamWriter.WriteLine(txtTextArea.Text);
                    strLastSavedText = txtTextArea.Text;

                    streamWriter.Close();
                    streamWriter = null;
                    lblStatus.Text = $"{fileName} saved.";
                    lblStatus.ForeColor = Color.Blue;
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                    lblStatus.ForeColor = Color.Red;
                }
            }
        }

        private void txtTextArea_TextChanged(object sender, EventArgs e)
        //Display Status message on to show if file is aved or not.
        {
            if (strLastSavedText != txtTextArea.Text || (fileName == INITIAL_DIRECTORY && txtTextArea.Text != string.Empty))
            {
                lblStatus.Text = $"{fileName} not saved.";
                lblStatus.ForeColor = Color.OrangeRed;
            }
            else if (strLastSavedText == txtTextArea.Text && strLastSavedText != string.Empty)
            {
                lblStatus.Text = $"{fileName} No Changes";
                lblStatus.ForeColor = Color.Blue;
            }
            else
            {
                lblStatus.Text = string.Empty;
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File as";
            saveFileDialog.InitialDirectory = INITIAL_DIRECTORY;
            saveFileDialog.Filter = "Text File|*.txt|All File Types|*.*";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    StreamWriter streamWriter = new StreamWriter(fileName);
                    streamWriter.WriteLine(txtTextArea.Text);
                    strLastSavedText = txtTextArea.Text;

                    streamWriter.Close();
                    streamWriter = null;
                    lblStatus.Text = $"{fileName} saved.";
                    lblStatus.ForeColor = Color.Blue;
                }
                else
                {
                    throw new Exception("No file selected.");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer2.Text = DateTime.Now.ToString();
        }

        private void frmFileIO_Load(object sender, EventArgs e)
        {
            lblTimer2.Spring = true;
            lblStatus.Spring = true;

            //lblTimer2.Alignment = ToolStripItemAlignment.Right;
            //lblStatus.Alignment = ToolStripItemAlignment.Left;
            //lblTimer2.Padding = new Padding(0);
            timer1.Enabled = true;
        }
    }
}