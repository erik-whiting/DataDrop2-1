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
        List<string> KeepVals = new List<string>();
        public List<DataPoint> AvailableDataPoints = new List<DataPoint>();
        List<Dictionary<string, string>> allAttributes = new List<Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
            string[] formats =
            {
                "--SELECT--",
                "JSON",
                "XML",
                "API",
                "Excel",
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
            
            var fileLocation = sourceFileTextBox.Text;
            var sourceFileType = SourceDataComboBox.Text;

            switch (sourceFileType)
            {
                case "JSON":
                    allAttributes = AttributesFromJson.GetJsonAttributes(fileLocation);
                    SetAttributesView(allAttributes);
                    break;
                case "Excel":
                    allAttributes = AttributesFromExcel.GetExcelAttributes(fileLocation);
                    SetAttributesView(allAttributes);
                    break;
                default:
                    break;
            }

            if (sourceFileType == "JSON")
            {
                allAttributes = AttributesFromJson.GetJsonAttributes(fileLocation);

                foreach (var item in allAttributes)
                {
                    if (!availableListBox.Items.Contains(item.First().Key))
                    {
                        availableListBox.Items.Add(item.First().Key);
                    }
                }
                
            }
            

        }

        private void SetAttributesView(List<Dictionary<string, string>> attributes)
        {
            foreach (var item in attributes)
            {
                if (!availableListBox.Items.Contains(item.First().Key))
                {
                    availableListBox.Items.Add(item.First().Key);
                }
            }
        }

        private void SetAttributesViewFromExcel(List<Dictionary<string, string>> attributes)
        {
            foreach (var item in attributes.First())
            {
                availableListBox.Items.Add(item.Key);
            }
        }

        private void Keep_Click(object sender, EventArgs e)
        {
            destinationAttributes.Items.Add(availableListBox.SelectedItem);
            KeepVals.Add(availableListBox.SelectedItem.ToString());
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            destinationAttributes.Items.Remove(destinationAttributes.SelectedItem);
            KeepVals.RemoveAll(x => x == destinationAttributes.SelectedItem.ToString());
            
        }

        private void generateFile_Click(object sender, EventArgs e)
        {
            string directory = Configuration.Directory();
            string destinationDataType = DestinationDataComboBox.Text;
            string fileName = DestinationFileNameTextBox.Text + SetFileExtension(destinationDataType);
            DataFormat dataFormat;
            switch (destinationDataType)
            {
                case "JSON":
                    dataFormat = new JSONDataFormat(destinationDataType);
                    dataFormat.DataPoints = SetDataPoints.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                case "XML":
                    break;
                case "API":
                    break;
                case "Database":
                    break;
                case "Excel":
                    dataFormat = new ExcelDataFormat(destinationDataType);
                    dataFormat.DataPoints = SetDataPoints.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                default:
                    dataFormat = new JSONDataFormat(destinationDataType);
                    break;
            }
        }

        private void SourceDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
  
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
                case "Excel":
                    dataType = ".xlsx";
                    break;
                default:
                    dataType = ".json";
                    break;
            }
            return dataType;
        }
    }
}
