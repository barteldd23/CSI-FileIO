namespace DDB.FileIO.UI
{
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
            checkSaveChanges();

            //load new frmFileIO


        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            checkSaveChanges();

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

        public void checkSaveChanges()
        {
            //Check if document has been changed
            if (strLastSavedText != txtTextArea.Text)
            {
                //prompt new form load to ask if you want to save
                string message = "Changes to your file are not saved. Would you like to save?";
                string caption = "Closing Current File";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // fire save method
                }
            }

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
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
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
        {
            if(strLastSavedText != txtTextArea.Text || (fileName == INITIAL_DIRECTORY && txtTextArea.Text != string.Empty))
            {
                lblStatus.Text = $"{fileName} not saved.";
                lblStatus.ForeColor = Color.OrangeRed;
            }else if(strLastSavedText == txtTextArea.Text && strLastSavedText != string.Empty)
            {
                lblStatus.Text = "No Changes";
                lblStatus.ForeColor = Color.Blue;
            }
            else
            {
                lblStatus.Text = string.Empty;
            }
        }
    }
}