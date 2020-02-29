namespace Country_Information
{
	partial class CountryInformation
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
			this.lstCountryInfo = new System.Windows.Forms.ListBox();
			this.txtCountryName = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btntxtClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstCountryInfo
			// 
			this.lstCountryInfo.FormattingEnabled = true;
			this.lstCountryInfo.Location = new System.Drawing.Point(137, 37);
			this.lstCountryInfo.Name = "lstCountryInfo";
			this.lstCountryInfo.Size = new System.Drawing.Size(371, 316);
			this.lstCountryInfo.TabIndex = 0;
			// 
			// txtCountryName
			// 
			this.txtCountryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtCountryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtCountryName.BackColor = System.Drawing.SystemColors.Control;
			this.txtCountryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCountryName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCountryName.Location = new System.Drawing.Point(137, 370);
			this.txtCountryName.Name = "txtCountryName";
			this.txtCountryName.Size = new System.Drawing.Size(371, 20);
			this.txtCountryName.TabIndex = 3;
			this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.SystemColors.Control;
			this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFind.Enabled = false;
			this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnFind.Location = new System.Drawing.Point(302, 396);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(72, 22);
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btntxtClear
			// 
			this.btntxtClear.BackColor = System.Drawing.SystemColors.Control;
			this.btntxtClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btntxtClear.Enabled = false;
			this.btntxtClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btntxtClear.Location = new System.Drawing.Point(302, 424);
			this.btntxtClear.Name = "btntxtClear";
			this.btntxtClear.Size = new System.Drawing.Size(72, 22);
			this.btntxtClear.TabIndex = 5;
			this.btntxtClear.Text = "Clear";
			this.btntxtClear.UseVisualStyleBackColor = false;
			this.btntxtClear.Click += new System.EventHandler(this.btntxtClear_Click);
			// 
			// CountryInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 450);
			this.Controls.Add(this.btntxtClear);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtCountryName);
			this.Controls.Add(this.lstCountryInfo);
			this.Name = "CountryInformation";
			this.Text = "Country Information";
			this.Load += new System.EventHandler(this.CountryInformation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstCountryInfo;
		private System.Windows.Forms.TextBox txtCountryName;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btntxtClear;
	}
}

