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

		private void CountryInformation_Load(object sender, EventArgs e)
		{
			// Make a array of 244 characters in locals
			string[] Countries = new string[244];
			// Load characters from csv file to listbox
			LoadCountries(ref Countries);

			// Print CSV into array
			PrintArrayContents(ref Countries);


		}
		private void PrintArrayContents(ref string[] PrintArray)
		{
			// Print array to listbox
			foreach (string Countries in PrintArray)
			{
				lstCountryInfo.Items.Add(Countries);
				txtCountryName.AutoCompleteCustomSource.Add(Countries);
			}

		}


		private void LoadCountries(ref string[] Countries)
		{
			// Read and open CSV into index.
			StreamReader inputFileReader = File.OpenText("CountryInfo.csv");
			int index = 0;
			while (!inputFileReader.EndOfStream)
			{
				Countries[index] = inputFileReader.ReadLine();
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
				DialogResult dialogResult = MessageBox.Show("Is this the country you were search for?", "Are you sure?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					// Nothing
					txtLongandLat.Text = lstCountryInfo.Text;
					btnSearch.Enabled = false;
					grpGoogleSearch.Enabled = true;

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

			grpGoogleSearch.Enabled = false;
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
			txtLongandLat.Text = lstCountryInfo.Text;
		}

		private void txtCountryName_Click(object sender, EventArgs e)
		{
			txtCountryName.Text = null;

			lstCountryInfo.SelectedItem = null;
			grpGoogleSearch.Enabled = false;
		}

	}
}



