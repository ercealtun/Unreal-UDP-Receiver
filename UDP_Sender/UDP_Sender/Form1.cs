using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using System.Text;

namespace UDP_Sender
{
    public partial class Form1 : Form
    {
        // LOCATION FIXING VARIABLES
        int locationOfLabel = 1;
        int locationOfTextBox = 1;
        int textBoxListIndex = 0;


        // TEXTBOX LIST INITIALIZING
        List<TextBox> textBoxList = new List<TextBox>();

        // PARAMETERS CLASS INITIALIZING
        Parameters parameters = new Parameters();

        // UDP SENDER SERVER INITIALIZING
        UdpClient sender = new UdpClient();
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);

        bool isSent = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Click Methods


        private void sendAllButton_Click(object sender, EventArgs e)
        {
            string jsonedString = seperateAndSerializeData(textBoxList);
            sendOverUdp(jsonedString, endPoint);
        }

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = dropDownList.SelectedItem.ToString();

            addLabel(selectedItem);

            TextBox newTextBox = new TextBox();
            textBoxList.Add(newTextBox);
            addTextBox(textBoxList);
        }


        #endregion


        #region Adding Form Methods

        private System.Windows.Forms.Label addLabel(string selectedItemName)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Top = locationOfLabel * 30;
            label.Left = 50;
            label.Text = selectedItemName;
            label.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            locationOfLabel += 1;
            return label;
        }


        public System.Windows.Forms.TextBox addTextBox(List<TextBox> textBoxList)
        {
            this.Controls.Add(textBoxList[textBoxListIndex]);
            textBoxList[textBoxListIndex].Top = locationOfTextBox * 30;
            textBoxList[textBoxListIndex].Left = 150;
            locationOfTextBox++;
            return textBoxList[textBoxListIndex++];
        }

        #endregion

        private string seperateAndSerializeData(List<TextBox> textBoxList)
        {

            foreach (TextBox textBox in textBoxList)
            {
                string currentString = textBox.Text;

                float floatParam;
                bool boolParam;
                int intParam;


                // DATA SEPERATION
                if (int.TryParse(currentString, out intParam))
                {
                    parameters.intToSend.Add(intParam);
                }
                else if (bool.TryParse(currentString, out boolParam))
                {
                    parameters.boolToSend.Add(boolParam);
                }
                else if (float.TryParse(currentString, out floatParam))
                {
                    parameters.floatToSend.Add(floatParam);
                }
                else
                {
                    parameters.stringToSend.Add(currentString); // Typed data is already a string
                }


            }

            // SERIALIZING STRING TO JSON
            string jsonedString = JsonSerializer.Serialize(parameters);


            return jsonedString;


        }

        private void sendOverUdp(string jsonedString, IPEndPoint endPoint)
        {
            byte[] jsonByteData = Encoding.ASCII.GetBytes(jsonedString);
            sender.Send(jsonByteData, jsonByteData.Length, endPoint);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}