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
			foreach (string StarWarsCharacterList in PrintArray)
			{
				lstCountryInfo.Items.Add(StarWarsCharacterList);
				txtCountryName.AutoCompleteCustomSource.Add(StarWarsCharacterList);
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

		private void btnFind_Click(object sender, EventArgs e)
		{
			// Find character after user types
			int index = lstCountryInfo.FindString(txtCountryName.Text, -1);
			if (index != -1)
			{
				lstCountryInfo.SetSelected(index, true);
			}
			else
			{
				// Show message to user if input is not a valid character
				MessageBox.Show("Country not found, try again!", "Error: Character Invalid");
				txtCountryName.Clear();

			}
		}

		private void btntxtClear_Click(object sender, EventArgs e)
		{
			// Clear contents in text box
			txtCountryName.Clear();
			lstCountryInfo.ClearSelected();
		}

		private void txtCountryName_TextChanged(object sender, EventArgs e)
		{
			// Make sure that textbox is full to enable buttons.
			btnFind.Enabled = !string.IsNullOrEmpty(txtCountryName.Text);
			btntxtClear.Enabled = !string.IsNullOrEmpty(txtCountryName.Text);

		}
	}
}
