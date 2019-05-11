namespace DataDrop2
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
            this.components = new System.ComponentModel.Container();
            this.SourceDataComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationDataComboBox = new System.Windows.Forms.ComboBox();
            this.sourceFile = new System.Windows.Forms.OpenFileDialog();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.ApiTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openSource = new System.Windows.Forms.Button();
            this.showAttributes = new System.Windows.Forms.Button();
            this.availableListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destinationAttributes = new System.Windows.Forms.ListBox();
            this.Keep = new System.Windows.Forms.Button();
            this.Discard = new System.Windows.Forms.Button();
            this.generateFile = new System.Windows.Forms.Button();
            this.DestinationFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileExtensionLabel = new System.Windows.Forms.Label();
            this.DbConnectSection = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DbPasswordText = new System.Windows.Forms.TextBox();
            this.DbUserNameText = new System.Windows.Forms.TextBox();
            this.DbDatabaseText = new System.Windows.Forms.TextBox();
            this.DbSourceText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.DbConnectSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceDataComboBox
            // 
            this.SourceDataComboBox.FormattingEnabled = true;
            this.SourceDataComboBox.Location = new System.Drawing.Point(24, 60);
            this.SourceDataComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.SourceDataComboBox.Name = "SourceDataComboBox";
            this.SourceDataComboBox.Size = new System.Drawing.Size(238, 33);
            this.SourceDataComboBox.TabIndex = 0;
            this.SourceDataComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceDataComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Data Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1186, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Data Type";
            // 
            // DestinationDataComboBox
            // 
            this.DestinationDataComboBox.FormattingEnabled = true;
            this.DestinationDataComboBox.Location = new System.Drawing.Point(1192, 60);
            this.DestinationDataComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.DestinationDataComboBox.Name = "DestinationDataComboBox";
            this.DestinationDataComboBox.Size = new System.Drawing.Size(238, 33);
            this.DestinationDataComboBox.TabIndex = 3;
            this.DestinationDataComboBox.SelectedIndexChanged += new System.EventHandler(this.DestinationDataComboBox_SelectedIndexChanged);
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Enabled = false;
            this.sourceFileTextBox.Location = new System.Drawing.Point(12, 67);
            this.sourceFileTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.Size = new System.Drawing.Size(456, 31);
            this.sourceFileTextBox.TabIndex = 6;
            // 
            // ApiTextBox
            // 
            this.ApiTextBox.Enabled = false;
            this.ApiTextBox.Location = new System.Drawing.Point(12, 275);
            this.ApiTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ApiTextBox.Name = "ApiTextBox";
            this.ApiTextBox.Size = new System.Drawing.Size(456, 31);
            this.ApiTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "URL";
            // 
            // openSource
            // 
            this.openSource.Location = new System.Drawing.Point(12, 117);
            this.openSource.Margin = new System.Windows.Forms.Padding(6);
            this.openSource.Name = "openSource";
            this.openSource.Size = new System.Drawing.Size(150, 44);
            this.openSource.TabIndex = 10;
            this.openSource.Text = "Browse";
            this.openSource.UseVisualStyleBackColor = true;
            this.openSource.Click += new System.EventHandler(this.openSource_Click);
            // 
            // showAttributes
            // 
            this.showAttributes.Location = new System.Drawing.Point(24, 454);
            this.showAttributes.Margin = new System.Windows.Forms.Padding(6);
            this.showAttributes.Name = "showAttributes";
            this.showAttributes.Size = new System.Drawing.Size(506, 44);
            this.showAttributes.TabIndex = 11;
            this.showAttributes.Text = "Show Available Attributes";
            this.showAttributes.UseVisualStyleBackColor = true;
            this.showAttributes.Click += new System.EventHandler(this.showAttributes_Click);
            // 
            // availableListBox
            // 
            this.availableListBox.FormattingEnabled = true;
            this.availableListBox.ItemHeight = 25;
            this.availableListBox.Location = new System.Drawing.Point(24, 531);
            this.availableListBox.Margin = new System.Windows.Forms.Padding(6);
            this.availableListBox.Name = "availableListBox";
            this.availableListBox.Size = new System.Drawing.Size(502, 229);
            this.availableListBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "-or-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sourceFileTextBox);
            this.groupBox1.Controls.Add(this.ApiTextBox);
            this.groupBox1.Controls.Add(this.openSource);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(24, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(506, 329);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // destinationAttributes
            // 
            this.destinationAttributes.FormattingEnabled = true;
            this.destinationAttributes.ItemHeight = 25;
            this.destinationAttributes.Location = new System.Drawing.Point(758, 131);
            this.destinationAttributes.Margin = new System.Windows.Forms.Padding(6);
            this.destinationAttributes.Name = "destinationAttributes";
            this.destinationAttributes.Size = new System.Drawing.Size(338, 629);
            this.destinationAttributes.TabIndex = 15;
            // 
            // Keep
            // 
            this.Keep.Location = new System.Drawing.Point(602, 531);
            this.Keep.Margin = new System.Windows.Forms.Padding(6);
            this.Keep.Name = "Keep";
            this.Keep.Size = new System.Drawing.Size(90, 69);
            this.Keep.TabIndex = 16;
            this.Keep.Text = ">>";
            this.Keep.UseVisualStyleBackColor = true;
            this.Keep.Click += new System.EventHandler(this.Keep_Click);
            // 
            // Discard
            // 
            this.Discard.Location = new System.Drawing.Point(602, 621);
            this.Discard.Margin = new System.Windows.Forms.Padding(6);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(90, 69);
            this.Discard.TabIndex = 17;
            this.Discard.Text = "<<";
            this.Discard.UseVisualStyleBackColor = true;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // generateFile
            // 
            this.generateFile.Location = new System.Drawing.Point(1192, 212);
            this.generateFile.Margin = new System.Windows.Forms.Padding(6);
            this.generateFile.Name = "generateFile";
            this.generateFile.Size = new System.Drawing.Size(242, 44);
            this.generateFile.TabIndex = 18;
            this.generateFile.Text = "Generate File";
            this.generateFile.UseVisualStyleBackColor = true;
            this.generateFile.Click += new System.EventHandler(this.generateFile_Click);
            // 
            // DestinationFileNameTextBox
            // 
            this.DestinationFileNameTextBox.Location = new System.Drawing.Point(1192, 162);
            this.DestinationFileNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.DestinationFileNameTextBox.Name = "DestinationFileNameTextBox";
            this.DestinationFileNameTextBox.Size = new System.Drawing.Size(238, 31);
            this.DestinationFileNameTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1192, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Destination File Name";
            // 
            // FileExtensionLabel
            // 
            this.FileExtensionLabel.AutoSize = true;
            this.FileExtensionLabel.Location = new System.Drawing.Point(1446, 175);
            this.FileExtensionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FileExtensionLabel.Name = "FileExtensionLabel";
            this.FileExtensionLabel.Size = new System.Drawing.Size(0, 25);
            this.FileExtensionLabel.TabIndex = 21;
            // 
            // DbConnectSection
            // 
            this.DbConnectSection.Controls.Add(this.label10);
            this.DbConnectSection.Controls.Add(this.label9);
            this.DbConnectSection.Controls.Add(this.label8);
            this.DbConnectSection.Controls.Add(this.label4);
            this.DbConnectSection.Controls.Add(this.DbPasswordText);
            this.DbConnectSection.Controls.Add(this.DbUserNameText);
            this.DbConnectSection.Controls.Add(this.DbDatabaseText);
            this.DbConnectSection.Controls.Add(this.DbSourceText);
            this.DbConnectSection.Enabled = false;
            this.DbConnectSection.Location = new System.Drawing.Point(1590, 112);
            this.DbConnectSection.Margin = new System.Windows.Forms.Padding(6);
            this.DbConnectSection.Name = "DbConnectSection";
            this.DbConnectSection.Padding = new System.Windows.Forms.Padding(6);
            this.DbConnectSection.Size = new System.Drawing.Size(532, 652);
            this.DbConnectSection.TabIndex = 22;
            this.DbConnectSection.TabStop = false;
            this.DbConnectSection.Text = "Database Connect Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Source";
            // 
            // DbPasswordText
            // 
            this.DbPasswordText.Location = new System.Drawing.Point(12, 365);
            this.DbPasswordText.Margin = new System.Windows.Forms.Padding(6);
            this.DbPasswordText.Name = "DbPasswordText";
            this.DbPasswordText.PasswordChar = '*';
            this.DbPasswordText.Size = new System.Drawing.Size(354, 31);
            this.DbPasswordText.TabIndex = 24;
            // 
            // DbUserNameText
            // 
            this.DbUserNameText.Location = new System.Drawing.Point(12, 275);
            this.DbUserNameText.Margin = new System.Windows.Forms.Padding(6);
            this.DbUserNameText.Name = "DbUserNameText";
            this.DbUserNameText.Size = new System.Drawing.Size(354, 31);
            this.DbUserNameText.TabIndex = 2;
            // 
            // DbDatabaseText
            // 
            this.DbDatabaseText.Location = new System.Drawing.Point(12, 188);
            this.DbDatabaseText.Margin = new System.Windows.Forms.Padding(6);
            this.DbDatabaseText.Name = "DbDatabaseText";
            this.DbDatabaseText.Size = new System.Drawing.Size(354, 31);
            this.DbDatabaseText.TabIndex = 1;
            // 
            // DbSourceText
            // 
            this.DbSourceText.Location = new System.Drawing.Point(12, 100);
            this.DbSourceText.Margin = new System.Windows.Forms.Padding(6);
            this.DbSourceText.Name = "DbSourceText";
            this.DbSourceText.Size = new System.Drawing.Size(354, 31);
            this.DbSourceText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(1192, 313);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(91, 25);
            this.StatusLabel.TabIndex = 24;
            this.StatusLabel.Text = "Pending";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2180, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DbConnectSection);
            this.Controls.Add(this.FileExtensionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DestinationFileNameTextBox);
            this.Controls.Add(this.generateFile);
            this.Controls.Add(this.Discard);
            this.Controls.Add(this.Keep);
            this.Controls.Add(this.destinationAttributes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.availableListBox);
            this.Controls.Add(this.showAttributes);
            this.Controls.Add(this.DestinationDataComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceDataComboBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DbConnectSection.ResumeLayout(false);
            this.DbConnectSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SourceDataComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DestinationDataComboBox;
        private System.Windows.Forms.OpenFileDialog sourceFile;
        private System.Windows.Forms.TextBox sourceFileTextBox;
        private System.Windows.Forms.TextBox ApiTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openSource;
        private System.Windows.Forms.Button showAttributes;
        private System.Windows.Forms.ListBox availableListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox destinationAttributes;
        private System.Windows.Forms.Button Keep;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.Button generateFile;
        private System.Windows.Forms.TextBox DestinationFileNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FileExtensionLabel;
        private System.Windows.Forms.GroupBox DbConnectSection;
        private System.Windows.Forms.TextBox DbPasswordText;
        private System.Windows.Forms.TextBox DbUserNameText;
        private System.Windows.Forms.TextBox DbDatabaseText;
        private System.Windows.Forms.TextBox DbSourceText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}

