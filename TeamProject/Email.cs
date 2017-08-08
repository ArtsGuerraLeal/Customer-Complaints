using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace TeamProject
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        public List<Customer> storageList = new List<Customer>();
        public string prefix;

        public Email(List<Customer> inputList)
        {
            storageList = inputList;
            InitializeComponent();
        }
        private void Email_Load(object sender, EventArgs e)
        {



        }
        private void sendEmail()
        {
            if (txtTo.Text == "")
            {
                MessageBox.Show("Please enter a valid email");

            }
            else if (cmbTypes.Text == "")
            {
                MessageBox.Show("Please enter a valid reason");

            }


            try
            {
                if (txtTo.Text != "" && cmbTypes.Text != "")
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("arturoguerra.mis4321@gmail.com");
                    mail.To.Add(txtTo.Text);
                    mail.Subject = txtSubject.Text;
                    mail.Body = txtBody.Text;
                    if (cmbTypes.Text == "Coupon")
                    {
                        mail.Attachments.Add(new Attachment("Coupon.PNG"));
                    }
                    else if (cmbTypes.Text == "Newsletter")
                    {
                        mail.Attachments.Add(new Attachment("newsletter.jpg"));
                    }
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("arturoguerra.mis4321@gmail.com", "mis4321#");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTestCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string lookupPattern;
            int Patternlen;
            List<Customer> foundCustomers;

            lblResultFiltered.Text = "Results: ";

            //Get the lookup pattern & its length
            lookupPattern = txtSearchLastName.Text;
            Patternlen = lookupPattern.Length;

            //Find all schools that meet the pattern (and store these in a new List)
            foundCustomers = storageList.FindAll(cst => cst.LastName == lookupPattern);


            dgvTestCustomers.DataSource = null;
            dgvTestCustomers.DataSource = foundCustomers;

            foreach (Customer cust in foundCustomers)
            {


            }
        }

        private void btnSendEmail_Click_1(object sender, EventArgs e)
        {
            sendEmail();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtSearchLastName.Text = "";
            dgvTestCustomers.DataSource = null;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (dgvTestCustomers.Rows.Count >0)
            {
                int rowIndex;

                rowIndex = dgvTestCustomers.CurrentCell.ColumnIndex;

                if (rowIndex != -1)
                {
                    txtTo.Text = dgvTestCustomers.Rows[rowIndex].Cells[10].Value.ToString();
                    txtCustomerID.Text = dgvTestCustomers.Rows[rowIndex].Cells[0].Value.ToString();
                    txtFirstName.Text = dgvTestCustomers.Rows[rowIndex].Cells[1].Value.ToString();
                    txtLastName.Text = dgvTestCustomers.Rows[rowIndex].Cells[2].Value.ToString();
                }
            }

        }

        private void cmbTypes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTypes.Text == "Coupon")
            {
                txtBody.ReadOnly = true;
                txtSubject.ReadOnly = true;
                txtSubject.Text = "A coupon for you!";
                txtBody.Text = "Dear " + prefix + " " + txtLastName.Text + ", \n We would like to present to you this coupon! I hope you keep cleaning with us!\n\n Sincerely, Baylor Dry Cleaning";
            }
            else if (cmbTypes.Text == "Apology")
            {
                txtBody.ReadOnly = true;
                txtSubject.ReadOnly = true;
                txtSubject.Text = "We're Sorry!";
                txtBody.Text = "Dear " + prefix + " " + txtLastName.Text + ", \n We would like to apologize to you as we have made a mistake with your order. Please contact us if there is anything we can do.\n\n Sincerely, Baylor Dry Cleaning";
            }
            else if (cmbTypes.Text == "Thank You")
            {
                txtBody.ReadOnly = true;
                txtSubject.ReadOnly = true;
                txtSubject.Text = "We're Sorry!";
                txtBody.Text = "Dear " + prefix + " " + txtLastName.Text + ", \n We would like to thank you for being such a loyal customer. \n\n Sincerely, Baylor Dry Cleaning";
            }
            else if (cmbTypes.Text == "Newsletter")
            {
                txtBody.ReadOnly = true;
                txtSubject.ReadOnly = true;
                txtSubject.Text = "Monthly Newsletter!";
                txtBody.Text = "Dear " + prefix + " " + txtLastName.Text + ", \n Here is a copy of out monthly newsletter. \n\n Sincerely, Baylor Dry Cleaning";
            }
            else if (cmbTypes.Text == "Order Update")
            {
                txtBody.ReadOnly = true;
                txtSubject.ReadOnly = true;
                txtSubject.Text = "Monthly Newsletter!";
                txtBody.Text = "Dear " + prefix + " " + txtLastName.Text + ", \n Your order has been changed. \n\n Sincerely, Baylor Dry Cleaning";
            }
            else if (cmbTypes.Text == "Custom")
            {
                txtBody.ReadOnly = false;
                txtSubject.ReadOnly = false;
                txtSubject.Text = "Type subject here";
                txtBody.Text = "Type message here";
                txtSubject.Focus();
            }
        }
    }
}
