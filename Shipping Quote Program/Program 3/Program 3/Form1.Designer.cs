namespace Program_3
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
            this.ShippingLbl = new System.Windows.Forms.Label();
            this.ProviderLbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProviderCmboBox = new System.Windows.Forms.ComboBox();
            this.BusCmboBox = new System.Windows.Forms.ComboBox();
            this.ContractLngthTxtBox = new System.Windows.Forms.TextBox();
            this.CalcBttn = new System.Windows.Forms.Button();
            this.ProvidorLbl2 = new System.Windows.Forms.Label();
            this.InContPriceLbl = new System.Windows.Forms.Label();
            this.CompDiscLbl = new System.Windows.Forms.Label();
            this.LngthDiscLbl = new System.Windows.Forms.Label();
            this.FinalPriceLbl = new System.Windows.Forms.Label();
            this.ProviderOutputLbl = new System.Windows.Forms.Label();
            this.InContPriceOutput = new System.Windows.Forms.Label();
            this.CompDiscOutput = new System.Windows.Forms.Label();
            this.LngthDiscOutput = new System.Windows.Forms.Label();
            this.FinalPriceOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShippingLbl
            // 
            this.ShippingLbl.AutoSize = true;
            this.ShippingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLbl.Location = new System.Drawing.Point(144, 45);
            this.ShippingLbl.Name = "ShippingLbl";
            this.ShippingLbl.Size = new System.Drawing.Size(286, 25);
            this.ShippingLbl.TabIndex = 0;
            this.ShippingLbl.Text = "Shipping Contract Calculator";
            // 
            // ProviderLbl1
            // 
            this.ProviderLbl1.AutoSize = true;
            this.ProviderLbl1.Location = new System.Drawing.Point(146, 116);
            this.ProviderLbl1.Name = "ProviderLbl1";
            this.ProviderLbl1.Size = new System.Drawing.Size(52, 13);
            this.ProviderLbl1.TabIndex = 1;
            this.ProviderLbl1.Text = "Provider: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Business: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contract Length: ";
            // 
            // ProviderCmboBox
            // 
            this.ProviderCmboBox.FormattingEnabled = true;
            this.ProviderCmboBox.Items.AddRange(new object[] {
            "USPS",
            "DHL",
            "FedEx",
            "UPS"});
            this.ProviderCmboBox.Location = new System.Drawing.Point(204, 113);
            this.ProviderCmboBox.Name = "ProviderCmboBox";
            this.ProviderCmboBox.Size = new System.Drawing.Size(121, 21);
            this.ProviderCmboBox.TabIndex = 4;
            // 
            // BusCmboBox
            // 
            this.BusCmboBox.FormattingEnabled = true;
            this.BusCmboBox.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.BusCmboBox.Location = new System.Drawing.Point(204, 154);
            this.BusCmboBox.Name = "BusCmboBox";
            this.BusCmboBox.Size = new System.Drawing.Size(121, 21);
            this.BusCmboBox.TabIndex = 5;
            // 
            // ContractLngthTxtBox
            // 
            this.ContractLngthTxtBox.Location = new System.Drawing.Point(204, 198);
            this.ContractLngthTxtBox.Name = "ContractLngthTxtBox";
            this.ContractLngthTxtBox.Size = new System.Drawing.Size(121, 20);
            this.ContractLngthTxtBox.TabIndex = 6;
            // 
            // CalcBttn
            // 
            this.CalcBttn.Location = new System.Drawing.Point(224, 262);
            this.CalcBttn.Name = "CalcBttn";
            this.CalcBttn.Size = new System.Drawing.Size(75, 23);
            this.CalcBttn.TabIndex = 7;
            this.CalcBttn.Text = "Calculate ";
            this.CalcBttn.UseVisualStyleBackColor = true;
            this.CalcBttn.Click += new System.EventHandler(this.CalcBttn_Click);
            // 
            // ProvidorLbl2
            // 
            this.ProvidorLbl2.AutoSize = true;
            this.ProvidorLbl2.Location = new System.Drawing.Point(102, 322);
            this.ProvidorLbl2.Name = "ProvidorLbl2";
            this.ProvidorLbl2.Size = new System.Drawing.Size(96, 13);
            this.ProvidorLbl2.TabIndex = 8;
            this.ProvidorLbl2.Text = "Shipping Provider: ";
            // 
            // InContPriceLbl
            // 
            this.InContPriceLbl.AutoSize = true;
            this.InContPriceLbl.Location = new System.Drawing.Point(91, 355);
            this.InContPriceLbl.Name = "InContPriceLbl";
            this.InContPriceLbl.Size = new System.Drawing.Size(107, 13);
            this.InContPriceLbl.TabIndex = 9;
            this.InContPriceLbl.Text = "Initial Contract Price: ";
            // 
            // CompDiscLbl
            // 
            this.CompDiscLbl.AutoSize = true;
            this.CompDiscLbl.Location = new System.Drawing.Point(96, 390);
            this.CompDiscLbl.Name = "CompDiscLbl";
            this.CompDiscLbl.Size = new System.Drawing.Size(102, 13);
            this.CompDiscLbl.TabIndex = 10;
            this.CompDiscLbl.Text = "Company Discount: ";
            // 
            // LngthDiscLbl
            // 
            this.LngthDiscLbl.AutoSize = true;
            this.LngthDiscLbl.Location = new System.Drawing.Point(107, 428);
            this.LngthDiscLbl.Name = "LngthDiscLbl";
            this.LngthDiscLbl.Size = new System.Drawing.Size(91, 13);
            this.LngthDiscLbl.TabIndex = 11;
            this.LngthDiscLbl.Text = "Length Discount: ";
            // 
            // FinalPriceLbl
            // 
            this.FinalPriceLbl.AutoSize = true;
            this.FinalPriceLbl.Location = new System.Drawing.Point(136, 462);
            this.FinalPriceLbl.Name = "FinalPriceLbl";
            this.FinalPriceLbl.Size = new System.Drawing.Size(62, 13);
            this.FinalPriceLbl.TabIndex = 12;
            this.FinalPriceLbl.Text = "Final Price: ";
            // 
            // ProviderOutputLbl
            // 
            this.ProviderOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProviderOutputLbl.CausesValidation = false;
            this.ProviderOutputLbl.Location = new System.Drawing.Point(204, 321);
            this.ProviderOutputLbl.Name = "ProviderOutputLbl";
            this.ProviderOutputLbl.Size = new System.Drawing.Size(121, 23);
            this.ProviderOutputLbl.TabIndex = 13;
            // 
            // InContPriceOutput
            // 
            this.InContPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InContPriceOutput.Location = new System.Drawing.Point(204, 355);
            this.InContPriceOutput.Name = "InContPriceOutput";
            this.InContPriceOutput.Size = new System.Drawing.Size(121, 23);
            this.InContPriceOutput.TabIndex = 14;
            // 
            // CompDiscOutput
            // 
            this.CompDiscOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompDiscOutput.Location = new System.Drawing.Point(204, 390);
            this.CompDiscOutput.Name = "CompDiscOutput";
            this.CompDiscOutput.Size = new System.Drawing.Size(121, 23);
            this.CompDiscOutput.TabIndex = 15;
            // 
            // LngthDiscOutput
            // 
            this.LngthDiscOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LngthDiscOutput.Location = new System.Drawing.Point(204, 428);
            this.LngthDiscOutput.Name = "LngthDiscOutput";
            this.LngthDiscOutput.Size = new System.Drawing.Size(121, 23);
            this.LngthDiscOutput.TabIndex = 16;
            // 
            // FinalPriceOutput
            // 
            this.FinalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalPriceOutput.Location = new System.Drawing.Point(204, 462);
            this.FinalPriceOutput.Name = "FinalPriceOutput";
            this.FinalPriceOutput.Size = new System.Drawing.Size(121, 23);
            this.FinalPriceOutput.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 554);
            this.Controls.Add(this.FinalPriceOutput);
            this.Controls.Add(this.LngthDiscOutput);
            this.Controls.Add(this.CompDiscOutput);
            this.Controls.Add(this.InContPriceOutput);
            this.Controls.Add(this.ProviderOutputLbl);
            this.Controls.Add(this.FinalPriceLbl);
            this.Controls.Add(this.LngthDiscLbl);
            this.Controls.Add(this.CompDiscLbl);
            this.Controls.Add(this.InContPriceLbl);
            this.Controls.Add(this.ProvidorLbl2);
            this.Controls.Add(this.CalcBttn);
            this.Controls.Add(this.ContractLngthTxtBox);
            this.Controls.Add(this.BusCmboBox);
            this.Controls.Add(this.ProviderCmboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProviderLbl1);
            this.Controls.Add(this.ShippingLbl);
            this.Name = "Form1";
            this.Text = "Contract Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShippingLbl;
        private System.Windows.Forms.Label ProviderLbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProviderCmboBox;
        private System.Windows.Forms.ComboBox BusCmboBox;
        private System.Windows.Forms.TextBox ContractLngthTxtBox;
        private System.Windows.Forms.Button CalcBttn;
        private System.Windows.Forms.Label ProvidorLbl2;
        private System.Windows.Forms.Label InContPriceLbl;
        private System.Windows.Forms.Label CompDiscLbl;
        private System.Windows.Forms.Label LngthDiscLbl;
        private System.Windows.Forms.Label FinalPriceLbl;
        private System.Windows.Forms.Label ProviderOutputLbl;
        private System.Windows.Forms.Label InContPriceOutput;
        private System.Windows.Forms.Label CompDiscOutput;
        private System.Windows.Forms.Label LngthDiscOutput;
        private System.Windows.Forms.Label FinalPriceOutput;
    }
}

