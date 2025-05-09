using System.Data;
using System.Data.SqlClient;
using OfficeOpenXml;  // EPPlus for reading Excel



namespace AndroidDataExtractorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\AndroidData\contacts.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("contacts.txt not found.");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("PhoneNumber");

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.StartsWith("Row")) continue; // Skip metadata

                if (line.Contains("display_name=") && line.Contains("number="))
                {
                    string name = ExtractValue(line, "display_name=");
                    string number = ExtractValue(line, "number=");

                    dt.Rows.Add(name, number);
                }
            }

            dataGridContacts.DataSource = dt;
        }

        // Helper function to extract values from a key-value format
        private string ExtractValue(string line, string key)
        {
            int start = line.IndexOf(key);
            if (start == -1) return "";

            start += key.Length;
            int end = line.IndexOf(" ", start);
            if (end == -1) end = line.Length;

            return line.Substring(start, end - start).Trim();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\AndroidData\sms_messages.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("sms_messages.txt not found.");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Sender");
            dt.Columns.Add("Message");

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.StartsWith("Row")) continue;

                if (line.Contains("address=") && line.Contains("body="))
                {
                    string sende = ExtractValue(line, "address=");
                    string message = ExtractValue(line, "body=");
                    dt.Rows.Add(sender, message);
                }
            }

            dataGridSMS.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\AndroidData\call_logs.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("call_logs.txt not found.");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Number");
            dt.Columns.Add("Type");
            dt.Columns.Add("Duration");

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.StartsWith("Row")) continue;

                if (line.Contains("number=") && line.Contains("type=") && line.Contains("duration="))
                {
                    string number = ExtractValue(line, "number=");
                    string type = ExtractValue(line, "type=");
                    string duration = ExtractValue(line, "duration=");
                    dt.Rows.Add(number, type, duration);
                }
            }

            dataGridCalls.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

