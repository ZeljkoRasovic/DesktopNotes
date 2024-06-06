using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace DesktopNotes
{
    public partial class DesktopNotes : Form
    {
        private bool fileAlreadySaved = false;
        private bool fileUpdated = false;
        private string currentFileName = "";
        private FontDialog FD = new FontDialog();

        public DesktopNotes()
        {
            InitializeComponent();
        }

        private void desktopNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application's name is Desktop Notes", "Desktop Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newFile()
        {
            if (fileUpdated)
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:
                        saveFileUpdated();
                        clearScreen();
                        break;

                    case DialogResult.No:
                        clearScreen();
                        break;
                }
            }
            else
            {
                clearScreen();
            }

            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            DialogResult result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(OFD.FileName) == ".txt")
                {
                    MainRichTextBox.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(OFD.FileName) == ".rtf")
                {
                    MainRichTextBox.LoadFile(OFD.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(OFD.FileName) + " - Desktop Notes";


                fileAlreadySaved = true;
                fileUpdated = false;
                currentFileName = OFD.FileName;
            }

            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            DialogResult saveFileResult = SFD.ShowDialog();

            if (saveFileResult == DialogResult.OK)
            {
                if (Path.GetExtension(SFD.FileName) == ".txt")
                {
                    MainRichTextBox.SaveFile(SFD.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(SFD.FileName) == ".rtf")
                {
                    MainRichTextBox.SaveFile(SFD.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(SFD.FileName) + " - Desktop Notes";

                fileAlreadySaved = true;
                fileUpdated = false;
                currentFileName = SFD.FileName;
            }
        }

        private void DesktopNotes_Load(object sender, EventArgs e)
        {
            fileAlreadySaved = false;
            fileUpdated = false;
            currentFileName = "";
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            fileUpdated = true;
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = true;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileUpdated();
        }

        private void saveFileUpdated()
        {
            if (fileAlreadySaved)
            {
                if (Path.GetExtension(currentFileName) == ".txt")
                {
                    MainRichTextBox.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(currentFileName) == ".rtf")
                {
                    MainRichTextBox.SaveFile(currentFileName, RichTextBoxStreamType.RichText);
                }

                fileUpdated = false;
            }
            else
            {
                if (fileUpdated)
                {
                    saveFile();
                }
                else
                {
                    clearScreen();
                }
            }
        }

        private void clearScreen()
        {
            MainRichTextBox.Clear();
            fileUpdated = false;
            this.Text = "Desktop Notes";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = true;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText = DateTime.Now.ToString();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Bold);
        }

        private void fontTextStyle(FontStyle fontStyle)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, fontStyle);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Underline);
        }

        private void strikthroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Strikeout);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Regular);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FD.ShowColor = true;
            FD.ShowApply = true;

            FD.Apply += new System.EventHandler(fontApplyDialog);

            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (MainRichTextBox.SelectionLength > 0 && MainRichTextBox.SelectionLength < 73)
                {
                    MainRichTextBox.SelectionFont = FD.Font;
                    MainRichTextBox.SelectionColor = FD.Color;
                }
            }
        }

        private void fontApplyDialog(object? sender, EventArgs e)
        {
            if (MainRichTextBox.SelectionLength > 0 && MainRichTextBox.SelectionLength < 73)
            {
                MainRichTextBox.SelectionFont = FD.Font;
                MainRichTextBox.SelectionColor = FD.Color;
            }
        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            DialogResult result = CD.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (MainRichTextBox.SelectionLength > 0 && MainRichTextBox.SelectionLength < 73)
                {
                    MainRichTextBox.SelectionColor = CD.Color;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileUpdated();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText = DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MainRichTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Enabled = true;
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = true;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Regular);
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Bold);
        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Italic);
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontTextStyle(FontStyle.Underline);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }
    }
}
