namespace ListReplacerX
{
    partial class X
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
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_Directory = new System.Windows.Forms.TextBox();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.checkBox_override = new System.Windows.Forms.CheckBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.checkBox_matchLog = new System.Windows.Forms.CheckBox();
            this.label_searchSection = new System.Windows.Forms.Label();
            this.label_modifySection = new System.Windows.Forms.Label();
            this.textBox_modifyCIndex = new System.Windows.Forms.TextBox();
            this.label_modifyPrefix = new System.Windows.Forms.Label();
            this.textBox_delim = new System.Windows.Forms.TextBox();
            this.label_delim = new System.Windows.Forms.Label();
            this.textBox_modifyReplace = new System.Windows.Forms.TextBox();
            this.label_modifyReplace = new System.Windows.Forms.Label();
            this.textBox_modifyFind = new System.Windows.Forms.TextBox();
            this.label_modifyFind = new System.Windows.Forms.Label();
            this.button_GO = new System.Windows.Forms.Button();
            this.textBox_modifyOverwrite = new System.Windows.Forms.TextBox();
            this.label_modifyOverwrite = new System.Windows.Forms.Label();
            this.gridViewSearch = new System.Windows.Forms.DataGridView();
            this.searchPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchContains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_modifyIfContains = new System.Windows.Forms.TextBox();
            this.label_modifyIfContains = new System.Windows.Forms.Label();
            this.label_modifyOverwrite2 = new System.Windows.Forms.Label();
            this.textBox_modifyOverwrite2 = new System.Windows.Forms.TextBox();
            this.checkBox_addLine = new System.Windows.Forms.CheckBox();
            this.label_format = new System.Windows.Forms.Label();
            this.comboBox_format = new System.Windows.Forms.ComboBox();
            this.button_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Location = new System.Drawing.Point(17, 16);
            this.btn_ChooseFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(164, 28);
            this.btn_ChooseFile.TabIndex = 0;
            this.btn_ChooseFile.Text = "Choose Text File...";
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.Btn_ChooseFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_Directory
            // 
            this.txt_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Directory.Location = new System.Drawing.Point(189, 18);
            this.txt_Directory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Directory.Name = "txt_Directory";
            this.txt_Directory.ReadOnly = true;
            this.txt_Directory.Size = new System.Drawing.Size(544, 22);
            this.txt_Directory.TabIndex = 1;
            this.txt_Directory.WordWrap = false;
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "Read",
            "Overwrite",
            "Overwrite-If",
            "Overwrite x2",
            "Replace"});
            this.comboBox_mode.Location = new System.Drawing.Point(117, 52);
            this.comboBox_mode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(221, 24);
            this.comboBox_mode.TabIndex = 2;
            this.comboBox_mode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_mode_SelectedIndexChanged);
            // 
            // checkBox_override
            // 
            this.checkBox_override.AutoSize = true;
            this.checkBox_override.Location = new System.Drawing.Point(407, 316);
            this.checkBox_override.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_override.Name = "checkBox_override";
            this.checkBox_override.Size = new System.Drawing.Size(154, 21);
            this.checkBox_override.TabIndex = 5;
            this.checkBox_override.Text = "override original file";
            this.checkBox_override.UseVisualStyleBackColor = true;
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Location = new System.Drawing.Point(16, 57);
            this.label_mode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(90, 17);
            this.label_mode.TabIndex = 6;
            this.label_mode.Text = "Select Mode:";
            // 
            // checkBox_matchLog
            // 
            this.checkBox_matchLog.AutoSize = true;
            this.checkBox_matchLog.Checked = true;
            this.checkBox_matchLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_matchLog.Location = new System.Drawing.Point(16, 287);
            this.checkBox_matchLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_matchLog.Name = "checkBox_matchLog";
            this.checkBox_matchLog.Size = new System.Drawing.Size(333, 21);
            this.checkBox_matchLog.TabIndex = 7;
            this.checkBox_matchLog.Text = "generate log containing copy of search matches";
            this.checkBox_matchLog.UseVisualStyleBackColor = true;
            // 
            // label_searchSection
            // 
            this.label_searchSection.AutoSize = true;
            this.label_searchSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchSection.Location = new System.Drawing.Point(7, 124);
            this.label_searchSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_searchSection.Name = "label_searchSection";
            this.label_searchSection.Size = new System.Drawing.Size(323, 25);
            this.label_searchSection.TabIndex = 8;
            this.label_searchSection.Text = "                 Search for items                 ";
            // 
            // label_modifySection
            // 
            this.label_modifySection.AutoSize = true;
            this.label_modifySection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modifySection.Location = new System.Drawing.Point(395, 124);
            this.label_modifySection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifySection.Name = "label_modifySection";
            this.label_modifySection.Size = new System.Drawing.Size(325, 25);
            this.label_modifySection.TabIndex = 9;
            this.label_modifySection.Text = "               Modify found items               ";
            // 
            // textBox_modifyCIndex
            // 
            this.textBox_modifyCIndex.Location = new System.Drawing.Point(457, 158);
            this.textBox_modifyCIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyCIndex.Name = "textBox_modifyCIndex";
            this.textBox_modifyCIndex.Size = new System.Drawing.Size(281, 22);
            this.textBox_modifyCIndex.TabIndex = 13;
            this.textBox_modifyCIndex.Text = "C01";
            // 
            // label_modifyPrefix
            // 
            this.label_modifyPrefix.AutoSize = true;
            this.label_modifyPrefix.Location = new System.Drawing.Point(403, 161);
            this.label_modifyPrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifyPrefix.Name = "label_modifyPrefix";
            this.label_modifyPrefix.Size = new System.Drawing.Size(46, 17);
            this.label_modifyPrefix.TabIndex = 12;
            this.label_modifyPrefix.Text = "prefix:";
            // 
            // textBox_delim
            // 
            this.textBox_delim.Location = new System.Drawing.Point(648, 50);
            this.textBox_delim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_delim.Name = "textBox_delim";
            this.textBox_delim.Size = new System.Drawing.Size(91, 22);
            this.textBox_delim.TabIndex = 17;
            this.textBox_delim.Text = "#";
            // 
            // label_delim
            // 
            this.label_delim.AutoSize = true;
            this.label_delim.Location = new System.Drawing.Point(560, 54);
            this.label_delim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_delim.Name = "label_delim";
            this.label_delim.Size = new System.Drawing.Size(81, 17);
            this.label_delim.TabIndex = 16;
            this.label_delim.Text = "deliminator:";
            // 
            // textBox_modifyReplace
            // 
            this.textBox_modifyReplace.Location = new System.Drawing.Point(500, 255);
            this.textBox_modifyReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyReplace.Name = "textBox_modifyReplace";
            this.textBox_modifyReplace.Size = new System.Drawing.Size(239, 22);
            this.textBox_modifyReplace.TabIndex = 19;
            // 
            // label_modifyReplace
            // 
            this.label_modifyReplace.AutoSize = true;
            this.label_modifyReplace.Location = new System.Drawing.Point(403, 258);
            this.label_modifyReplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifyReplace.Name = "label_modifyReplace";
            this.label_modifyReplace.Size = new System.Drawing.Size(87, 17);
            this.label_modifyReplace.TabIndex = 18;
            this.label_modifyReplace.Text = "replace with:";
            // 
            // textBox_modifyFind
            // 
            this.textBox_modifyFind.Location = new System.Drawing.Point(447, 223);
            this.textBox_modifyFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyFind.Name = "textBox_modifyFind";
            this.textBox_modifyFind.Size = new System.Drawing.Size(292, 22);
            this.textBox_modifyFind.TabIndex = 21;
            // 
            // label_modifyFind
            // 
            this.label_modifyFind.AutoSize = true;
            this.label_modifyFind.Location = new System.Drawing.Point(403, 226);
            this.label_modifyFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifyFind.Name = "label_modifyFind";
            this.label_modifyFind.Size = new System.Drawing.Size(35, 17);
            this.label_modifyFind.TabIndex = 20;
            this.label_modifyFind.Text = "find:";
            // 
            // button_GO
            // 
            this.button_GO.Location = new System.Drawing.Point(325, 345);
            this.button_GO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_GO.Name = "button_GO";
            this.button_GO.Size = new System.Drawing.Size(100, 28);
            this.button_GO.TabIndex = 24;
            this.button_GO.Text = "GO!";
            this.button_GO.UseVisualStyleBackColor = true;
            this.button_GO.Click += new System.EventHandler(this.Button_GO_Click);
            // 
            // textBox_modifyOverwrite
            // 
            this.textBox_modifyOverwrite.Location = new System.Drawing.Point(511, 190);
            this.textBox_modifyOverwrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyOverwrite.Name = "textBox_modifyOverwrite";
            this.textBox_modifyOverwrite.Size = new System.Drawing.Size(228, 22);
            this.textBox_modifyOverwrite.TabIndex = 26;
            // 
            // label_modifyOverwrite
            // 
            this.label_modifyOverwrite.AutoSize = true;
            this.label_modifyOverwrite.Location = new System.Drawing.Point(403, 193);
            this.label_modifyOverwrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifyOverwrite.Name = "label_modifyOverwrite";
            this.label_modifyOverwrite.Size = new System.Drawing.Size(97, 17);
            this.label_modifyOverwrite.TabIndex = 25;
            this.label_modifyOverwrite.Text = "overwrite with:";
            // 
            // gridViewSearch
            // 
            this.gridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchPrefix,
            this.searchContains});
            this.gridViewSearch.Location = new System.Drawing.Point(11, 153);
            this.gridViewSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridViewSearch.Name = "gridViewSearch";
            this.gridViewSearch.Size = new System.Drawing.Size(341, 128);
            this.gridViewSearch.TabIndex = 27;
            // 
            // searchPrefix
            // 
            this.searchPrefix.FillWeight = 50F;
            this.searchPrefix.HeaderText = "prefix";
            this.searchPrefix.Name = "searchPrefix";
            // 
            // searchContains
            // 
            this.searchContains.HeaderText = "contains";
            this.searchContains.Name = "searchContains";
            // 
            // textBox_modifyIfContains
            // 
            this.textBox_modifyIfContains.Location = new System.Drawing.Point(488, 223);
            this.textBox_modifyIfContains.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyIfContains.Name = "textBox_modifyIfContains";
            this.textBox_modifyIfContains.Size = new System.Drawing.Size(251, 22);
            this.textBox_modifyIfContains.TabIndex = 29;
            // 
            // label_modifyIfContains
            // 
            this.label_modifyIfContains.AutoSize = true;
            this.label_modifyIfContains.Location = new System.Drawing.Point(403, 226);
            this.label_modifyIfContains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifyIfContains.Name = "label_modifyIfContains";
            this.label_modifyIfContains.Size = new System.Drawing.Size(76, 17);
            this.label_modifyIfContains.TabIndex = 28;
            this.label_modifyIfContains.Text = "if contains:";
            // 
            // label_modifyOverwrite2
            // 
            this.label_modifyOverwrite2.AutoSize = true;
            this.label_modifyOverwrite2.Location = new System.Drawing.Point(403, 226);
            this.label_modifyOverwrite2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modifyOverwrite2.Name = "label_modifyOverwrite2";
            this.label_modifyOverwrite2.Size = new System.Drawing.Size(97, 17);
            this.label_modifyOverwrite2.TabIndex = 32;
            this.label_modifyOverwrite2.Text = "overwrite with:";
            // 
            // textBox_modifyOverwrite2
            // 
            this.textBox_modifyOverwrite2.Location = new System.Drawing.Point(511, 223);
            this.textBox_modifyOverwrite2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyOverwrite2.Name = "textBox_modifyOverwrite2";
            this.textBox_modifyOverwrite2.Size = new System.Drawing.Size(228, 22);
            this.textBox_modifyOverwrite2.TabIndex = 33;
            // 
            // checkBox_addLine
            // 
            this.checkBox_addLine.AutoSize = true;
            this.checkBox_addLine.Checked = true;
            this.checkBox_addLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_addLine.Location = new System.Drawing.Point(407, 287);
            this.checkBox_addLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_addLine.Name = "checkBox_addLine";
            this.checkBox_addLine.Size = new System.Drawing.Size(130, 21);
            this.checkBox_addLine.TabIndex = 34;
            this.checkBox_addLine.Text = "add second line";
            this.checkBox_addLine.UseVisualStyleBackColor = true;
            // 
            // label_format
            // 
            this.label_format.AutoSize = true;
            this.label_format.Location = new System.Drawing.Point(16, 90);
            this.label_format.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_format.Name = "label_format";
            this.label_format.Size = new System.Drawing.Size(99, 17);
            this.label_format.TabIndex = 36;
            this.label_format.Text = "Select Format:";
            // 
            // comboBox_format
            // 
            this.comboBox_format.FormattingEnabled = true;
            this.comboBox_format.Items.AddRange(new object[] {
            "Unspecified",
            "Component",
            "Package"});
            this.comboBox_format.Location = new System.Drawing.Point(124, 85);
            this.comboBox_format.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_format.Name = "comboBox_format";
            this.comboBox_format.Size = new System.Drawing.Size(215, 24);
            this.comboBox_format.TabIndex = 35;
            this.comboBox_format.SelectedIndexChanged += new System.EventHandler(this.comboBox_format_SelectedIndexChanged);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(548, 75);
            this.button_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(185, 28);
            this.button_test.TabIndex = 37;
            this.button_test.Text = "dev Button (do not look at!)";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Visible = false;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 380);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.label_format);
            this.Controls.Add(this.comboBox_format);
            this.Controls.Add(this.checkBox_addLine);
            this.Controls.Add(this.textBox_modifyOverwrite2);
            this.Controls.Add(this.label_modifyOverwrite2);
            this.Controls.Add(this.textBox_modifyIfContains);
            this.Controls.Add(this.label_modifyIfContains);
            this.Controls.Add(this.gridViewSearch);
            this.Controls.Add(this.textBox_modifyOverwrite);
            this.Controls.Add(this.label_modifyOverwrite);
            this.Controls.Add(this.button_GO);
            this.Controls.Add(this.textBox_modifyFind);
            this.Controls.Add(this.label_modifyFind);
            this.Controls.Add(this.textBox_modifyReplace);
            this.Controls.Add(this.label_modifyReplace);
            this.Controls.Add(this.textBox_delim);
            this.Controls.Add(this.label_delim);
            this.Controls.Add(this.textBox_modifyCIndex);
            this.Controls.Add(this.label_modifyPrefix);
            this.Controls.Add(this.label_modifySection);
            this.Controls.Add(this.label_searchSection);
            this.Controls.Add(this.checkBox_matchLog);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.checkBox_override);
            this.Controls.Add(this.comboBox_mode);
            this.Controls.Add(this.txt_Directory);
            this.Controls.Add(this.btn_ChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "X";
            this.Text = "List Replacer X";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_Directory;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.CheckBox checkBox_override;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.CheckBox checkBox_matchLog;
        private System.Windows.Forms.Label label_searchSection;
        private System.Windows.Forms.Label label_modifySection;
        private System.Windows.Forms.TextBox textBox_modifyCIndex;
        private System.Windows.Forms.Label label_modifyPrefix;
        private System.Windows.Forms.TextBox textBox_delim;
        private System.Windows.Forms.Label label_delim;
        private System.Windows.Forms.TextBox textBox_modifyReplace;
        private System.Windows.Forms.Label label_modifyReplace;
        private System.Windows.Forms.TextBox textBox_modifyFind;
        private System.Windows.Forms.Label label_modifyFind;
        private System.Windows.Forms.Button button_GO;
        private System.Windows.Forms.TextBox textBox_modifyOverwrite;
        private System.Windows.Forms.Label label_modifyOverwrite;
        private System.Windows.Forms.DataGridView gridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchPrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchContains;
        private System.Windows.Forms.TextBox textBox_modifyIfContains;
        private System.Windows.Forms.Label label_modifyIfContains;
        private System.Windows.Forms.Label label_modifyOverwrite2;
        private System.Windows.Forms.TextBox textBox_modifyOverwrite2;
        private System.Windows.Forms.CheckBox checkBox_addLine;
        private System.Windows.Forms.Label label_format;
        private System.Windows.Forms.ComboBox comboBox_format;
        private System.Windows.Forms.Button button_test;
    }
}

