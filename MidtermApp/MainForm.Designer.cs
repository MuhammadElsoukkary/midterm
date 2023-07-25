namespace MidtermApp
{
    partial class MainForm
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
            groupBoxQuestion1 = new GroupBox();
            btnCheckValidity = new Button();
            txtBoxZipCode = new TextBox();
            label1 = new Label();
            groupBoxQuestion3 = new GroupBox();
            listBoxMatchingPhrases = new ListBox();
            lblMatchingPhrases = new Label();
            groupBoxQuestion2 = new GroupBox();
            lblInputTexChanged = new Label();
            btnRemoveVowels = new Button();
            txtBoxInputText = new TextBox();
            label2 = new Label();
            groupBoxQuestion4 = new GroupBox();
            button5 = new Button();
            lblErrorMessages = new Label();
            rtbText = new RichTextBox();
            btnAllPatients = new Button();
            btnShowChildren = new Button();
            txtBoxRecordNumber = new TextBox();
            txtBoxAge = new TextBox();
            txtBoxFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBoxQuestion1.SuspendLayout();
            groupBoxQuestion3.SuspendLayout();
            groupBoxQuestion2.SuspendLayout();
            groupBoxQuestion4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxQuestion1
            // 
            groupBoxQuestion1.Controls.Add(btnCheckValidity);
            groupBoxQuestion1.Controls.Add(txtBoxZipCode);
            groupBoxQuestion1.Controls.Add(label1);
            groupBoxQuestion1.Location = new Point(47, 42);
            groupBoxQuestion1.Margin = new Padding(4, 5, 4, 5);
            groupBoxQuestion1.Name = "groupBoxQuestion1";
            groupBoxQuestion1.Padding = new Padding(4, 5, 4, 5);
            groupBoxQuestion1.Size = new Size(766, 167);
            groupBoxQuestion1.TabIndex = 0;
            groupBoxQuestion1.TabStop = false;
            groupBoxQuestion1.Text = "Question 1:";
            // 
            // btnCheckValidity
            // 
            btnCheckValidity.Location = new Point(407, 63);
            btnCheckValidity.Name = "btnCheckValidity";
            btnCheckValidity.Size = new Size(168, 34);
            btnCheckValidity.TabIndex = 2;
            btnCheckValidity.Text = "Check validity";
            btnCheckValidity.UseVisualStyleBackColor = true;
            btnCheckValidity.Click += button1_Click;
            // 
            // txtBoxZipCode
            // 
            txtBoxZipCode.Location = new Point(72, 80);
            txtBoxZipCode.Name = "txtBoxZipCode";
            txtBoxZipCode.Size = new Size(150, 31);
            txtBoxZipCode.TabIndex = 1;
            txtBoxZipCode.TextChanged += txtBoxZipCode_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Zipcode";
            // 
            // groupBoxQuestion3
            // 
            groupBoxQuestion3.Controls.Add(listBoxMatchingPhrases);
            groupBoxQuestion3.Controls.Add(lblMatchingPhrases);
            groupBoxQuestion3.Location = new Point(881, 42);
            groupBoxQuestion3.Margin = new Padding(4, 5, 4, 5);
            groupBoxQuestion3.Name = "groupBoxQuestion3";
            groupBoxQuestion3.Padding = new Padding(4, 5, 4, 5);
            groupBoxQuestion3.Size = new Size(259, 375);
            groupBoxQuestion3.TabIndex = 1;
            groupBoxQuestion3.TabStop = false;
            groupBoxQuestion3.Text = "Question 3:";
            // 
            // listBoxMatchingPhrases
            // 
            listBoxMatchingPhrases.FormattingEnabled = true;
            listBoxMatchingPhrases.ItemHeight = 25;
            listBoxMatchingPhrases.Items.AddRange(new object[] { "B", "C", "E", "F", "G" });
            listBoxMatchingPhrases.Location = new Point(37, 80);
            listBoxMatchingPhrases.Margin = new Padding(4, 5, 4, 5);
            listBoxMatchingPhrases.Name = "listBoxMatchingPhrases";
            listBoxMatchingPhrases.Size = new Size(170, 254);
            listBoxMatchingPhrases.TabIndex = 1;
            listBoxMatchingPhrases.SelectedIndexChanged += listBoxMatchingPhrases_SelectedIndexChanged;
            // 
            // lblMatchingPhrases
            // 
            lblMatchingPhrases.AutoSize = true;
            lblMatchingPhrases.Location = new Point(37, 50);
            lblMatchingPhrases.Margin = new Padding(4, 0, 4, 0);
            lblMatchingPhrases.Name = "lblMatchingPhrases";
            lblMatchingPhrases.Size = new Size(156, 25);
            lblMatchingPhrases.TabIndex = 0;
            lblMatchingPhrases.Text = "Matching phrases:";
            // 
            // groupBoxQuestion2
            // 
            groupBoxQuestion2.Controls.Add(lblInputTexChanged);
            groupBoxQuestion2.Controls.Add(btnRemoveVowels);
            groupBoxQuestion2.Controls.Add(txtBoxInputText);
            groupBoxQuestion2.Controls.Add(label2);
            groupBoxQuestion2.Location = new Point(47, 250);
            groupBoxQuestion2.Margin = new Padding(4, 5, 4, 5);
            groupBoxQuestion2.Name = "groupBoxQuestion2";
            groupBoxQuestion2.Padding = new Padding(4, 5, 4, 5);
            groupBoxQuestion2.Size = new Size(766, 167);
            groupBoxQuestion2.TabIndex = 1;
            groupBoxQuestion2.TabStop = false;
            groupBoxQuestion2.Text = "Question 2:";
            groupBoxQuestion2.Enter += groupBoxQuestion2_Enter;
            // 
            // lblInputTexChanged
            // 
            lblInputTexChanged.AutoSize = true;
            lblInputTexChanged.Location = new Point(57, 124);
            lblInputTexChanged.Name = "lblInputTexChanged";
            lblInputTexChanged.Size = new Size(0, 25);
            lblInputTexChanged.TabIndex = 3;
            // 
            // btnRemoveVowels
            // 
            btnRemoveVowels.Location = new Point(418, 92);
            btnRemoveVowels.Name = "btnRemoveVowels";
            btnRemoveVowels.Size = new Size(201, 34);
            btnRemoveVowels.TabIndex = 2;
            btnRemoveVowels.Text = "Remove vowels";
            btnRemoveVowels.UseVisualStyleBackColor = true;
            btnRemoveVowels.Click += button2_Click;
            // 
            // txtBoxInputText
            // 
            txtBoxInputText.Location = new Point(202, 95);
            txtBoxInputText.Name = "txtBoxInputText";
            txtBoxInputText.Size = new Size(150, 31);
            txtBoxInputText.TabIndex = 1;
            txtBoxInputText.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 56);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 0;
            label2.Text = "Input text";
            // 
            // groupBoxQuestion4
            // 
            groupBoxQuestion4.Controls.Add(button5);
            groupBoxQuestion4.Controls.Add(lblErrorMessages);
            groupBoxQuestion4.Controls.Add(rtbText);
            groupBoxQuestion4.Controls.Add(btnAllPatients);
            groupBoxQuestion4.Controls.Add(btnShowChildren);
            groupBoxQuestion4.Controls.Add(txtBoxRecordNumber);
            groupBoxQuestion4.Controls.Add(txtBoxAge);
            groupBoxQuestion4.Controls.Add(txtBoxFullName);
            groupBoxQuestion4.Controls.Add(label5);
            groupBoxQuestion4.Controls.Add(label4);
            groupBoxQuestion4.Controls.Add(label3);
            groupBoxQuestion4.Location = new Point(47, 458);
            groupBoxQuestion4.Margin = new Padding(4, 5, 4, 5);
            groupBoxQuestion4.Name = "groupBoxQuestion4";
            groupBoxQuestion4.Padding = new Padding(4, 5, 4, 5);
            groupBoxQuestion4.Size = new Size(1332, 483);
            groupBoxQuestion4.TabIndex = 2;
            groupBoxQuestion4.TabStop = false;
            groupBoxQuestion4.Text = "Question 4:";
            // 
            // button5
            // 
            button5.Location = new Point(47, 320);
            button5.Name = "button5";
            button5.Size = new Size(175, 34);
            button5.TabIndex = 10;
            button5.Text = "Add to schedule";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lblErrorMessages
            // 
            lblErrorMessages.AutoSize = true;
            lblErrorMessages.Location = new Point(212, 357);
            lblErrorMessages.Name = "lblErrorMessages";
            lblErrorMessages.Size = new Size(133, 25);
            lblErrorMessages.TabIndex = 9;
            lblErrorMessages.Text = "error messgaes";
            // 
            // rtbText
            // 
            rtbText.Location = new Point(684, 133);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(535, 160);
            rtbText.TabIndex = 8;
            rtbText.Text = "";
            rtbText.TextChanged += richTextBox1_TextChanged;
            // 
            // btnAllPatients
            // 
            btnAllPatients.Location = new Point(684, 50);
            btnAllPatients.Name = "btnAllPatients";
            btnAllPatients.Size = new Size(237, 34);
            btnAllPatients.TabIndex = 7;
            btnAllPatients.Text = "Show scheduled patients";
            btnAllPatients.UseVisualStyleBackColor = true;
            btnAllPatients.Click += btnAllPatients_Click;
            // 
            // btnShowChildren
            // 
            btnShowChildren.Location = new Point(967, 50);
            btnShowChildren.Name = "btnShowChildren";
            btnShowChildren.Size = new Size(252, 34);
            btnShowChildren.TabIndex = 6;
            btnShowChildren.Text = "Show scheduled children";
            btnShowChildren.UseVisualStyleBackColor = true;
            btnShowChildren.Click += button3_Click;
            // 
            // txtBoxRecordNumber
            // 
            txtBoxRecordNumber.Location = new Point(238, 159);
            txtBoxRecordNumber.Name = "txtBoxRecordNumber";
            txtBoxRecordNumber.Size = new Size(150, 31);
            txtBoxRecordNumber.TabIndex = 5;
            txtBoxRecordNumber.TextChanged += textBox4_TextChanged;
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(238, 237);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(150, 31);
            txtBoxAge.TabIndex = 4;
            txtBoxAge.TextChanged += textBox3_TextChanged;
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Location = new Point(226, 94);
            txtBoxFullName.Name = "txtBoxFullName";
            txtBoxFullName.Size = new Size(150, 31);
            txtBoxFullName.TabIndex = 3;
            txtBoxFullName.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 159);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 2;
            label5.Text = "Medical record #";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 225);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 1;
            label4.Text = "Pateints age";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 94);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 0;
            label3.Text = "Pateints full name:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2111, 992);
            Controls.Add(groupBoxQuestion4);
            Controls.Add(groupBoxQuestion2);
            Controls.Add(groupBoxQuestion3);
            Controls.Add(groupBoxQuestion1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Student: Muhammad Elsoukkary (88263383)";
            Load += MainForm_Load;
            groupBoxQuestion1.ResumeLayout(false);
            groupBoxQuestion1.PerformLayout();
            groupBoxQuestion3.ResumeLayout(false);
            groupBoxQuestion3.PerformLayout();
            groupBoxQuestion2.ResumeLayout(false);
            groupBoxQuestion2.PerformLayout();
            groupBoxQuestion4.ResumeLayout(false);
            groupBoxQuestion4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxQuestion1;
        private GroupBox groupBoxQuestion3;
        private ListBox listBoxMatchingPhrases;
        private Label lblMatchingPhrases;
        private GroupBox groupBoxQuestion2;
        private GroupBox groupBoxQuestion4;
        private Button btnCheckValidity;
        private TextBox txtBoxZipCode;
        private Label label1;
        private Button btnRemoveVowels;
        private TextBox txtBoxInputText;
        private Label label2;
        private Label lblErrorMessages;
        private RichTextBox rtbText;
        private Button btnAllPatients;
        private Button btnShowChildren;
        private TextBox txtBoxRecordNumber;
        private TextBox txtBoxAge;
        private TextBox txtBoxFullName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button5;
        private Label lblInputTexChanged;
    }
}