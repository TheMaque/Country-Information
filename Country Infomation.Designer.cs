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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryInformation));
			this.lstCountryInfo = new System.Windows.Forms.ListBox();
			this.txtCountryName = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btntxtClear = new System.Windows.Forms.Button();
			this.txtLongandLat = new System.Windows.Forms.TextBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.picBoxLogo = new System.Windows.Forms.PictureBox();
			this.grpGoogleSearch = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
			this.grpGoogleSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstCountryInfo
			// 
			this.lstCountryInfo.BackColor = System.Drawing.Color.Black;
			this.lstCountryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCountryInfo.ForeColor = System.Drawing.Color.White;
			this.lstCountryInfo.FormattingEnabled = true;
			this.lstCountryInfo.HorizontalScrollbar = true;
			this.lstCountryInfo.ItemHeight = 16;
			this.lstCountryInfo.Location = new System.Drawing.Point(541, 74);
			this.lstCountryInfo.Name = "lstCountryInfo";
			this.lstCountryInfo.Size = new System.Drawing.Size(249, 276);
			this.lstCountryInfo.TabIndex = 3;
			this.lstCountryInfo.Click += new System.EventHandler(this.lstCountryInfo_Click);
			this.lstCountryInfo.DoubleClick += new System.EventHandler(this.lstCountryInfo_DoubleClick);
			// 
			// txtCountryName
			// 
			this.txtCountryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtCountryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtCountryName.BackColor = System.Drawing.Color.Black;
			this.txtCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCountryName.ForeColor = System.Drawing.Color.White;
			this.txtCountryName.Location = new System.Drawing.Point(541, 356);
			this.txtCountryName.Name = "txtCountryName";
			this.txtCountryName.Size = new System.Drawing.Size(249, 26);
			this.txtCountryName.TabIndex = 0;
			this.txtCountryName.Click += new System.EventHandler(this.txtCountryName_Click);
			this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSearch.Enabled = false;
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSearch.Location = new System.Drawing.Point(718, 397);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(72, 22);
			this.btnSearch.TabIndex = 1;
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
			this.btntxtClear.Location = new System.Drawing.Point(640, 397);
			this.btntxtClear.Name = "btntxtClear";
			this.btntxtClear.Size = new System.Drawing.Size(72, 22);
			this.btntxtClear.TabIndex = 2;
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
			this.txtLongandLat.Enabled = false;
			this.txtLongandLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLongandLat.ForeColor = System.Drawing.Color.White;
			this.txtLongandLat.Location = new System.Drawing.Point(12, 430);
			this.txtLongandLat.Name = "txtLongandLat";
			this.txtLongandLat.Size = new System.Drawing.Size(781, 29);
			this.txtLongandLat.TabIndex = 6;
			this.txtLongandLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// webBrowser
			// 
			this.webBrowser.AllowNavigation = false;
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.Location = new System.Drawing.Point(15, 20);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.Size = new System.Drawing.Size(491, 310);
			this.webBrowser.TabIndex = 1;
			this.webBrowser.Url = new System.Uri("http://google.com/maps", System.UriKind.Absolute);
			// 
			// picBoxLogo
			// 
			this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
			this.picBoxLogo.BackgroundImage = global::Country_Information.Properties.Resources.Bull_Maque_Logo_3D_with_text;
			this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picBoxLogo.Location = new System.Drawing.Point(343, -19);
			this.picBoxLogo.Name = "picBoxLogo";
			this.picBoxLogo.Size = new System.Drawing.Size(145, 91);
			this.picBoxLogo.TabIndex = 8;
			this.picBoxLogo.TabStop = false;
			// 
			// grpGoogleSearch
			// 
			this.grpGoogleSearch.BackColor = System.Drawing.Color.Transparent;
			this.grpGoogleSearch.BackgroundImage = global::Country_Information.Properties.Resources.groupBox_Background;
			this.grpGoogleSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.grpGoogleSearch.Controls.Add(this.webBrowser);
			this.grpGoogleSearch.Enabled = false;
			this.grpGoogleSearch.ForeColor = System.Drawing.Color.Transparent;
			this.grpGoogleSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.grpGoogleSearch.Location = new System.Drawing.Point(12, 74);
			this.grpGoogleSearch.Name = "grpGoogleSearch";
			this.grpGoogleSearch.Size = new System.Drawing.Size(519, 345);
			this.grpGoogleSearch.TabIndex = 9;
			this.grpGoogleSearch.TabStop = false;
			// 
			// CountryInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Country_Information.Properties.Resources.World_Map_Background;
			this.ClientSize = new System.Drawing.Size(798, 485);
			this.Controls.Add(this.picBoxLogo);
			this.Controls.Add(this.grpGoogleSearch);
			this.Controls.Add(this.txtLongandLat);
			this.Controls.Add(this.btntxtClear);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtCountryName);
			this.Controls.Add(this.lstCountryInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CountryInformation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Country Information";
			this.Load += new System.EventHandler(this.CountryInformation_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
			this.grpGoogleSearch.ResumeLayout(false);
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
		private System.Windows.Forms.PictureBox picBoxLogo;
		private System.Windows.Forms.GroupBox grpGoogleSearch;
	}
}

