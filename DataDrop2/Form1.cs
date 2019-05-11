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
                "SQL",
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
                case "XML":
                    allAttributes = AttributesFromXML.GetXMLAttributes(fileLocation);
                    SetAttributesView(allAttributes);
                    break;
                case "API":
                    string sourceUrl = ApiTextBox.Text;
                    allAttributes = AttributesFromApi.GetApiAttributes(sourceUrl);
                    SetAttributesView(allAttributes);
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

        private void SetAttributesViewFromXML(List<Dictionary<string, string>> attributes) 
        {
            foreach (var item in attributes.Select(x => x.Keys))
            {
                if (!availableListBox.Items.Contains(item.First()))
                {
                    availableListBox.Items.Add(item.First());
                }
            }
        }

        private void Keep_Click(object sender, EventArgs e)
        {
            if (availableListBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(availableListBox, "Please select atleast one attribute to add");
            }
            else
            {
                destinationAttributes.Items.Add(availableListBox.SelectedItem);
                KeepVals.Add(availableListBox.SelectedItem.ToString());
            }
        }

        private void Discard_Click(object sender, EventArgs e)
        {

            if (destinationAttributes.SelectedIndex == -1)
            {

                errorProvider1.SetError(destinationAttributes, "Please select atleast one attribute to remove");
            }
            else
            {
                var toDiscard = destinationAttributes.SelectedItem.ToString();
                destinationAttributes.Items.Remove(destinationAttributes.SelectedItem);
                KeepVals.Remove(toDiscard);
            }
            
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
                    dataFormat = new XMLDataFormat();
                    dataFormat.DataObjects = SetDataObjects.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                case "API":
                    break;
                case "SQL":
                    dataFormat = new SqlDataFormat();
                    dataFormat.DataObjects = SetDataObjects.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                case "Excel":
                    dataFormat = new ExcelDataFormat();
                    dataFormat.DataObjects = SetDataObjects.Set(allAttributes, KeepVals);
                    dataFormat.WriteToFile(directory, fileName);
                    break;
                case "Database":
                    var source = DbSourceText.Text;
                    var catalog = DbDatabaseText.Text;
                    var userName = DbUserNameText.Text;
                    var pass = DbPasswordText.Text;
                    dataFormat = new DBDataFormat(source, catalog, userName, pass);
                    StatusLabel.Text = new DBDataFormat(source, catalog, userName, pass).DB.Status;
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
            if (SourceDataComboBox.Text == "API")
            {
                ApiTextBox.Enabled = true;
                // For Testing:
                ApiTextBox.Text = "http://ewhiting.eastus.cloudapp.azure.com/midterm/Classes/Genre/read.php"; 
            }
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
                case "SQL":
                    dataType = ".sql";
                    label3.Text = "Table name (file will be date + table name)";
                    break;
                case "Excel":
                    dataType = ".xlsx";
                    label3.Text = message;
                    break;
                case "Database":
                    label3.Text = "Target table";
                    DbConnectSection.Enabled = true;
                    var DefaultSource = Environment.MachineName;
                    DbSourceText.Text = DefaultSource;
                    // For testing
                    DbDatabaseText.Text = "LearningTest";
                    DbUserNameText.Text = "erik_example";
                    DbPasswordText.Text = "abc123";
                    break;
                default:
                    dataType = ".json";
                    label3.Text = message;
                    break;
            }
            return dataType;
        }

        public void SetDbOptions()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            availableListBox.Items.Clear();
        }
    }
}
