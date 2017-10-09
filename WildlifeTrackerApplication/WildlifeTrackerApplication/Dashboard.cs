using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;


namespace WildlifeTrackerApplication
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            webBrowser1.Hide();
            lblStreet.Hide();
            lblCity.Hide();
            lblState.Hide();
            lblZip.Hide();
            txtStreet.Hide();
            txtCity.Hide();
            txtState.Hide();
            txtZipCode.Hide();
            btnMapIt.Hide();
            label2.Hide();
            label1.Hide();
            txtLat.Hide();
            txtLong.Hide();
            btnMapLatLong.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            comboBox1.Hide();
            button6.Hide();
            reportViewer1.Hide();           
        }       

        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.campaign_TableTableAdapter.Fill(this.campaign_TemplateDataSet.Campaign_Table);

            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();   
            webBrowser1.Show();
            lblStreet.Show();
            lblCity.Show();
            lblState.Show();
            lblZip.Show();
            txtStreet.Show();
            txtCity.Show();
            txtState.Show();
            txtZipCode.Show();
            btnMapIt.Show();
            label2.Show();
            label1.Show();
            txtLat.Show();
            txtLong.Show();
            btnMapLatLong.Show();

            label3.Hide();
            label4.Hide();
            label5.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            comboBox1.Hide();
            button6.Hide();
            reportViewer1.Hide();

            try
            {
                string street = string.Empty;
                string city = string.Empty;
                string state = string.Empty;
                string zip = string.Empty;

                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");

                if (txtStreet.Text != string.Empty)
                {
                    street = txtStreet.Text.Replace(' ', '+');
                    queryAddress.Append(street + ',' + '+');
                }

                if (txtCity.Text != string.Empty)
                {
                    city = txtCity.Text.Replace(' ', '+');
                    queryAddress.Append(city + ',' + '+');
                }

                if (txtState.Text != string.Empty)
                {
                    state = txtState.Text.Replace(' ', '+');
                    queryAddress.Append(state + ',' + '+');
                }

                if (txtZipCode.Text != string.Empty)
                {
                    zip = txtZipCode.Text.ToString();
                    queryAddress.Append(zip);
                }

                webBrowser1.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            webBrowser1.Hide();
            lblStreet.Hide();
            lblCity.Hide();
            lblState.Hide();
            lblZip.Hide();
            txtStreet.Hide();
            txtCity.Hide();
            txtState.Hide();
            txtZipCode.Hide();
            btnMapIt.Hide();
            label2.Hide();
            label1.Hide();
            txtLat.Hide();
            txtLong.Hide();
            btnMapLatLong.Hide();

            label3.Hide();
            label4.Hide();
            label5.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            comboBox1.Hide();
            button6.Hide();
            reportViewer1.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnMapIt_Click(object sender, EventArgs e)
        {            

        }

        private void btnMapLatLong_Click(object sender, EventArgs e)
        {
            if (txtLat.Text == string.Empty || txtLong.Text == string.Empty)
            {
                MessageBox.Show("Supply a latitude and longitude value", "Missing Data");
                return;
            }

            try
            {
                string lat = string.Empty;
                string lon = string.Empty;

                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");

                if (txtLat.Text != string.Empty)
                {
                    lat = txtLat.Text;
                    queryAddress.Append(lat + "%2C");
                }

                if (txtLong.Text != string.Empty)
                {
                    lon = txtLong.Text;
                    queryAddress.Append(lon);
                }

                webBrowser1.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            webBrowser1.Hide();
            lblStreet.Hide();
            lblCity.Hide();
            lblState.Hide();
            lblZip.Hide();
            txtStreet.Hide();
            txtCity.Hide();
            txtState.Hide();
            txtZipCode.Hide();
            btnMapIt.Hide();
            label2.Hide();
            label1.Hide();
            txtLat.Hide();
            txtLong.Hide();
            btnMapLatLong.Hide();

            label3.Show();
            label4.Show();
            label5.Show();
            dateTimePicker1.Show();
            dateTimePicker2.Show();
            comboBox1.Show();
            button6.Show();
            reportViewer1.Show();

        }
    }
}
