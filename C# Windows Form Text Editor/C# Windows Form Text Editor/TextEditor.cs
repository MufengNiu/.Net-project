using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    internal partial class TextEditor : Form
    {
        private Account currentUser;
        private String currentFilePath = "";

        //private Boolean textHaveChanged = false;
        private Boolean isNewFile = true;
        private Boolean isFileChanged = false;

        public TextEditor(Account account)
        {
            InitializeComponent();
            this.currentUser = account;
        }

        // Set label information on Menu stripe, Set user access level
        private void TextEditor_Load(object sender, EventArgs e)
        {
            String displayInfo = "Currently logged in as: " + currentUser.getUsername() + "   User type: " + currentUser.getUsertype();
            UserLabel.Text = displayInfo;

            if (currentUser.getUsertype().Equals("View"))
            {
                richTextBox.Enabled = false;
                toolStrip2.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                fontToolStripMenuItem.Enabled = false;
                newToolBut.Enabled = false; ;
                saveToolBut.Enabled = false;
                saveasToolBut.Enabled = false;
                boldToolBut.Enabled = false;
                ItalicsToolBut.Enabled = false;
                underlineStripeBut.Enabled = false;
                SizeToolBut.Enabled = false;
                newMenuBut.Enabled = false;
                saveMenuBut.Enabled = false;
                saveasMenuBut.Enabled = false;
            }
        }

        // Open file option 
        private void openMenuBut_Click(object sender , EventArgs e)
        {
      
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Title = "Select Your File";
            saveFileDialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Plain Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.currentFilePath = saveFileDialog.FileName;
                //Text = this.currentFilePath;
                loadFile();
            }

            isFileChanged = false;
            isNewFile = false;
        }

        //New file option for menu strip
        private void newMenuBut_Click(object sender, EventArgs e)
        {

            checkWhetherSave();

            richTextBox.Text = String.Empty;

            isFileChanged = false;
            isNewFile = true;
            currentFilePath = "";
        }

        //Save file option for menu strip
        private void saveMenuBut_Click(object sender, EventArgs e)
        {
            if (isNewFile || currentFilePath == "")
            {
                //If it is a new file rather than a opened file, should be save as
                saveAs();
            }
            else
            {
                saveFile();
            }
        }

        //Save as option for menu strip
        private void saveAsMenuBut_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        //Log Out option for menu strip
        private void logOutMenuBut_Click(object sender, EventArgs e)
        {

            checkWhetherSave();

            Close();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        //Cut option for menu strip
        private void cutMenuBut_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                richTextBox.Cut();
            }
        }

        //Copy option for menu strip
        private void copyMenuBut_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null )
            {
                richTextBox.Copy();
            }
        }

        //Paste option for menu strip
        private void pasteMenuBut_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        //Underline option for menu strip
        private void underlineMenuBut_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont;

            if (currentFont != null)
            {
                 // XOR operation, Set to Underline if it is not , keep original style
                 richTextBox.SelectionFont = new Font(currentFont.Name, currentFont.Size, currentFont.Style ^ FontStyle.Underline);
            }
        }

        //Bold option for menu strip
        private void boldMenuBut_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont;

            if (currentFont != null)
            {
                // XOR operation, Set to Bold if it is not , keep original style
                richTextBox.SelectionFont = new Font(currentFont.Name, currentFont.Size , currentFont.Style ^ FontStyle.Bold );
            }
        }

        //Italic option for menu strip
        private void italicMenuBut_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont;

            if (currentFont != null)
            {

                // XOR operation, Set to italic if it is not , keep original style
                richTextBox.SelectionFont = new Font(currentFont.Name , currentFont.Size , currentFont.Style ^ FontStyle.Italic);
            }
        }

        //Font style option for menu strip
        private void fontStyleMenuBut_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = new Font(dialog.Font.Name, dialog.Font.Size, dialog.Font.Style);
            }
        }

        //Font size option for menu strip
        private void fontSizeMenuBut_Change(object sender, EventArgs e)
        {
           
            Font currentFont = richTextBox.SelectionFont;

            if (richTextBox.SelectionLength > 0 && float.TryParse(SizeToolBut.Text, out float selectedSize))
            {
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, selectedSize, currentFont.Style);
            }

        }

        //About option for menu strip
        private void aboutMenuBut_Click(object sender, EventArgs e)
        {
            String displayText = "Text Editor" + "\n" + "Version: 1.4" + "\n" + "Author: Mufeng Niu" + "\n" + "Current user: " + currentUser.getname();

            MessageBox.Show(displayText, "About",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Load the content of the opened file into the richtext box
        private void loadFile()
        {
  
            string openFile = Path.GetExtension(currentFilePath);
            if (openFile == ".rtf")
            {
                richTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
            }  
            else if (openFile == ".txt")
            {
                richTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
            }
        }

        //Save the content of the current RichTextBox to the current opened file
        private void saveFile()
        {
            String fileFormat = Path.GetExtension(currentFilePath);

            if (fileFormat == ".txt")
            {
                File.WriteAllText(currentFilePath, richTextBox.Text);
            }
            else if (fileFormat == ".rtf")
            {
                File.WriteAllText(currentFilePath, richTextBox.Rtf);
            }

            isNewFile = false;
            isFileChanged = false;

            MessageBox.Show("File have been Saved", "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Save the content of the current RichTextBox to a new file
        private void saveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save as";
            saveFileDialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Plain Text files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                //Text = this.currentFilePath;
                saveFile();
                //richTextBox.Text = saveFileDialog.FileName;
            }

        }

        /* Check whether the content in the richtextbox have changed,
        * if yes , ask whether the user want to save the file
        * Used for open and log out option
        */
        private void checkWhetherSave()
        {
            if (isFileChanged)
            {
                if (isNewFile || currentFilePath == "")
                {
                    DialogResult dialogResult = MessageBox.Show("Save your change to a new file?", "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  
                    if (dialogResult == DialogResult.Yes)
                    {
                        //If it is a new file , should be save as
                        saveAs();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to your change to " + currentFilePath  + " ?", 
                        "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        saveFile();
                    }

                }
            }

            isFileChanged = false;
            isNewFile = false;
        }


        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            isFileChanged = true;
        }

    }
}
