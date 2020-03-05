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
		
		// Global
		string[] Countries = new string[243];
		string[] Latitude = new string[243];
		string[] Longitude = new string[243];
		

		private void CountryInformation_Load(object sender, EventArgs e)
		{


			// Load characters from csv file to listbox
			LoadCountries();

			// Print CSV into array
			PrintArrayContents();

		}

		private void PrintArrayContents()
		{
			// Print array to listbox
			foreach (string Countries in Countries)
			{
				lstCountryInfo.Items.Add(Countries);
				txtCountryName.AutoCompleteCustomSource.Add(Countries);
			}
				
		}


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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Find country after user types
			int index = lstCountryInfo.FindString(txtCountryName.Text, -1);
			if (index != -1)
			{
				lstCountryInfo.SetSelected(index, true);
				DialogResult dialogResult = MessageBox.Show("Is this the country you were searching for?", "Are you sure?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					btnSearch.Enabled = false;


				}
				else if (dialogResult == DialogResult.No)
				{
					
				}
			}
			else
			{
				// Show message to user if input is not a valid character
				MessageBox.Show("Country not found, try again!", "Error: Country Invalid.");
				txtCountryName.Clear();

			}


		}

		private void btntxtClear_Click(object sender, EventArgs e)
		{
			// Clear contents in text box
			txtCountryName.Clear();
			lstCountryInfo.ClearSelected();

			txtLongandLat.Clear();

			lstCountryInfo.SelectedItem = null;

		}

		private void txtCountryName_TextChanged(object sender, EventArgs e)
		{
			// Make sure that textbox is full to enable buttons.
			btnSearch.Enabled = !string.IsNullOrEmpty(txtCountryName.Text);
			btntxtClear.Enabled = !string.IsNullOrEmpty(txtCountryName.Text);

		}

		private void lstCountryInfo_Click(object sender, EventArgs e)
		{
			
		}

		private void lstCountryInfo_DoubleClick(object sender, EventArgs e)
		{
			if (lstCountryInfo.SelectedItem !=null)
			{
				string url = lstCountryInfo.SelectedItem.ToString();
				webBrowser.Navigate("http://google.com/maps/search/" + lstCountryInfo.SelectedItem.ToString());

				txtLongandLat.Text = "Latitude: " + Latitude + " Longitude: " + Longitude.ToString();
			}
			
		}

		private void txtCountryName_Click(object sender, EventArgs e)
		{
			txtCountryName.Text = null;

			lstCountryInfo.SelectedItem = null;
		}

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



