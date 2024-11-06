using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SQS_Operator_list_getter
{
    public partial class mainForm : Form
    {


        string currentSourcePath = @"C:\ProgramData\Atlas Copco\SQS\LBMS\modulexml\Worker.xml";
        string currentOutputPath = @"C:\Temp";
        //string currentOutputPath = string.Empty;// @"C\Temp";

        SynatecLbMessage workerXML;

        public mainForm()
        {
            InitializeComponent();
            workerXML = new SynatecLbMessage();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
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

        public SynatecLbMessage getXMLData<SynatecLbMessage>(string xmlFilePath)
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

                consoleTextBox.Text += "Deserialize done";

                return xmlFinal;
            }
        }

        public void WriteToCsv(SynatecLbMessage xmlWorker, string csvFilePath)
        {
            StringBuilder csvContent = new StringBuilder();

            // Add headers
            csvContent.AppendLine("Name,id");  // Replace with your actual headers

            // Add data
            foreach (var group in xmlWorker.Message.Data.Keys.subGroups)   //ElementAt(0).group.ElementAt(0).Parameter)  // Replace with your actual data structure
            {
                foreach (var subgroup in group.subGroups)
                {
                    foreach (var parameter in subgroup.Parameter)
                    {
                        csvContent.AppendLine($"{parameter.Text},{parameter.Id}");
                    }
                }
            }

            consoleTextBox.Text += "Write to CSV done at path: \r\n" + csvFilePath;
            File.WriteAllText(csvFilePath + "\\Xml-outrput.csv", csvContent.ToString());
        }

        public bool NeedsEncodingCorrection(string input)
        {
            // List of characters that are commonly misinterpreted in a different encoding
            string[] misinterpretedCharacters = new string[] { "Ã", "©", "ª", "«", "¬", "®", "¯", "°", "±", "²", "³", "´", "µ",
                "¶", "·", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì",
                "Í", "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â",
                "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "÷", "ø",
                "ù", "ú", "û", "ü", "ý", "þ", "ÿ" };

            foreach (string character in misinterpretedCharacters)
            {
                if (input.Contains(character))
                {
                    return true;
                }
            }

            return false;
        }

        public string CorrectEncoding(string input)
        {
            byte[] bytes = Encoding.Default.GetBytes(input);
            return Encoding.GetEncoding("Windows-1252").GetString(bytes);
        }

        private void getOperatorListButton_Click(object sender, EventArgs e)
        {
            workerXML = getXMLData<SynatecLbMessage>(currentSourcePath);

            WriteToCsv(workerXML, currentOutputPath);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }


        private void checkCurrentDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(currentSourcePath))
            {
                consoleTextBox.Text += "+OK Current path: \r\n" + currentSourcePath + "\r\n";
            }
            else
            {
                if (currentSourcePath == "")
                {
                    consoleTextBox.Text += "Current path EMPTY! \r\n";
                }
                else
                {
                    consoleTextBox.Text += "-----NOK Current path: \r\n" + currentSourcePath + "\r\n";
                }
            }

        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consoleTextBox.Text = string.Empty;
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentSourcePath = ChooseFolder();

            consoleTextBox.Text += "New source path: \r\n" + currentSourcePath + "\r\n";
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentOutputPath = ChooseFolder();

            consoleTextBox.Text += "New output path: \r\n" + currentOutputPath + "\r\n";
        }
    }
}
