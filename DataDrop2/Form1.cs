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
                    SetAttributesViewFromExcel(fileLocation);
                    break;
                default:
                    break;
            }


            

        }

        private void SetAttributesView(List<Dictionary<string, string>> attributes)
        {
            foreach (var item in attributes.FirstOrDefault())
            {
                if (!availableListBox.Items.Contains(item.Key))
                {
                    availableListBox.Items.Add(item.Key);
                }
            }
        }

        private void SetAttributesViewFromExcel(string fileLocation)
        {
            var attributes = AttributesFromExcel.GetHeaders(fileLocation);
            foreach (var item in attributes)
            {
                availableListBox.Items.Add(item);
            }
        }

        private void Keep_Click(object sender, EventArgs e)
        {
            destinationAttributes.Items.Add(availableListBox.SelectedItem);
            KeepVals.Add(availableListBox.SelectedItem.ToString());
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            var toDiscard = destinationAttributes.SelectedItem.ToString();
            destinationAttributes.Items.Remove(destinationAttributes.SelectedItem);
            KeepVals.Remove(toDiscard);
            
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
                    dataFormat = new JSONDataFormat();
                    dataFormat.DataObjects = SetDataObjects.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                case "XML":
                    break;
                case "API":
                    break;
                case "Database":
                    dataFormat = new SqlDataFormat();
                    dataFormat.DataObjects = SetDataObjects.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                case "Excel":
                    dataFormat = new ExcelDataFormat();
                    dataFormat.DataObjects = SetDataObjects.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                default:
                    dataFormat = new JSONDataFormat();
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
            string message = "Destination File Name";
            switch (selected)
            {
                case "JSON":
                    dataType = ".json";
                    label3.Text = message;
                    break;
                case "XML":
                    dataType = ".xml";
                    label3.Text = message;
                    break;
                case "API":
                    dataType = "In Development";
                    label3.Text = message;
                    break;
                case "Database":
                    dataType = ".sql";
                    label3.Text = "Table name (file will be date + table name)";
                    break;
                case "Excel":
                    dataType = ".xlsx";
                    label3.Text = message;
                    break;
                default:
                    dataType = ".json";
                    label3.Text = message;
                    break;
            }
            return dataType;
        }
    }
}
