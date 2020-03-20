using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Text;
using System.Media;


namespace Country_Information
{
	/* Name: Reggie Telemaque  * Date: 02/29/2020
     *  
     * 
     * MIDTERM: Country Information 

     * 
     *  Purpose: A program that a user can find a countries longitude and latitude by putting in the name of the country itself by way of a textbox.
     */

	public partial class CountryInformation : Form
	{
		public CountryInformation()
		{
			InitializeComponent();
		}

		// Global variables. 
		string[] Countries = new string[243];
		string[] Latitude = new string[243];
		string[] Longitude = new string[243];

	/// <summary>
	/// Load event that references csv file to listbox and prints array contents.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
		private void CountryInformation_Load(object sender, EventArgs e)
		{

			// Load characters from csv file to listbox
			LoadCountries();

			// Print CSV into array
			PrintArrayContents();


		}

		/// <summary>
		/// Method to print array contents to listbox. 
		/// </summary>
		private void PrintArrayContents()
		{
			// Print array to listbox
			foreach (string Countries in Countries)
			{
				lstCountryInfo.Items.Add(Countries);
				//txtCountryName.AutoCompleteCustomSource.Add(Countries);
			}

		}

		/// <summary>
		/// Method to load countries from file to push, and split them to an array.
		/// </summary>
		private void LoadCountries()
		{
			// Read and open CSV into index.
			StreamReader inputFileReader = File.OpenText("CountryInfo.csv");
			int index = 0;
			string[] data;

			while (!inputFileReader.EndOfStream)
			{
				data = inputFileReader.ReadLine().Split(',');
				Countries[index] = data[0];
				Latitude[index] = data[1];
				Longitude[index] = data[2];

				index++;

			}
			inputFileReader.Close();
			inputFileReader.Dispose();
		}
		
		/// <summary>
		/// Method for when a country is searched to get validate if the user wanted that country selected. 
		/// </summary>
		private void CountrySearch()
		{
			// 
			bool CountryWasFound = false;
			for (int index = lstCountryInfo.Items.Count - 1; index >= 0; index--)
			{
				if (lstCountryInfo.Items[index].ToString().Contains(txtCountryName.Text))
				{
					// Searches index
					lstCountryInfo.SetSelected(index, true);
					
					// Shows a message box yes or no to make sure user wanted a country selected.
					DialogResult dialogResult = MessageBox.Show("Is this the country you were searching for?", "Are you sure?", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						btnSearch.Enabled = false;
						CountryWasFound = true;
						txtLongandLat.Text = ("Latitude: " + Latitude[lstCountryInfo.SelectedIndex] + "  |  " + "Longitude: " + Longitude[lstCountryInfo.SelectedIndex]);
						grpGoogleSearch.Enabled = true;
						webBrowser.Navigate("http://google.com/maps/place/" + lstCountryInfo.SelectedItem.ToString() + "/@" + Longitude[lstCountryInfo.SelectedIndex] + "," + Latitude[lstCountryInfo.SelectedIndex] + "z");

						break;
					}
				}
			}
			// States if country was not found to clear.
			if (!CountryWasFound)
			{
				MessageBox.Show("Country was not found.","Error:");
				txtCountryName.Clear();
			}

		}

		/// <summary>
		/// Button search click when someone types country
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			CountrySearch();
		}
	
		/// <summary>
		/// Button clear for when user wants to get new information for another country
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btntxtClear_Click(object sender, EventArgs e)
		{
			// Clear contents in text box
			txtCountryName.Clear();
			lstCountryInfo.ClearSelected();
			txtLongandLat.Clear();
			lstCountryInfo.SelectedItem = null;
			grpGoogleSearch.Enabled = false;
			webBrowser.Navigate("http://google.com/maps");

		}

		/// <summary>
		/// Event for when when a countries text is changed. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtCountryName_TextChanged(object sender, EventArgs e)
		{
			// Make sure that textbox is full to enable buttons.
			btnSearch.Enabled = !string.IsNullOrEmpty(txtCountryName.Text);
			btntxtClear.Enabled = !string.IsNullOrEmpty(txtCountryName.Text);

			txtCountryName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtCountryName.Text);
			txtCountryName.Select(txtCountryName.MaxLength, 0);


		}

		/// <summary>
		/// Event for when a country is doubled clicked to give more info.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lstCountryInfo_DoubleClick(object sender, EventArgs e)
		{
			// Web browser so that the user can double click a item in listbox to get details from google.
			if (lstCountryInfo.SelectedItem !=null)
			{
				string url = lstCountryInfo.SelectedItem.ToString();
				webBrowser.Navigate("http://google.com/maps/place/" + lstCountryInfo.SelectedItem.ToString() + "/@" + Longitude[lstCountryInfo.SelectedIndex] + Latitude[lstCountryInfo.SelectedIndex] + "z");

				txtLongandLat.Text = "Latitude:" + Latitude[lstCountryInfo.SelectedIndex] + "  |  " + "Longitude:" + Longitude[lstCountryInfo.SelectedIndex];
				grpGoogleSearch.Enabled = true;

				btntxtClear.Enabled = true;
			
			}
			
		}

		/// <summary>
		/// Event for when search textbox is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtCountryName_Click(object sender, EventArgs e)
		{
			txtCountryName.Text = null;

			lstCountryInfo.SelectedItem = null;

			txtLongandLat.Text = null;

			webBrowser.Navigate("http://google.com/maps");

			grpGoogleSearch.Enabled = false;
		}

		/// <summary>
		/// Event for when certain keys are clicked to auto click buttons.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtCountryName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearch.PerformClick();
			}
			else if (e.KeyCode == Keys.Delete)
			{
				btntxtClear.PerformClick();
			}
		}
	}
}



