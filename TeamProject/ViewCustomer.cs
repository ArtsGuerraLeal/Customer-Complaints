using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TeamProject
{

    public partial class ViewCustomer : Form
    {
        int selectedindex;
        public List<Customer> storageList = new List<Customer>();

        public ViewCustomer(List<Customer> inputList, int index)
        {
            storageList = inputList;
            selectedindex = index;
            InitializeComponent();
            bndSourceCust.DataSource = storageList;
            bndNavCust.BindingSource = bndSourceCust;
                      
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save changes before closing?", "Suggestion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                SaveListToFile();
                this.Close();
            }
            else if (dr == DialogResult.No)
            {
                this.Close();
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewCustomer();
        }

        private void AddNewCustomer()
        {
            Customer c = new Customer();
            c.CustomerID = Convert.ToInt32(txtCustID.Text);
            c.LastName = txtLastName.Text;
            c.FirstName = txtFirstName.Text;
            c.Prefix = cmbPrefix.Text;
            c.Gender = txtGender.Text;
            c.Address = txtAddress.Text;
            c.City = txtCity.Text;
            c.State = txtState.Text;
            c.Zip = Convert.ToInt32(txtZip.Text);
            c.Phone = txtPhone.Text;
            c.Email = txtEmail.Text;

            storageList.Add(c);

            dgvTestCustomers.DataSource = null;
            dgvTestCustomers.DataSource = storageList;
        }

        private void UpdateNewCustomer()
        {
            Customer c = new Customer();           
            c.CustomerID = Convert.ToInt32(txtCustID.Text);
            c.LastName = txtLastName.Text;
            c.FirstName = txtFirstName.Text;
            c.Prefix = cmbPrefix.Text;
            c.Gender = txtGender.Text;
            c.Address = txtAddress.Text;
            c.City = txtCity.Text;
            c.State = txtState.Text;
            c.Zip = Convert.ToInt32(txtZip.Text);
            c.Phone = txtPhone.Text;
            c.Email = txtEmail.Text;

            dgvTestCustomers.DataSource = null;
            dgvTestCustomers.DataSource = storageList;

            storageList[selectedindex] = c;

        }

        private void SaveListToFile()
        {
            
            string outputStr = "";
            const string DELIM = ","; 

           
            FileStream fs = new FileStream("Customers.csv", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            
            foreach (Customer c in storageList)
            {
                outputStr = c.CustomerID + DELIM +
                    c.LastName + DELIM +
                    c.FirstName + DELIM +
                    c.Prefix + DELIM +
                    c.Gender + DELIM +
                    c.Address + DELIM +
                    c.City + DELIM +
                    c.State + DELIM +
                    c.Zip + DELIM +
                    c.Phone + DELIM +
                    c.Email;
                writer.WriteLine(outputStr);
            }

            writer.Close();
            fs.Close();     
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateNewCustomer();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            selectedindex++;
            Customer c = new Customer();
            c = storageList[selectedindex];

            txtCustID.Text = c.CustomerID.ToString();
            txtLastName.Text = c.LastName;
            txtFirstName.Text = c.FirstName;
            cmbPrefix.Text = c.Prefix;
            txtGender.Text = c.Gender;
            txtAddress.Text = c.Address;
            txtZip.Text = c.Zip.ToString();
            txtCity.Text = c.City;
            txtState.Text = c.State;
            txtPhone.Text = c.Phone;
            txtEmail.Text = c.Email;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (selectedindex > 0)
            {
                selectedindex--;
                Customer c = new Customer();
                c = storageList[selectedindex];

                txtCustID.Text = c.CustomerID.ToString();
                txtLastName.Text = c.LastName;
                txtFirstName.Text = c.FirstName;
                cmbPrefix.Text = c.Prefix;
                txtGender.Text = c.Gender;
                txtAddress.Text = c.Address;
                txtZip.Text = c.Zip.ToString();
                txtCity.Text = c.City;
                txtState.Text = c.State;
                txtPhone.Text = c.Phone;
                txtEmail.Text = c.Email;
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            
            Customer c = new Customer();
            selectedindex = storageList.Count - 1;

            c = storageList[selectedindex];
       
            txtCustID.Text = c.CustomerID.ToString();
            txtLastName.Text = c.LastName;
            txtFirstName.Text = c.FirstName;
            cmbPrefix.Text = c.Prefix;
            txtGender.Text = c.Gender;
            txtAddress.Text = c.Address;
            txtZip.Text = c.Zip.ToString();
            txtCity.Text = c.City;
            txtState.Text = c.State;
            txtPhone.Text = c.Phone;
            txtEmail.Text = c.Email;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            selectedindex = 0;
            Customer c = new Customer();
            c = storageList[selectedindex];
            txtCustID.Text = c.CustomerID.ToString();
            txtLastName.Text = c.LastName;
            txtFirstName.Text = c.FirstName;
            cmbPrefix.Text = c.Prefix;
            txtGender.Text = c.Gender;
            txtAddress.Text = c.Address;
            txtZip.Text = c.Zip.ToString();
            txtCity.Text = c.City;
            txtState.Text = c.State;
            txtPhone.Text = c.Phone;
            txtEmail.Text = c.Email;                       
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            dgvTestCustomers.DataSource = storageList;        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            DialogResult dr = MessageBox.Show("Do you wish to save changes?", "Suggestion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                SaveListToFile();
            }
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            dgvTestCustomers.DataSource = null;
            dgvTestCustomers.DataSource = storageList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }



        private void DeleteCustomer()
        {
            
            DialogResult dr = MessageBox.Show("Do you wish to delete this record?", "Suggestion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                storageList.Remove(storageList[selectedindex]);

                dgvTestCustomers.DataSource = null;
                dgvTestCustomers.DataSource = storageList;

                bndSourceCust.MovePrevious();
                bndSourceCust.ResetItem(selectedindex);

                if (selectedindex > 0)
                {
                    bndNavCust.Refresh();
                    selectedindex--;
                    Customer c = new Customer();
                    c = storageList[selectedindex];
                    txtCustID.Text = c.CustomerID.ToString();
                    txtLastName.Text = c.LastName;
                    txtFirstName.Text = c.FirstName;
                    cmbPrefix.Text = c.Prefix;
                    txtGender.Text = c.Gender;
                    txtAddress.Text = c.Address;
                    txtZip.Text = c.Zip.ToString();
                    txtCity.Text = c.City;
                    txtState.Text = c.State;
                    txtPhone.Text = c.Phone;
                    txtEmail.Text = c.Email;
                }
                else
                {
                    
                    Customer c = new Customer();
                    c = storageList[selectedindex];
                    txtCustID.Text = c.CustomerID.ToString();
                    txtLastName.Text = c.LastName;
                    txtFirstName.Text = c.FirstName;
                    cmbPrefix.Text = c.Prefix;
                    txtGender.Text = c.Gender;
                    txtAddress.Text = c.Address;
                    txtZip.Text = c.Zip.ToString();
                    txtCity.Text = c.City;
                    txtState.Text = c.State;
                    txtPhone.Text = c.Phone;
                    txtEmail.Text = c.Email;
                }
                

            }

        }

        private void dgvTestCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            bindingNavigatorPositionItem.Text = (dgvTestCustomers.CurrentCell.RowIndex + 1).ToString();

            Customer c = new Customer();

            c = storageList[dgvTestCustomers.CurrentCell.RowIndex];

            txtCustID.Text = c.CustomerID.ToString();
            txtLastName.Text = c.LastName;
            txtFirstName.Text = c.FirstName;
            cmbPrefix.Text = c.Prefix;
            txtGender.Text = c.Gender;
            txtAddress.Text = c.Address;
            txtZip.Text = c.Zip.ToString();
            txtCity.Text = c.City;
            txtState.Text = c.State;
            txtPhone.Text = c.Phone;
            txtEmail.Text = c.Email;

            */
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
