namespace Programming_Assignment_2
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
            this.militaryBranchListBox = new System.Windows.Forms.ListBox();
            this.militaryStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.retiredRadioButton = new System.Windows.Forms.RadioButton();
            this.veteranRadioButton = new System.Windows.Forms.RadioButton();
            this.reservistRadioButton = new System.Windows.Forms.RadioButton();
            this.activeDutyRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enteredServiceLabel = new System.Windows.Forms.Label();
            this.leftServiceLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enteredTextBox = new System.Windows.Forms.TextBox();
            this.leftTextBox = new System.Windows.Forms.TextBox();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayMilitaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.displayMilitaryDatesLabel = new System.Windows.Forms.Label();
            this.displayRankLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.ouputBranchLabel = new System.Windows.Forms.Label();
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.yearsServedCheckBox = new System.Windows.Forms.CheckBox();
            this.rankCheckBox = new System.Windows.Forms.CheckBox();
            this.militaryStatusLabel = new System.Windows.Forms.Label();
            this.branchPictureBox = new System.Windows.Forms.PictureBox();
            this.militaryStatusGroupBox.SuspendLayout();
            this.informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryBranchListBox
            // 
            this.militaryBranchListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.militaryBranchListBox.FormattingEnabled = true;
            this.militaryBranchListBox.Items.AddRange(new object[] {
            "Army",
            "Navy",
            "Air Force",
            "Marines",
            "Coast Guard"});
            this.militaryBranchListBox.Location = new System.Drawing.Point(12, 28);
            this.militaryBranchListBox.Name = "militaryBranchListBox";
            this.militaryBranchListBox.Size = new System.Drawing.Size(120, 69);
            this.militaryBranchListBox.TabIndex = 0;
            // 
            // militaryStatusGroupBox
            // 
            this.militaryStatusGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.militaryStatusGroupBox.Controls.Add(this.retiredRadioButton);
            this.militaryStatusGroupBox.Controls.Add(this.veteranRadioButton);
            this.militaryStatusGroupBox.Controls.Add(this.reservistRadioButton);
            this.militaryStatusGroupBox.Controls.Add(this.activeDutyRadioButton);
            this.militaryStatusGroupBox.Location = new System.Drawing.Point(12, 103);
            this.militaryStatusGroupBox.Name = "militaryStatusGroupBox";
            this.militaryStatusGroupBox.Size = new System.Drawing.Size(120, 109);
            this.militaryStatusGroupBox.TabIndex = 1;
            this.militaryStatusGroupBox.TabStop = false;
            this.militaryStatusGroupBox.Text = "Military Status:";
            // 
            // retiredRadioButton
            // 
            this.retiredRadioButton.AutoSize = true;
            this.retiredRadioButton.Location = new System.Drawing.Point(6, 86);
            this.retiredRadioButton.Name = "retiredRadioButton";
            this.retiredRadioButton.Size = new System.Drawing.Size(59, 17);
            this.retiredRadioButton.TabIndex = 3;
            this.retiredRadioButton.TabStop = true;
            this.retiredRadioButton.Text = "Retired";
            this.retiredRadioButton.UseVisualStyleBackColor = true;
            // 
            // veteranRadioButton
            // 
            this.veteranRadioButton.AutoSize = true;
            this.veteranRadioButton.Location = new System.Drawing.Point(6, 65);
            this.veteranRadioButton.Name = "veteranRadioButton";
            this.veteranRadioButton.Size = new System.Drawing.Size(62, 17);
            this.veteranRadioButton.TabIndex = 2;
            this.veteranRadioButton.TabStop = true;
            this.veteranRadioButton.Text = "Veteran";
            this.veteranRadioButton.UseVisualStyleBackColor = true;
            // 
            // reservistRadioButton
            // 
            this.reservistRadioButton.AutoSize = true;
            this.reservistRadioButton.Location = new System.Drawing.Point(6, 42);
            this.reservistRadioButton.Name = "reservistRadioButton";
            this.reservistRadioButton.Size = new System.Drawing.Size(70, 17);
            this.reservistRadioButton.TabIndex = 1;
            this.reservistRadioButton.TabStop = true;
            this.reservistRadioButton.Text = "Reserves";
            this.reservistRadioButton.UseVisualStyleBackColor = true;
            // 
            // activeDutyRadioButton
            // 
            this.activeDutyRadioButton.AutoSize = true;
            this.activeDutyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.activeDutyRadioButton.Name = "activeDutyRadioButton";
            this.activeDutyRadioButton.Size = new System.Drawing.Size(80, 17);
            this.activeDutyRadioButton.TabIndex = 0;
            this.activeDutyRadioButton.TabStop = true;
            this.activeDutyRadioButton.Text = "Active Duty";
            this.activeDutyRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 320);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Enter Name";
            // 
            // enteredServiceLabel
            // 
            this.enteredServiceLabel.AutoSize = true;
            this.enteredServiceLabel.Location = new System.Drawing.Point(12, 364);
            this.enteredServiceLabel.Name = "enteredServiceLabel";
            this.enteredServiceLabel.Size = new System.Drawing.Size(109, 13);
            this.enteredServiceLabel.TabIndex = 4;
            this.enteredServiceLabel.Text = "Date Entered Service";
            // 
            // leftServiceLabel
            // 
            this.leftServiceLabel.AutoSize = true;
            this.leftServiceLabel.Location = new System.Drawing.Point(12, 401);
            this.leftServiceLabel.Name = "leftServiceLabel";
            this.leftServiceLabel.Size = new System.Drawing.Size(90, 13);
            this.leftServiceLabel.TabIndex = 5;
            this.leftServiceLabel.Text = "Date Left Service";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(15, 440);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(67, 13);
            this.rankLabel.TabIndex = 6;
            this.rankLabel.Text = "Rank / Rate";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 336);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // enteredTextBox
            // 
            this.enteredTextBox.Location = new System.Drawing.Point(12, 378);
            this.enteredTextBox.Name = "enteredTextBox";
            this.enteredTextBox.Size = new System.Drawing.Size(120, 20);
            this.enteredTextBox.TabIndex = 8;
            // 
            // leftTextBox
            // 
            this.leftTextBox.Location = new System.Drawing.Point(12, 417);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(120, 20);
            this.leftTextBox.TabIndex = 9;
            // 
            // rankTextBox
            // 
            this.rankTextBox.Location = new System.Drawing.Point(12, 456);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(120, 20);
            this.rankTextBox.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(333, 433);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 43);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayMilitaryButton
            // 
            this.displayMilitaryButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.displayMilitaryButton.Location = new System.Drawing.Point(218, 433);
            this.displayMilitaryButton.Name = "displayMilitaryButton";
            this.displayMilitaryButton.Size = new System.Drawing.Size(109, 43);
            this.displayMilitaryButton.TabIndex = 11;
            this.displayMilitaryButton.Text = "Display Military Information";
            this.displayMilitaryButton.UseVisualStyleBackColor = true;
            this.displayMilitaryButton.Click += new System.EventHandler(this.displayMilitaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(443, 433);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 43);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayNameLabel.Location = new System.Drawing.Point(287, 291);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(201, 25);
            this.displayNameLabel.TabIndex = 14;
            this.displayNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayMilitaryDatesLabel
            // 
            this.displayMilitaryDatesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayMilitaryDatesLabel.Location = new System.Drawing.Point(287, 351);
            this.displayMilitaryDatesLabel.Name = "displayMilitaryDatesLabel";
            this.displayMilitaryDatesLabel.Size = new System.Drawing.Size(201, 24);
            this.displayMilitaryDatesLabel.TabIndex = 15;
            this.displayMilitaryDatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayRankLabel
            // 
            this.displayRankLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayRankLabel.Location = new System.Drawing.Point(287, 265);
            this.displayRankLabel.Name = "displayRankLabel";
            this.displayRankLabel.Size = new System.Drawing.Size(201, 23);
            this.displayRankLabel.TabIndex = 16;
            this.displayRankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(11, 12);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(100, 13);
            this.promptLabel.TabIndex = 18;
            this.promptLabel.Text = "Select your Branch:";
            // 
            // ouputBranchLabel
            // 
            this.ouputBranchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouputBranchLabel.Location = new System.Drawing.Point(287, 321);
            this.ouputBranchLabel.Name = "ouputBranchLabel";
            this.ouputBranchLabel.Size = new System.Drawing.Size(201, 23);
            this.ouputBranchLabel.TabIndex = 19;
            this.ouputBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.informationGroupBox.Controls.Add(this.rankCheckBox);
            this.informationGroupBox.Controls.Add(this.yearsServedCheckBox);
            this.informationGroupBox.Controls.Add(this.nameCheckBox);
            this.informationGroupBox.Location = new System.Drawing.Point(15, 223);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(114, 89);
            this.informationGroupBox.TabIndex = 21;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Select information:";
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(6, 19);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // yearsServedCheckBox
            // 
            this.yearsServedCheckBox.AutoSize = true;
            this.yearsServedCheckBox.Location = new System.Drawing.Point(6, 42);
            this.yearsServedCheckBox.Name = "yearsServedCheckBox";
            this.yearsServedCheckBox.Size = new System.Drawing.Size(90, 17);
            this.yearsServedCheckBox.TabIndex = 1;
            this.yearsServedCheckBox.Text = "Years Served";
            this.yearsServedCheckBox.UseVisualStyleBackColor = true;
            // 
            // rankCheckBox
            // 
            this.rankCheckBox.AutoSize = true;
            this.rankCheckBox.Location = new System.Drawing.Point(6, 67);
            this.rankCheckBox.Name = "rankCheckBox";
            this.rankCheckBox.Size = new System.Drawing.Size(52, 17);
            this.rankCheckBox.TabIndex = 2;
            this.rankCheckBox.Text = "Rank";
            this.rankCheckBox.UseVisualStyleBackColor = true;
            // 
            // militaryStatusLabel
            // 
            this.militaryStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.militaryStatusLabel.Location = new System.Drawing.Point(287, 381);
            this.militaryStatusLabel.Name = "militaryStatusLabel";
            this.militaryStatusLabel.Size = new System.Drawing.Size(201, 23);
            this.militaryStatusLabel.TabIndex = 22;
            this.militaryStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // branchPictureBox
            // 
            this.branchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.branchPictureBox.Image = global::Programming_Assignment_2.Properties.Resources._5_branches;
            this.branchPictureBox.InitialImage = global::Programming_Assignment_2.Properties.Resources._5_branches;
            this.branchPictureBox.Location = new System.Drawing.Point(268, 12);
            this.branchPictureBox.Name = "branchPictureBox";
            this.branchPictureBox.Size = new System.Drawing.Size(236, 238);
            this.branchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.branchPictureBox.TabIndex = 17;
            this.branchPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 488);
            this.Controls.Add(this.militaryStatusLabel);
            this.Controls.Add(this.informationGroupBox);
            this.Controls.Add(this.ouputBranchLabel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.branchPictureBox);
            this.Controls.Add(this.displayRankLabel);
            this.Controls.Add(this.displayMilitaryDatesLabel);
            this.Controls.Add(this.displayNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayMilitaryButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(this.leftTextBox);
            this.Controls.Add(this.enteredTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.leftServiceLabel);
            this.Controls.Add(this.enteredServiceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.militaryStatusGroupBox);
            this.Controls.Add(this.militaryBranchListBox);
            this.Name = "Form1";
            this.Text = "Military Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.militaryStatusGroupBox.ResumeLayout(false);
            this.militaryStatusGroupBox.PerformLayout();
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox militaryBranchListBox;
        private System.Windows.Forms.GroupBox militaryStatusGroupBox;
        private System.Windows.Forms.RadioButton retiredRadioButton;
        private System.Windows.Forms.RadioButton veteranRadioButton;
        private System.Windows.Forms.RadioButton reservistRadioButton;
        private System.Windows.Forms.RadioButton activeDutyRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label enteredServiceLabel;
        private System.Windows.Forms.Label leftServiceLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox enteredTextBox;
        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button displayMilitaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.Label displayMilitaryDatesLabel;
        private System.Windows.Forms.Label displayRankLabel;
        private System.Windows.Forms.PictureBox branchPictureBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label ouputBranchLabel;
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.CheckBox rankCheckBox;
        private System.Windows.Forms.CheckBox yearsServedCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.Label militaryStatusLabel;
    }
}

