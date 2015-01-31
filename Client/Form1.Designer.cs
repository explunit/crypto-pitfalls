﻿namespace Client
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
			this.txtAccountNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtReasonCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtPlainToken = new System.Windows.Forms.TextBox();
			this.txtEncryptedToken = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.txtBlockLabelsEnc = new System.Windows.Forms.TextBox();
			this.txtBlockLabelsPln = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtAccountNumber
			// 
			this.txtAccountNumber.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountNumber.Location = new System.Drawing.Point(185, 16);
			this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAccountNumber.Name = "txtAccountNumber";
			this.txtAccountNumber.Size = new System.Drawing.Size(268, 22);
			this.txtAccountNumber.TabIndex = 0;
			this.txtAccountNumber.Text = "10154265843";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Account Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 52);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Reason Code";
			// 
			// txtReasonCode
			// 
			this.txtReasonCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReasonCode.Location = new System.Drawing.Point(185, 48);
			this.txtReasonCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtReasonCode.Name = "txtReasonCode";
			this.txtReasonCode.Size = new System.Drawing.Size(268, 22);
			this.txtReasonCode.TabIndex = 2;
			this.txtReasonCode.Text = "ACPT";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 84);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Amount";
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmount.Location = new System.Drawing.Point(185, 80);
			this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(268, 22);
			this.txtAmount.TabIndex = 4;
			this.txtAmount.Text = "95.99";
			// 
			// txtPlainToken
			// 
			this.txtPlainToken.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlainToken.Location = new System.Drawing.Point(16, 185);
			this.txtPlainToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPlainToken.Name = "txtPlainToken";
			this.txtPlainToken.Size = new System.Drawing.Size(680, 22);
			this.txtPlainToken.TabIndex = 6;
			// 
			// txtEncryptedToken
			// 
			this.txtEncryptedToken.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEncryptedToken.Location = new System.Drawing.Point(16, 274);
			this.txtEncryptedToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtEncryptedToken.Name = "txtEncryptedToken";
			this.txtEncryptedToken.Size = new System.Drawing.Size(1131, 22);
			this.txtEncryptedToken.TabIndex = 7;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(264, 112);
			this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(191, 39);
			this.btnGenerate.TabIndex = 8;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// txtBlockLabelsEnc
			// 
			this.txtBlockLabelsEnc.BackColor = System.Drawing.SystemColors.Control;
			this.txtBlockLabelsEnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBlockLabelsEnc.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBlockLabelsEnc.Location = new System.Drawing.Point(18, 294);
			this.txtBlockLabelsEnc.Margin = new System.Windows.Forms.Padding(4);
			this.txtBlockLabelsEnc.Name = "txtBlockLabelsEnc";
			this.txtBlockLabelsEnc.Size = new System.Drawing.Size(1131, 15);
			this.txtBlockLabelsEnc.TabIndex = 9;
			// 
			// txtBlockLabelsPln
			// 
			this.txtBlockLabelsPln.BackColor = System.Drawing.SystemColors.Control;
			this.txtBlockLabelsPln.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBlockLabelsPln.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBlockLabelsPln.Location = new System.Drawing.Point(18, 206);
			this.txtBlockLabelsPln.Margin = new System.Windows.Forms.Padding(4);
			this.txtBlockLabelsPln.Name = "txtBlockLabelsPln";
			this.txtBlockLabelsPln.Size = new System.Drawing.Size(680, 15);
			this.txtBlockLabelsPln.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1437, 772);
			this.Controls.Add(this.txtBlockLabelsPln);
			this.Controls.Add(this.txtBlockLabelsEnc);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtEncryptedToken);
			this.Controls.Add(this.txtPlainToken);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtReasonCode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAccountNumber);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAccountNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtReasonCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtPlainToken;
		private System.Windows.Forms.TextBox txtEncryptedToken;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox txtBlockLabelsEnc;
		private System.Windows.Forms.TextBox txtBlockLabelsPln;
	}
}

