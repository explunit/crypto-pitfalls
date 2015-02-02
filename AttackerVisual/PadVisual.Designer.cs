namespace AttackerVisual
{
	partial class PadVisual
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.txtC1 = new System.Windows.Forms.MaskedTextBox();
			this.txtFullPlainText = new System.Windows.Forms.MaskedTextBox();
			this.txtEncryptedToken = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBegin = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.txtC2 = new System.Windows.Forms.MaskedTextBox();
			this.txtFakeP1 = new System.Windows.Forms.MaskedTextBox();
			this.txtI2 = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtC1Prime = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBlockPlaintext = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtC1
			// 
			this.txtC1.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtC1.Location = new System.Drawing.Point(7, 152);
			this.txtC1.Mask = "&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&";
			this.txtC1.Name = "txtC1";
			this.txtC1.Size = new System.Drawing.Size(545, 29);
			this.txtC1.TabIndex = 0;
			this.txtC1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtFullPlainText
			// 
			this.txtFullPlainText.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtFullPlainText.Location = new System.Drawing.Point(7, 497);
			this.txtFullPlainText.Name = "txtFullPlainText";
			this.txtFullPlainText.Size = new System.Drawing.Size(1109, 29);
			this.txtFullPlainText.TabIndex = 6;
			// 
			// txtEncryptedToken
			// 
			this.txtEncryptedToken.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEncryptedToken.Location = new System.Drawing.Point(7, 28);
			this.txtEncryptedToken.Margin = new System.Windows.Forms.Padding(4);
			this.txtEncryptedToken.Name = "txtEncryptedToken";
			this.txtEncryptedToken.Size = new System.Drawing.Size(1488, 29);
			this.txtEncryptedToken.TabIndex = 8;
			this.txtEncryptedToken.Text = "e57397803ad6fece3324a39d59b92142c8239df10f89db46f42ceddcf925239aa8fbe3519c79ea108" +
    "2b2888a946106f15f8f156a45ffcefcd7796febd53d0970";
			this.txtEncryptedToken.TextChanged += new System.EventHandler(this.txtEncryptedToken_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "Ciphertext";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 470);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "Plaintext";
			// 
			// btnBegin
			// 
			this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBegin.Location = new System.Drawing.Point(515, 78);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new System.Drawing.Size(88, 41);
			this.btnBegin.TabIndex = 12;
			this.btnBegin.Text = "Begin";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
			// 
			// txtC2
			// 
			this.txtC2.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtC2.Location = new System.Drawing.Point(631, 152);
			this.txtC2.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtC2.Name = "txtC2";
			this.txtC2.Size = new System.Drawing.Size(545, 29);
			this.txtC2.TabIndex = 13;
			this.txtC2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtFakeP1
			// 
			this.txtFakeP1.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtFakeP1.Location = new System.Drawing.Point(631, 355);
			this.txtFakeP1.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtFakeP1.Name = "txtFakeP1";
			this.txtFakeP1.Size = new System.Drawing.Size(545, 29);
			this.txtFakeP1.TabIndex = 14;
			this.txtFakeP1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtI2
			// 
			this.txtI2.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtI2.Location = new System.Drawing.Point(631, 277);
			this.txtI2.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtI2.Name = "txtI2";
			this.txtI2.Size = new System.Drawing.Size(545, 29);
			this.txtI2.TabIndex = 15;
			this.txtI2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(790, 178);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(187, 69);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "AES Decrypt (key unknown)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 24);
			this.label3.TabIndex = 17;
			this.label3.Text = "C1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(627, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 24);
			this.label4.TabIndex = 18;
			this.label4.Text = "C2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(627, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(313, 24);
			this.label5.TabIndex = 19;
			this.label5.Text = "Intermediate value after AES decrypt";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(627, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(326, 24);
			this.label6.TabIndex = 20;
			this.label6.Text = "Fake Plaintext For Padding Test (hex)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 250);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 24);
			this.label7.TabIndex = 22;
			this.label7.Text = "Fake C1";
			// 
			// txtC1Prime
			// 
			this.txtC1Prime.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtC1Prime.Location = new System.Drawing.Point(7, 277);
			this.txtC1Prime.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtC1Prime.Name = "txtC1Prime";
			this.txtC1Prime.Size = new System.Drawing.Size(545, 29);
			this.txtC1Prime.TabIndex = 21;
			this.txtC1Prime.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(627, 407);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(171, 24);
			this.label8.TabIndex = 24;
			this.label8.Text = "C2 Plaintext (ASCII)";
			// 
			// txtBlockPlaintext
			// 
			this.txtBlockPlaintext.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtBlockPlaintext.Location = new System.Drawing.Point(631, 434);
			this.txtBlockPlaintext.Name = "txtBlockPlaintext";
			this.txtBlockPlaintext.Size = new System.Drawing.Size(545, 29);
			this.txtBlockPlaintext.TabIndex = 25;
			// 
			// PadVisual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1508, 596);
			this.Controls.Add(this.txtBlockPlaintext);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtC1Prime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtI2);
			this.Controls.Add(this.txtFakeP1);
			this.Controls.Add(this.txtC2);
			this.Controls.Add(this.btnBegin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEncryptedToken);
			this.Controls.Add(this.txtFullPlainText);
			this.Controls.Add(this.txtC1);
			this.Name = "PadVisual";
			this.Text = "Padding Oracle Visualization";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox txtC1;
		private System.Windows.Forms.MaskedTextBox txtFullPlainText;
		private System.Windows.Forms.TextBox txtEncryptedToken;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBegin;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.MaskedTextBox txtC2;
		private System.Windows.Forms.MaskedTextBox txtFakeP1;
		private System.Windows.Forms.MaskedTextBox txtI2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtC1Prime;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBlockPlaintext;
	}
}

