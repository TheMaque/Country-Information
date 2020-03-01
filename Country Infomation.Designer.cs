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
			this.btnSearch = new System.Windows.Forms.Button();
			this.btntxtClear = new System.Windows.Forms.Button();
			this.txtLongandLat = new System.Windows.Forms.TextBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// lstCountryInfo
			// 
			this.lstCountryInfo.BackColor = System.Drawing.Color.Black;
			this.lstCountryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCountryInfo.ForeColor = System.Drawing.Color.White;
			this.lstCountryInfo.FormattingEnabled = true;
			this.lstCountryInfo.ItemHeight = 16;
			this.lstCountryInfo.Location = new System.Drawing.Point(384, 33);
			this.lstCountryInfo.Name = "lstCountryInfo";
			this.lstCountryInfo.Size = new System.Drawing.Size(249, 276);
			this.lstCountryInfo.TabIndex = 0;
			this.lstCountryInfo.Click += new System.EventHandler(this.lstCountryInfo_Click);
			this.lstCountryInfo.DoubleClick += new System.EventHandler(this.lstCountryInfo_DoubleClick);
			// 
			// txtCountryName
			// 
			this.txtCountryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtCountryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtCountryName.BackColor = System.Drawing.Color.Black;
			this.txtCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCountryName.ForeColor = System.Drawing.Color.White;
			this.txtCountryName.Location = new System.Drawing.Point(384, 347);
			this.txtCountryName.Name = "txtCountryName";
			this.txtCountryName.Size = new System.Drawing.Size(170, 22);
			this.txtCountryName.TabIndex = 3;
			this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSearch.Enabled = false;
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSearch.Location = new System.Drawing.Point(561, 347);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(72, 22);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btntxtClear
			// 
			this.btntxtClear.BackColor = System.Drawing.SystemColors.Control;
			this.btntxtClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btntxtClear.Enabled = false;
			this.btntxtClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btntxtClear.Location = new System.Drawing.Point(560, 375);
			this.btntxtClear.Name = "btntxtClear";
			this.btntxtClear.Size = new System.Drawing.Size(72, 22);
			this.btntxtClear.TabIndex = 5;
			this.btntxtClear.Text = "Clear";
			this.btntxtClear.UseVisualStyleBackColor = false;
			this.btntxtClear.Click += new System.EventHandler(this.btntxtClear_Click);
			// 
			// txtLongandLat
			// 
			this.txtLongandLat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtLongandLat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtLongandLat.BackColor = System.Drawing.Color.Black;
			this.txtLongandLat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtLongandLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLongandLat.ForeColor = System.Drawing.Color.White;
			this.txtLongandLat.Location = new System.Drawing.Point(12, 416);
			this.txtLongandLat.Name = "txtLongandLat";
			this.txtLongandLat.Size = new System.Drawing.Size(638, 22);
			this.txtLongandLat.TabIndex = 6;
			// 
			// webBrowser
			// 
			this.webBrowser.AllowNavigation = false;
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.Location = new System.Drawing.Point(12, 33);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(356, 336);
			this.webBrowser.TabIndex = 7;
			this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
			// 
			// CountryInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Country_Information.Properties.Resources.World_Map_Background;
			this.ClientSize = new System.Drawing.Size(662, 450);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.txtLongandLat);
			this.Controls.Add(this.btntxtClear);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtCountryName);
			this.Controls.Add(this.lstCountryInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "CountryInformation";
			this.Text = "Country Information";
			this.Load += new System.EventHandler(this.CountryInformation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstCountryInfo;
		private System.Windows.Forms.TextBox txtCountryName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btntxtClear;
		private System.Windows.Forms.TextBox txtLongandLat;
		private System.Windows.Forms.WebBrowser webBrowser;
	}
}

