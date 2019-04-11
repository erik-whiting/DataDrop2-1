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
using DataDrop2.Models;

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

        private void generateFile_Click(object sender, EventArgs e)
        {
            string directory = Configuration.Directory();
            string fileName = DestinationFileNameTextBox.Text;
            //DataFormat dataFormat;
            //switch (destinationDataType)
            //{
            //    case "JSON":
            //        dataFormat = new JSONDataFormat(destinationDataType, false, true);
            //        break;
            //    case "XML":
            //        break;
            //    case "API":
            //        break;
            //    case "Database":
            //        break;
            //}
            //dataFormat.WriteToFile();
        }

        private void SourceDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //"JSON",
            //    "XML",
            //    "API",
            //    "Database"
            
        }

        private void DestinationDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string toDestinationFileType = DestinationDataComboBox.Text;
            FileExtensionLabel.Text = SetFileExtension(toDestinationFileType);
        }

        private string SetFileExtension(string selected)
        {
            string dataType = string.Empty;
            switch (selected)
            {
                case "JSON":
                    dataType = ".json";
                    break;
                case "XML":
                    dataType = ".xml";
                    break;
                case "API":
                    dataType = "In Development";
                    break;
                case "Database":
                    dataType = ".sql";
                    break;
                default:
                    dataType = ".json";
                    break;
            }
            return dataType;
        }
    }
}
