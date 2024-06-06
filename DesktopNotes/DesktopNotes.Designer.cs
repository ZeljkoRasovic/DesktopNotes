namespace DesktopNotes
{
    partial class DesktopNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopNotes));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            sellectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator12 = new ToolStripSeparator();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            formateToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            changeTextColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            normalToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            strikthroToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            desktopNotesToolStripMenuItem = new ToolStripMenuItem();
            MainRichTextBox = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            undoToolStripMenuItem1 = new ToolStripMenuItem();
            redoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            dateTimeToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            saveToolStripMenuItem2 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            normalToolStripMenuItem1 = new ToolStripMenuItem();
            boldToolStripMenuItem1 = new ToolStripMenuItem();
            italicToolStripMenuItem1 = new ToolStripMenuItem();
            underlineToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formateToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, toolStripSeparator1, openToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem, saveToolStripMenuItem1, toolStripSeparator4, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Image = (Image)resources.GetObject("fileToolStripMenuItem1.Image");
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.N;
            fileToolStripMenuItem1.Size = new Size(188, 26);
            fileToolStripMenuItem1.Text = "&New";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(185, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(188, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(188, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Image = (Image)resources.GetObject("saveToolStripMenuItem1.Image");
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveToolStripMenuItem1.Size = new Size(188, 26);
            saveToolStripMenuItem1.Text = "S&ave as";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Q;
            exitToolStripMenuItem.Size = new Size(188, 26);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator5, cutToolStripMenuItem1, copyToolStripMenuItem1, pasteToolStripMenuItem1, sellectAllToolStripMenuItem, toolStripSeparator12, dateTimeToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(178, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            redoToolStripMenuItem.Size = new Size(178, 26);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(175, 6);
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Image = (Image)resources.GetObject("cutToolStripMenuItem1.Image");
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem1.Size = new Size(178, 26);
            cutToolStripMenuItem1.Text = "&Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Image = (Image)resources.GetObject("copyToolStripMenuItem1.Image");
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem1.Size = new Size(178, 26);
            copyToolStripMenuItem1.Text = "Cop&y";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Image = (Image)resources.GetObject("pasteToolStripMenuItem1.Image");
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem1.Size = new Size(178, 26);
            pasteToolStripMenuItem1.Text = "&Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click;
            // 
            // sellectAllToolStripMenuItem
            // 
            sellectAllToolStripMenuItem.Image = (Image)resources.GetObject("sellectAllToolStripMenuItem.Image");
            sellectAllToolStripMenuItem.Name = "sellectAllToolStripMenuItem";
            sellectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            sellectAllToolStripMenuItem.Size = new Size(178, 26);
            sellectAllToolStripMenuItem.Text = "Se&lect All";
            sellectAllToolStripMenuItem.Click += sellectAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(175, 6);
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.Image = (Image)resources.GetObject("dateTimeToolStripMenuItem.Image");
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.ShortcutKeys = Keys.F12;
            dateTimeToolStripMenuItem.Size = new Size(178, 26);
            dateTimeToolStripMenuItem.Text = "&Date/Time";
            dateTimeToolStripMenuItem.Click += dateTimeToolStripMenuItem_Click;
            // 
            // formateToolStripMenuItem
            // 
            formateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, changeTextColorToolStripMenuItem, toolStripSeparator6, normalToolStripMenuItem, boldToolStripMenuItem, italicToolStripMenuItem, toolStripSeparator7, underlineToolStripMenuItem, strikthroToolStripMenuItem });
            formateToolStripMenuItem.Name = "formateToolStripMenuItem";
            formateToolStripMenuItem.Size = new Size(63, 20);
            formateToolStripMenuItem.Text = "&Formate";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = (Image)resources.GetObject("fontToolStripMenuItem.Image");
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            fontToolStripMenuItem.Size = new Size(249, 26);
            fontToolStripMenuItem.Text = "&Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // changeTextColorToolStripMenuItem
            // 
            changeTextColorToolStripMenuItem.Image = (Image)resources.GetObject("changeTextColorToolStripMenuItem.Image");
            changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            changeTextColorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            changeTextColorToolStripMenuItem.Size = new Size(249, 26);
            changeTextColorToolStripMenuItem.Text = "&Change Text Color";
            changeTextColorToolStripMenuItem.Click += changeTextColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(246, 6);
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Image = (Image)resources.GetObject("normalToolStripMenuItem.Image");
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            normalToolStripMenuItem.Size = new Size(249, 26);
            normalToolStripMenuItem.Text = "&Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Image = (Image)resources.GetObject("boldToolStripMenuItem.Image");
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(249, 26);
            boldToolStripMenuItem.Text = "&Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Image = (Image)resources.GetObject("italicToolStripMenuItem.Image");
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(249, 26);
            italicToolStripMenuItem.Text = "&Italic";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(246, 6);
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Image = (Image)resources.GetObject("underlineToolStripMenuItem.Image");
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            underlineToolStripMenuItem.Size = new Size(249, 26);
            underlineToolStripMenuItem.Text = "Und&erline";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // strikthroToolStripMenuItem
            // 
            strikthroToolStripMenuItem.Image = (Image)resources.GetObject("strikthroToolStripMenuItem.Image");
            strikthroToolStripMenuItem.Name = "strikthroToolStripMenuItem";
            strikthroToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            strikthroToolStripMenuItem.Size = new Size(249, 26);
            strikthroToolStripMenuItem.Text = "&Strikethrough";
            strikthroToolStripMenuItem.Click += strikthroToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desktopNotesToolStripMenuItem });
            aboutToolStripMenuItem.ForeColor = Color.Black;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // desktopNotesToolStripMenuItem
            // 
            desktopNotesToolStripMenuItem.Image = (Image)resources.GetObject("desktopNotesToolStripMenuItem.Image");
            desktopNotesToolStripMenuItem.Name = "desktopNotesToolStripMenuItem";
            desktopNotesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Space;
            desktopNotesToolStripMenuItem.Size = new Size(252, 26);
            desktopNotesToolStripMenuItem.Text = "&Desktop Notes";
            desktopNotesToolStripMenuItem.Click += desktopNotesToolStripMenuItem_Click;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.BackColor = SystemColors.MenuText;
            MainRichTextBox.ContextMenuStrip = contextMenuStrip1;
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.ForeColor = SystemColors.Window;
            MainRichTextBox.Location = new Point(0, 24);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(1262, 621);
            MainRichTextBox.TabIndex = 0;
            MainRichTextBox.Text = "";
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1, toolStripSeparator9, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem, toolStripSeparator10, dateTimeToolStripMenuItem1, toolStripSeparator3, newToolStripMenuItem, openToolStripMenuItem1, toolStripSeparator11, saveToolStripMenuItem2, saveAsToolStripMenuItem, toolStripSeparator8, normalToolStripMenuItem1, boldToolStripMenuItem1, italicToolStripMenuItem1, underlineToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 364);
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Enabled = false;
            undoToolStripMenuItem1.Image = (Image)resources.GetObject("undoToolStripMenuItem1.Image");
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem1.Size = new Size(184, 22);
            undoToolStripMenuItem1.Text = "&Undo";
            undoToolStripMenuItem1.Click += undoToolStripMenuItem1_Click;
            // 
            // redoToolStripMenuItem1
            // 
            redoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Image = (Image)resources.GetObject("redoToolStripMenuItem1.Image");
            redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            redoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            redoToolStripMenuItem1.Size = new Size(184, 22);
            redoToolStripMenuItem1.Text = "&Redo";
            redoToolStripMenuItem1.Click += redoToolStripMenuItem1_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(181, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(184, 22);
            cutToolStripMenuItem.Text = "&Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(184, 22);
            copyToolStripMenuItem.Text = "Cop&y";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(184, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Image = (Image)resources.GetObject("selectAllToolStripMenuItem.Image");
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(184, 22);
            selectAllToolStripMenuItem.Text = "Se&lect All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(181, 6);
            // 
            // dateTimeToolStripMenuItem1
            // 
            dateTimeToolStripMenuItem1.Image = (Image)resources.GetObject("dateTimeToolStripMenuItem1.Image");
            dateTimeToolStripMenuItem1.Name = "dateTimeToolStripMenuItem1";
            dateTimeToolStripMenuItem1.ShortcutKeys = Keys.F12;
            dateTimeToolStripMenuItem1.Size = new Size(184, 22);
            dateTimeToolStripMenuItem1.Text = "&Date/Time";
            dateTimeToolStripMenuItem1.Click += dateTimeToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(181, 6);
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(184, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Image = (Image)resources.GetObject("openToolStripMenuItem1.Image");
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem1.Size = new Size(184, 22);
            openToolStripMenuItem1.Text = "&Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(181, 6);
            // 
            // saveToolStripMenuItem2
            // 
            saveToolStripMenuItem2.Image = (Image)resources.GetObject("saveToolStripMenuItem2.Image");
            saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            saveToolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem2.Size = new Size(184, 22);
            saveToolStripMenuItem2.Text = "&Save";
            saveToolStripMenuItem2.Click += saveToolStripMenuItem2_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = (Image)resources.GetObject("saveAsToolStripMenuItem.Image");
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(184, 22);
            saveAsToolStripMenuItem.Text = "S&ave as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(181, 6);
            // 
            // normalToolStripMenuItem1
            // 
            normalToolStripMenuItem1.Image = (Image)resources.GetObject("normalToolStripMenuItem1.Image");
            normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            normalToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.T;
            normalToolStripMenuItem1.Size = new Size(184, 22);
            normalToolStripMenuItem1.Text = "&Normal";
            normalToolStripMenuItem1.Click += normalToolStripMenuItem1_Click;
            // 
            // boldToolStripMenuItem1
            // 
            boldToolStripMenuItem1.Image = (Image)resources.GetObject("boldToolStripMenuItem1.Image");
            boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            boldToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem1.Size = new Size(184, 22);
            boldToolStripMenuItem1.Text = "Bold";
            boldToolStripMenuItem1.TextAlign = ContentAlignment.MiddleRight;
            boldToolStripMenuItem1.Click += boldToolStripMenuItem1_Click;
            // 
            // italicToolStripMenuItem1
            // 
            italicToolStripMenuItem1.Image = (Image)resources.GetObject("italicToolStripMenuItem1.Image");
            italicToolStripMenuItem1.Name = "italicToolStripMenuItem1";
            italicToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem1.Size = new Size(184, 22);
            italicToolStripMenuItem1.Text = "&Italic";
            italicToolStripMenuItem1.Click += italicToolStripMenuItem1_Click;
            // 
            // underlineToolStripMenuItem1
            // 
            underlineToolStripMenuItem1.Image = (Image)resources.GetObject("underlineToolStripMenuItem1.Image");
            underlineToolStripMenuItem1.Name = "underlineToolStripMenuItem1";
            underlineToolStripMenuItem1.Size = new Size(184, 22);
            underlineToolStripMenuItem1.Text = "Und&erline";
            underlineToolStripMenuItem1.Click += underlineToolStripMenuItem1_Click;
            // 
            // DesktopNotes
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1262, 645);
            Controls.Add(MainRichTextBox);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DesktopNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desktop Notes";
            Load += DesktopNotes_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem sellectAllToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem desktopNotesToolStripMenuItem;
        private RichTextBox MainRichTextBox;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem formateToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikthroToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem undoToolStripMenuItem1;
        private ToolStripMenuItem redoToolStripMenuItem1;
        private ToolStripMenuItem normalToolStripMenuItem1;
        private ToolStripMenuItem boldToolStripMenuItem1;
        private ToolStripMenuItem italicToolStripMenuItem1;
        private ToolStripMenuItem underlineToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem saveToolStripMenuItem2;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem findNoteToolStripMenuItem;
        private ToolStripMenuItem addNoteToolStripMenuItem;
        private ToolStripMenuItem updateNoteToolStripMenuItem;
        private ToolStripMenuItem deleteNoteToolStripMenuItem;
    }
}
