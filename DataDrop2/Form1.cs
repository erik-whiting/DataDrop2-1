using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using DataDrop2.Methods;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DataDrop2
{
    public partial class Form1 : Form
    {
        List<string> SourceFormats = new List<string>();
        List<string> DestinationFormats = new List<string>();

        public Form1()
        {
            InitializeComponent();
            string[] formats =
            {
                "--SELECT--",
                "JSON",
                "XML",
                "API",
                "Database"
            };

            foreach (var format in formats)
            {
                SourceFormats.Add(format);
                DestinationFormats.Add(format);
            }

            SourceDataComboBox.DataSource = SourceFormats;
            SourceDataComboBox.DisplayMember = "DocumentType";
            DestinationDataComboBox.DataSource = DestinationFormats;
            DestinationDataComboBox.DisplayMember = "DocumentType";

        }

        private void SourceDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSourceFormat = (DataFormat)SourceDataComboBox.SelectedItem;
            selectedSourceFormat.IsSource = true;
        }

        private void DestinationDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDestinationFormat = (DataFormat)DestinationDataComboBox.SelectedItem;
            selectedDestinationFormat.IsDestination = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openSource_Click(object sender, EventArgs e)
        {
            if (sourceFile.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(sourceFile.FileName);
                sourceFileTextBox.Text = sourceFile.FileName;
            }
        }

        private void showAttributes_Click(object sender, EventArgs e)
        {
            var x = new List<Dictionary<string, string>> ();
            var fileLocation = sourceFileTextBox.Text;
            var loadedJson = new LoadJSON(fileLocation);
            foreach (var item in loadedJson.JsonObject.Children())
            {
                JsonSerializer serializer = new JsonSerializer();
                var itemDict = new Dictionary<string, string>();
                itemDict.Add(item.Path, item.First.ToString());
                x.Add(itemDict);
            }

            foreach (var item in x)
            {
                availableListBox.Items.Add(item.First().Key);
            }

        }

        private void Keep_Click(object sender, EventArgs e)
        {
            destinationAttributes.Items.Add(availableListBox.SelectedItem);
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            destinationAttributes.Items.Remove(destinationAttributes.SelectedItem);
        }
    }
}
