namespace Program_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.exerciseLbl = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.durationText = new System.Windows.Forms.TextBox();
            this.exerciseTypeCombo = new System.Windows.Forms.ComboBox();
            this.waterYesBtn = new System.Windows.Forms.RadioButton();
            this.waterNoBtn = new System.Windows.Forms.RadioButton();
            this.smokeYesBtn = new System.Windows.Forms.RadioButton();
            this.smokeNoBtn = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.yourPointsSignLbl = new System.Windows.Forms.Label();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.adjustedLbl = new System.Windows.Forms.Label();
            this.pointsOutput = new System.Windows.Forms.Label();
            this.adjustOutput = new System.Windows.Forms.Label();
            this.smokeBox = new System.Windows.Forms.GroupBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.smokeLbl = new System.Windows.Forms.Label();
            this.hydrateBox = new System.Windows.Forms.GroupBox();
            this.smokeBox.SuspendLayout();
            this.hydrateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fitpoints Tracker";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(48, 62);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(41, 13);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name: ";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(60, 103);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 2;
            this.ageLbl.Text = "Age:";
            // 
            // exerciseLbl
            // 
            this.exerciseLbl.AutoSize = true;
            this.exerciseLbl.Location = new System.Drawing.Point(12, 144);
            this.exerciseLbl.Name = "exerciseLbl";
            this.exerciseLbl.Size = new System.Drawing.Size(77, 13);
            this.exerciseLbl.TabIndex = 3;
            this.exerciseLbl.Text = "Exercise Type:";
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Location = new System.Drawing.Point(39, 189);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(50, 13);
            this.durationLbl.TabIndex = 4;
            this.durationLbl.Text = "Duration:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(95, 59);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(121, 20);
            this.nameText.TabIndex = 5;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(95, 100);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(121, 20);
            this.ageText.TabIndex = 6;
            // 
            // durationText
            // 
            this.durationText.Location = new System.Drawing.Point(95, 186);
            this.durationText.Name = "durationText";
            this.durationText.Size = new System.Drawing.Size(121, 20);
            this.durationText.TabIndex = 8;
            // 
            // exerciseTypeCombo
            // 
            this.exerciseTypeCombo.FormattingEnabled = true;
            this.exerciseTypeCombo.Items.AddRange(new object[] {
            "Running",
            "Weight Training",
            "Cycling",
            "Yoga",
            "Other"});
            this.exerciseTypeCombo.Location = new System.Drawing.Point(95, 141);
            this.exerciseTypeCombo.MaxDropDownItems = 5;
            this.exerciseTypeCombo.Name = "exerciseTypeCombo";
            this.exerciseTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.exerciseTypeCombo.TabIndex = 9;
            // 
            // waterYesBtn
            // 
            this.waterYesBtn.AutoSize = true;
            this.waterYesBtn.Location = new System.Drawing.Point(17, 22);
            this.waterYesBtn.Name = "waterYesBtn";
            this.waterYesBtn.Size = new System.Drawing.Size(43, 17);
            this.waterYesBtn.TabIndex = 11;
            this.waterYesBtn.TabStop = true;
            this.waterYesBtn.Text = "Yes";
            this.waterYesBtn.UseVisualStyleBackColor = true;
            // 
            // waterNoBtn
            // 
            this.waterNoBtn.AutoSize = true;
            this.waterNoBtn.Location = new System.Drawing.Point(87, 24);
            this.waterNoBtn.Name = "waterNoBtn";
            this.waterNoBtn.Size = new System.Drawing.Size(39, 17);
            this.waterNoBtn.TabIndex = 12;
            this.waterNoBtn.TabStop = true;
            this.waterNoBtn.Text = "No";
            this.waterNoBtn.UseVisualStyleBackColor = true;
            // 
            // smokeYesBtn
            // 
            this.smokeYesBtn.AutoSize = true;
            this.smokeYesBtn.Location = new System.Drawing.Point(19, 19);
            this.smokeYesBtn.Name = "smokeYesBtn";
            this.smokeYesBtn.Size = new System.Drawing.Size(43, 17);
            this.smokeYesBtn.TabIndex = 15;
            this.smokeYesBtn.TabStop = true;
            this.smokeYesBtn.Text = "Yes";
            this.smokeYesBtn.UseVisualStyleBackColor = true;
            // 
            // smokeNoBtn
            // 
            this.smokeNoBtn.AutoSize = true;
            this.smokeNoBtn.Location = new System.Drawing.Point(90, 19);
            this.smokeNoBtn.Name = "smokeNoBtn";
            this.smokeNoBtn.Size = new System.Drawing.Size(39, 17);
            this.smokeNoBtn.TabIndex = 16;
            this.smokeNoBtn.TabStop = true;
            this.smokeNoBtn.Text = "No";
            this.smokeNoBtn.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calcButton.Location = new System.Drawing.Point(63, 399);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(104, 36);
            this.calcButton.TabIndex = 17;
            this.calcButton.Text = "Log Activity";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // yourPointsSignLbl
            // 
            this.yourPointsSignLbl.AutoSize = true;
            this.yourPointsSignLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourPointsSignLbl.Location = new System.Drawing.Point(11, 446);
            this.yourPointsSignLbl.Name = "yourPointsSignLbl";
            this.yourPointsSignLbl.Size = new System.Drawing.Size(91, 20);
            this.yourPointsSignLbl.TabIndex = 18;
            this.yourPointsSignLbl.Text = "Your Points";
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Location = new System.Drawing.Point(25, 493);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(42, 13);
            this.pointsLbl.TabIndex = 19;
            this.pointsLbl.Text = "Points: ";
            // 
            // adjustedLbl
            // 
            this.adjustedLbl.AutoSize = true;
            this.adjustedLbl.Location = new System.Drawing.Point(14, 528);
            this.adjustedLbl.Name = "adjustedLbl";
            this.adjustedLbl.Size = new System.Drawing.Size(54, 13);
            this.adjustedLbl.TabIndex = 20;
            this.adjustedLbl.Text = "Adjusted: ";
            // 
            // pointsOutput
            // 
            this.pointsOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pointsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsOutput.Location = new System.Drawing.Point(95, 483);
            this.pointsOutput.Name = "pointsOutput";
            this.pointsOutput.Size = new System.Drawing.Size(100, 23);
            this.pointsOutput.TabIndex = 21;
            // 
            // adjustOutput
            // 
            this.adjustOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adjustOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjustOutput.Location = new System.Drawing.Point(95, 527);
            this.adjustOutput.Name = "adjustOutput";
            this.adjustOutput.Size = new System.Drawing.Size(100, 23);
            this.adjustOutput.TabIndex = 22;
            // 
            // smokeBox
            // 
            this.smokeBox.Controls.Add(this.smokeYesBtn);
            this.smokeBox.Controls.Add(this.smokeNoBtn);
            this.smokeBox.Location = new System.Drawing.Point(37, 330);
            this.smokeBox.Name = "smokeBox";
            this.smokeBox.Size = new System.Drawing.Size(158, 65);
            this.smokeBox.TabIndex = 23;
            this.smokeBox.TabStop = false;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(33, 221);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(193, 20);
            this.questionLbl.TabIndex = 10;
            this.questionLbl.Text = "Have you hydrated today?";
            // 
            // smokeLbl
            // 
            this.smokeLbl.AutoSize = true;
            this.smokeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smokeLbl.Location = new System.Drawing.Point(40, 307);
            this.smokeLbl.Name = "smokeLbl";
            this.smokeLbl.Size = new System.Drawing.Size(119, 20);
            this.smokeLbl.TabIndex = 13;
            this.smokeLbl.Text = "Do you smoke?";
            // 
            // hydrateBox
            // 
            this.hydrateBox.Controls.Add(this.waterYesBtn);
            this.hydrateBox.Controls.Add(this.waterNoBtn);
            this.hydrateBox.Location = new System.Drawing.Point(37, 244);
            this.hydrateBox.Name = "hydrateBox";
            this.hydrateBox.Size = new System.Drawing.Size(158, 60);
            this.hydrateBox.TabIndex = 24;
            this.hydrateBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 605);
            this.Controls.Add(this.hydrateBox);
            this.Controls.Add(this.smokeBox);
            this.Controls.Add(this.adjustOutput);
            this.Controls.Add(this.pointsOutput);
            this.Controls.Add(this.adjustedLbl);
            this.Controls.Add(this.pointsLbl);
            this.Controls.Add(this.yourPointsSignLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.smokeLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.exerciseTypeCombo);
            this.Controls.Add(this.durationText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.exerciseLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fitpoints";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.smokeBox.ResumeLayout(false);
            this.smokeBox.PerformLayout();
            this.hydrateBox.ResumeLayout(false);
            this.hydrateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label exerciseLbl;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox durationText;
        private System.Windows.Forms.ComboBox exerciseTypeCombo;
        private System.Windows.Forms.RadioButton waterYesBtn;
        private System.Windows.Forms.RadioButton waterNoBtn;
        private System.Windows.Forms.RadioButton smokeYesBtn;
        private System.Windows.Forms.RadioButton smokeNoBtn;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label yourPointsSignLbl;
        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Label adjustedLbl;
        private System.Windows.Forms.Label pointsOutput;
        private System.Windows.Forms.Label adjustOutput;
        private System.Windows.Forms.GroupBox smokeBox;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label smokeLbl;
        private System.Windows.Forms.GroupBox hydrateBox;
    }
}

