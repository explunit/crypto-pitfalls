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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PadVisual));
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtC1Prime = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBlockPlaintext = new System.Windows.Forms.TextBox();
			this.txtDelayMs = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.txtServerResponse = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.chkCustomFreq = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDelayMs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtC1
			// 
			this.txtC1.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtC1.Location = new System.Drawing.Point(683, 169);
			this.txtC1.Mask = "&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&-&&";
			this.txtC1.Name = "txtC1";
			this.txtC1.Size = new System.Drawing.Size(545, 29);
			this.txtC1.TabIndex = 0;
			this.txtC1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtFullPlainText
			// 
			this.txtFullPlainText.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtFullPlainText.Location = new System.Drawing.Point(7, 572);
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
			this.txtEncryptedToken.Text = "d837eb83a4ab66dcf7d459a4ece51353f30422c1478a838ef5a4bfed1d8f643404e28208a34682975" +
    "8e92eb14a0ccd8779b106ffedfbd914b624b68e2d835ee8";
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
			this.label2.Location = new System.Drawing.Point(3, 545);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "Plaintext";
			// 
			// btnBegin
			// 
			this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBegin.Location = new System.Drawing.Point(533, 61);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new System.Drawing.Size(88, 41);
			this.btnBegin.TabIndex = 12;
			this.btnBegin.Text = "Decrypt";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
			// 
			// txtC2
			// 
			this.txtC2.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtC2.Location = new System.Drawing.Point(16, 228);
			this.txtC2.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtC2.Name = "txtC2";
			this.txtC2.Size = new System.Drawing.Size(545, 29);
			this.txtC2.TabIndex = 13;
			this.txtC2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtFakeP1
			// 
			this.txtFakeP1.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtFakeP1.Location = new System.Drawing.Point(16, 397);
			this.txtFakeP1.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtFakeP1.Name = "txtFakeP1";
			this.txtFakeP1.Size = new System.Drawing.Size(545, 29);
			this.txtFakeP1.TabIndex = 14;
			this.txtFakeP1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtI2
			// 
			this.txtI2.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtI2.Location = new System.Drawing.Point(16, 456);
			this.txtI2.Mask = "AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA-AA";
			this.txtI2.Name = "txtI2";
			this.txtI2.Size = new System.Drawing.Size(545, 29);
			this.txtI2.TabIndex = 15;
			this.txtI2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(679, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(426, 24);
			this.label3.TabIndex = 17;
			this.label3.Text = "XOR the real block 1 with the intermediate value...";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(534, 24);
			this.label4.TabIndex = 18;
			this.label4.Text = "... and send it to server with real Block 2 that we want to decrypt";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 429);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(629, 24);
			this.label5.TabIndex = 19;
			this.label5.Text = "And XOR with fake Block 1 to find the intermediate value after AES decrypt";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 370);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(402, 24);
			this.label6.TabIndex = 20;
			this.label6.Text = "Which means we know the plaintext yields this:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 142);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(411, 24);
			this.label7.TabIndex = 22;
			this.label7.Text = "Block 1 try all possible byte values at position x...";
			// 
			// txtC1Prime
			// 
			this.txtC1Prime.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtC1Prime.Location = new System.Drawing.Point(16, 169);
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
			this.label8.Location = new System.Drawing.Point(679, 201);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(323, 24);
			this.label8.TabIndex = 24;
			this.label8.Text = "...and get the plaintext for that position";
			// 
			// txtBlockPlaintext
			// 
			this.txtBlockPlaintext.Font = new System.Drawing.Font("Courier New", 14.25F);
			this.txtBlockPlaintext.Location = new System.Drawing.Point(683, 228);
			this.txtBlockPlaintext.Name = "txtBlockPlaintext";
			this.txtBlockPlaintext.Size = new System.Drawing.Size(545, 29);
			this.txtBlockPlaintext.TabIndex = 25;
			// 
			// txtDelayMs
			// 
			this.txtDelayMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDelayMs.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txtDelayMs.Location = new System.Drawing.Point(810, 70);
			this.txtDelayMs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtDelayMs.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.txtDelayMs.Name = "txtDelayMs";
			this.txtDelayMs.Size = new System.Drawing.Size(120, 26);
			this.txtDelayMs.TabIndex = 26;
			this.txtDelayMs.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 268);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(482, 24);
			this.label9.TabIndex = 27;
			this.label9.Text = "Until the server response tells us we\'ve got valid padding";
			// 
			// txtServerResponse
			// 
			this.txtServerResponse.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtServerResponse.Location = new System.Drawing.Point(16, 296);
			this.txtServerResponse.Margin = new System.Windows.Forms.Padding(4);
			this.txtServerResponse.Name = "txtServerResponse";
			this.txtServerResponse.Size = new System.Drawing.Size(430, 29);
			this.txtServerResponse.TabIndex = 28;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(627, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(177, 24);
			this.label10.TabIndex = 29;
			this.label10.Text = "Request Delay (MS)";
			// 
			// chkCustomFreq
			// 
			this.chkCustomFreq.AutoSize = true;
			this.chkCustomFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkCustomFreq.Location = new System.Drawing.Point(946, 68);
			this.chkCustomFreq.Name = "chkCustomFreq";
			this.chkCustomFreq.Size = new System.Drawing.Size(205, 28);
			this.chkCustomFreq.TabIndex = 31;
			this.chkCustomFreq.Text = "Custom Frequencies";
			this.chkCustomFreq.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox1.Location = new System.Drawing.Point(7, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(637, 216);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 1";
			// 
			// groupBox2
			// 
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox2.Location = new System.Drawing.Point(7, 339);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(637, 172);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Step 2";
			// 
			// groupBox3
			// 
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox3.Location = new System.Drawing.Point(662, 117);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(650, 172);
			this.groupBox3.TabIndex = 35;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Step 3";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(662, 311);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(312, 222);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// PadVisual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1508, 624);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.chkCustomFreq);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtServerResponse);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDelayMs);
			this.Controls.Add(this.txtBlockPlaintext);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtC1Prime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtI2);
			this.Controls.Add(this.txtFakeP1);
			this.Controls.Add(this.txtC2);
			this.Controls.Add(this.btnBegin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEncryptedToken);
			this.Controls.Add(this.txtFullPlainText);
			this.Controls.Add(this.txtC1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Name = "PadVisual";
			this.Text = "Padding Oracle Visualization";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDelayMs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtC1Prime;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBlockPlaintext;
		private System.Windows.Forms.NumericUpDown txtDelayMs;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtServerResponse;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox chkCustomFreq;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

