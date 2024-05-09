using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SQS_Operator_list_getter
{
    public partial class mainForm : Form
    {
        string currentPath = string.Empty;
        string xmlFilePath = "C:\\Temp\\Worker.xml";

        
        public mainForm()
        {
            InitializeComponent();

        }


        public string ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            else
            {
                return null;
            }
        }
        
        private SynatecLbMessage getXMLData(string xmlFilePath)
        {
            byte[] bytes = File.ReadAllBytes(xmlFilePath);
            byte[] bom = new byte[] { 0xEF, 0xBB, 0xBF };  // UTF-8 BOM

            if (bytes.Take(bom.Length).SequenceEqual(bom))  // If file starts with BOM
            {
                bytes = bytes.Skip(bom.Length).ToArray();  // Remove BOM
            }

            string xmlText = Encoding.UTF8.GetString(bytes);
            string xmlDeclaration = "<?xml version='1.0' encoding='UTF-8'?>";

            xmlText = xmlText.TrimStart();  // Remove spaces and newlines at the start

            if (xmlText.StartsWith(xmlDeclaration))
            {
                xmlText = xmlText.Substring(xmlDeclaration.Length);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(SynatecLbMessage));

            using (StringReader reader = new StringReader(xmlText))
            {
                var xmlFinal = (SynatecLbMessage)serializer.Deserialize(reader);

                return xmlFinal;

                
            }
        }

        private void getOperatorListButton_Click(object sender, EventArgs e)
        {


            //consoleTextBox.Text = xmlFinal.Message.Data.Group.group.ElementAt(0).group.ElementAt(0).Parameter.ElementAt(0).Text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void configureDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPath = ChooseFolder();

            consoleTextBox.Text += "New current path: \r\n" + currentPath + "\r\n";
        }

        private void checkCurrentDirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(currentPath))
            {
                consoleTextBox.Text += "+OK Current path: \r\n" + currentPath + "\r\n";
            }
            else
            {
                if (currentPath == "")
                {
                    consoleTextBox.Text += "Current path EMPTY! \r\n";
                }
                else
                {
                    consoleTextBox.Text += "-----NOK Current path: \r\n" + currentPath + "\r\n";
                }
            }

        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consoleTextBox.Text = string.Empty;
        }
    }
}
