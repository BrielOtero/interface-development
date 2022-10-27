namespace _07_exercise
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordwrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeSelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperCaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerCaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topBar = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllButton = new System.Windows.Forms.ToolStripButton();
            this.selectionBar = new System.Windows.Forms.ToolStrip();
            this.selectionSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selection = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countSentences = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.countWords = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.countCharacters = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.topBar.SuspendLayout();
            this.selectionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.toolStripSeparator,
            this.saveMenuItem1,
            this.toolStripSeparator1,
            this.recentFilesMenuItem,
            this.toolStripSeparator7,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newMenuItem
            // 
            this.newMenuItem.Image = global::_07_exercise.Properties.Resources._new;
            this.newMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newMenuItem.Text = "&New";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openMenuItem.Image")));
            this.openMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openMenuItem.Text = "&Open";
            this.openMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // saveMenuItem1
            // 
            this.saveMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuItem1.Image")));
            this.saveMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMenuItem1.Name = "saveMenuItem1";
            this.saveMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.saveMenuItem1.Text = "&Save As";
            this.saveMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // recentFilesMenuItem
            // 
            this.recentFilesMenuItem.Name = "recentFilesMenuItem";
            this.recentFilesMenuItem.Size = new System.Drawing.Size(154, 22);
            this.recentFilesMenuItem.Text = "&Recent Files";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(151, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.toolStripSeparator3,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.toolStripSeparator4,
            this.selectAllMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Image = global::_07_exercise.Properties.Resources.undo;
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoMenuItem.Text = "&Undo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Image = global::_07_exercise.Properties.Resources.cut;
            this.cutMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutMenuItem.Text = "Cu&t";
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Image = global::_07_exercise.Properties.Resources.copy;
            this.copyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyMenuItem.Text = "&Copy";
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Image = global::_07_exercise.Properties.Resources.paste;
            this.pasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Image = global::_07_exercise.Properties.Resources.selectAll;
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordwrapMenuItem,
            this.writeSelectionMenuItem,
            this.colorsMenuItem,
            this.fontToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // wordwrapMenuItem
            // 
            this.wordwrapMenuItem.Name = "wordwrapMenuItem";
            this.wordwrapMenuItem.Size = new System.Drawing.Size(153, 22);
            this.wordwrapMenuItem.Text = "&Word Wrap";
            this.wordwrapMenuItem.Click += new System.EventHandler(this.wordwrapToolStripMenuItem_Click);
            // 
            // writeSelectionMenuItem
            // 
            this.writeSelectionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultMenuItem,
            this.upperCaseMenuItem,
            this.lowerCaseMenuItem});
            this.writeSelectionMenuItem.Name = "writeSelectionMenuItem";
            this.writeSelectionMenuItem.Size = new System.Drawing.Size(153, 22);
            this.writeSelectionMenuItem.Text = "Write &Selection";
            // 
            // defaultMenuItem
            // 
            this.defaultMenuItem.Name = "defaultMenuItem";
            this.defaultMenuItem.Size = new System.Drawing.Size(134, 22);
            this.defaultMenuItem.Text = "Default";
            this.defaultMenuItem.CheckStateChanged += new System.EventHandler(this.writeSelection_CheckStateChanged);
            this.defaultMenuItem.Click += new System.EventHandler(this.writeSelection_Click);
            // 
            // upperCaseMenuItem
            // 
            this.upperCaseMenuItem.Name = "upperCaseMenuItem";
            this.upperCaseMenuItem.Size = new System.Drawing.Size(134, 22);
            this.upperCaseMenuItem.Text = "Upper Case";
            this.upperCaseMenuItem.CheckStateChanged += new System.EventHandler(this.writeSelection_CheckStateChanged);
            this.upperCaseMenuItem.Click += new System.EventHandler(this.writeSelection_Click);
            // 
            // lowerCaseMenuItem
            // 
            this.lowerCaseMenuItem.Name = "lowerCaseMenuItem";
            this.lowerCaseMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lowerCaseMenuItem.Text = "Lower Case";
            this.lowerCaseMenuItem.CheckStateChanged += new System.EventHandler(this.writeSelection_CheckStateChanged);
            this.lowerCaseMenuItem.Click += new System.EventHandler(this.writeSelection_Click);
            // 
            // colorsMenuItem
            // 
            this.colorsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorMenuItem,
            this.backgroundColorMenuItem});
            this.colorsMenuItem.Name = "colorsMenuItem";
            this.colorsMenuItem.Size = new System.Drawing.Size(153, 22);
            this.colorsMenuItem.Text = "&Color";
            // 
            // fontColorMenuItem
            // 
            this.fontColorMenuItem.Name = "fontColorMenuItem";
            this.fontColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontColorMenuItem.Text = "Font Color";
            this.fontColorMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // backgroundColorMenuItem
            // 
            this.backgroundColorMenuItem.Name = "backgroundColorMenuItem";
            this.backgroundColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorMenuItem.Text = "Background Color";
            this.backgroundColorMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetSettingsMenuItem,
            this.aboutMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // resetSettingsMenuItem
            // 
            this.resetSettingsMenuItem.Name = "resetSettingsMenuItem";
            this.resetSettingsMenuItem.Size = new System.Drawing.Size(147, 22);
            this.resetSettingsMenuItem.Text = "&Reset Settings";
            this.resetSettingsMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutMenuItem.Text = "&About";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 370);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.SystemColors.Window;
            this.topBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.toolStripSeparator9,
            this.undoButton,
            this.toolStripSeparator10,
            this.cutButton,
            this.toolStripSeparator11,
            this.copyButton,
            this.toolStripSeparator12,
            this.pasteButton,
            this.toolStripSeparator13,
            this.selectAllButton});
            this.topBar.Location = new System.Drawing.Point(0, 24);
            this.topBar.Name = "topBar";
            this.topBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.topBar.Size = new System.Drawing.Size(800, 25);
            this.topBar.TabIndex = 2;
            this.topBar.Text = "toolStrip1";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = global::_07_exercise.Properties.Resources._new;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(23, 22);
            this.newButton.Text = "toolStripButton1";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = global::_07_exercise.Properties.Resources.undo;
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(23, 22);
            this.undoButton.Text = "toolStripButton2";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = global::_07_exercise.Properties.Resources.cut;
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(23, 22);
            this.cutButton.Text = "toolStripButton3";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = global::_07_exercise.Properties.Resources.copy;
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(23, 22);
            this.copyButton.Text = "toolStripButton4";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = global::_07_exercise.Properties.Resources.paste;
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(23, 22);
            this.pasteButton.Text = "toolStripButton5";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // selectAllButton
            // 
            this.selectAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllButton.Image = global::_07_exercise.Properties.Resources.selectAll;
            this.selectAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(23, 22);
            this.selectAllButton.Text = "toolStripButton6";
            // 
            // selectionBar
            // 
            this.selectionBar.BackColor = System.Drawing.SystemColors.Window;
            this.selectionBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectionBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.selectionBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionSize,
            this.toolStripSeparator6,
            this.selection,
            this.toolStripSeparator2,
            this.countSentences,
            this.toolStripSeparator5,
            this.countWords,
            this.toolStripSeparator8,
            this.countCharacters,
            this.toolStripSeparator14});
            this.selectionBar.Location = new System.Drawing.Point(0, 425);
            this.selectionBar.Name = "selectionBar";
            this.selectionBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.selectionBar.Size = new System.Drawing.Size(800, 25);
            this.selectionBar.TabIndex = 3;
            this.selectionBar.Text = "toolStrip2";
            // 
            // selectionSize
            // 
            this.selectionSize.Name = "selectionSize";
            this.selectionSize.Size = new System.Drawing.Size(89, 22);
            this.selectionSize.Text = "Selection size: 0";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // selection
            // 
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(121, 22);
            this.selection.Text = "Selection: From 0 to 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // countSentences
            // 
            this.countSentences.Name = "countSentences";
            this.countSentences.Size = new System.Drawing.Size(72, 22);
            this.countSentences.Text = "Sentences: 0";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // countWords
            // 
            this.countWords.Name = "countWords";
            this.countWords.Size = new System.Drawing.Size(53, 22);
            this.countWords.Text = "Words: 0";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // countCharacters
            // 
            this.countCharacters.Name = "countCharacters";
            this.countCharacters.Size = new System.Drawing.Size(75, 22);
            this.countCharacters.Text = "Characters: 0";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectionBar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.selectionBar.ResumeLayout(false);
            this.selectionBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private TextBox textBox1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem undoMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutMenuItem;
        private ToolStripMenuItem copyMenuItem;
        private ToolStripMenuItem pasteMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem1;
        private ToolStripMenuItem writeSelectionMenuItem;
        private ToolStripMenuItem colorsMenuItem;
        private ToolStripMenuItem wordwrapMenuItem;
        private ToolStripMenuItem recentFilesMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem holaToolStripMenuItem;
        private ToolStripMenuItem fontColorMenuItem;
        private ToolStripMenuItem backgroundColorMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem moreToolStripMenuItem;
        private ToolStripMenuItem resetSettingsMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private ToolStripMenuItem defaultMenuItem;
        private ToolStripMenuItem upperCaseMenuItem;
        private ToolStripMenuItem lowerCaseMenuItem;
        private ToolStrip topBar;
        private ToolStrip selectionBar;
        private ToolStripLabel selection;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton newButton;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton undoButton;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton cutButton;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton copyButton;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton pasteButton;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton selectAllButton;
        private ToolStripLabel countWords;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripLabel countCharacters;
        private ToolStripLabel countSentences;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripLabel selectionSize;
    }
}