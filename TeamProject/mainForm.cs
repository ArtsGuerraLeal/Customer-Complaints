

using System;
using System.IO;
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
    public partial class mainForm : Form
    {
        List<string> loadedCust = new List<string>();
        List<Customer> LoadedComp = new List<Customer>();
            List<Customer> custList = new List<Customer>();
            List<Complaint> compList = new List<Complaint>();
            bool ascendingComp = true;
            bool ascendingCust = true;
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadCustomerListFromFile();
            LoadComplaintListFromFile();
        }

        private void DisplayCustomerData()
        {

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = custList;

            dgvCustomers.SuspendLayout();

            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tabController.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Pixel);

            foreach (DataGridViewColumn col in dgvCustomers.Columns)
            {
                // col.HeaderText = headerNames[col.Index];
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            dgvCustomers.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void DisplayComplaintData()
        {
            dgvComplaints.DataSource = null;
            dgvComplaints.DataSource = compList;


            dgvComplaints.SuspendLayout();

            //
            dgvComplaints.ReadOnly = true;
            dgvComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComplaints.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvComplaints.BackgroundColor = Color.White;
            dgvComplaints.BorderStyle = BorderStyle.None;
            dgvComplaints.AllowUserToAddRows = false;
            dgvComplaints.ScrollBars = System.Windows.Forms.ScrollBars.Both;

            foreach (DataGridViewColumn col in dgvComplaints.Columns)
            {
                // col.HeaderText = headerNames[col.Index];
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            dgvComplaints.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void LoadCustomerListFromFile()
        {
            string inputStr;               
            string[] CustRecIN;          
            const char DELIM = ',';         
            Customer aCust = new Customer(); 

            custList.Clear();

            FileStream fs = new FileStream("Customers.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            inputStr = reader.ReadLine();

            while (inputStr != null)
            {
                CustRecIN = inputStr.Split(DELIM);
                Customer c = new Customer();   
                c.CustomerID = Convert.ToInt32(CustRecIN[0]);
                c.LastName = CustRecIN[1];
                c.FirstName = CustRecIN[2];
                c.Prefix = CustRecIN[3];
                c.Gender = CustRecIN[4];
                c.Address = CustRecIN[5];
                c.City = CustRecIN[6];
                c.State = CustRecIN[7];
                c.Zip = Convert.ToInt32(CustRecIN[8]);
                c.Phone = CustRecIN[9];
                c.Email = CustRecIN[10];

                custList.Add(c);

                DisplayCustomerData();

                inputStr = reader.ReadLine();

            }

            //Close the StreamReader & FileStream objects
            reader.Close();
            fs.Close();
        }
        private void LoadComplaintListFromFile()
        {
            string inputStr;                //holds one record that was read in
            string[] CompRecIN;           //string array to hold ONE player record parsed/split
            const char DELIM = ',';         //NOTE: this must be a CHAR for the SPLIT() method used later
            Complaint aComp = new Complaint();  //create a player object 


            //Clear the players list
            compList.Clear();

            //Create the FileStream object
            FileStream fs = new FileStream("Complaints.csv", FileMode.Open, FileAccess.Read);


            //Create the StreamWriter object
            StreamReader reader = new StreamReader(fs);

            //LEAD READ - i.e. 1st record
            inputStr = reader.ReadLine();

            //WHILE: Loop through the file (until an empty record)
            while (inputStr != null)
            {
                //split the record that was read (into a String array)
                CompRecIN = inputStr.Split(DELIM);

                //create a new player object (each time it loops!)
                Complaint c = new Complaint();

                //Load the player object with the string array -playerRecIN[]   
                c.ComplaintNo = Convert.ToInt32(CompRecIN[0]);
                c.CustomerID = Convert.ToInt32(CompRecIN[1]);
                c.ComplaintType = CompRecIN[2];
                c.ComplaintDesc = CompRecIN[3];
                c.DateRecorded = Convert.ToDateTime(CompRecIN[4]);
                c.DateOccured = Convert.ToDateTime(CompRecIN[5]);
                c.CustExpectation = CompRecIN[6];
                c.Status = CompRecIN[7];
                if (CompRecIN[8] != "")
                {
                    c.ResolutionDate = Convert.ToDateTime(CompRecIN[8]);
                }
                c.ResolutionDesc = CompRecIN[9];



                //add the new player to the list
                compList.Add(c);

                //display the new player on the form
                DisplayComplaintData();

                //read the next record
                inputStr = reader.ReadLine();

            }

            //Close the StreamReader & FileStream objects
            reader.Close();
            fs.Close();
            //Clear any labels
        }

        private void dgvCustomers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCustomers.ClearSelection();
            string columnName = dgvCustomers.Columns[e.ColumnIndex].Name;

            if (ascendingCust)
            {
                if (columnName == "CustomerID")
                    custList = custList.OrderBy(nm => nm.CustomerID).ToList();

                if (columnName == "LastName")
                    custList = custList.OrderBy(nm => nm.LastName).ToList();

                if (columnName == "FirstName")
                    custList = custList.OrderBy(nm => nm.FirstName).ToList();

                if (columnName == "Prefix")
                    custList = custList.OrderBy(nm => nm.Prefix).ToList();

                if (columnName == "Gender")
                    custList = custList.OrderBy(nm => nm.Gender).ToList();

                if (columnName == "Address")
                    custList = custList.OrderBy(nm => nm.Address).ToList();

                if (columnName == "City")
                    custList = custList.OrderBy(nm => nm.City).ToList();

                if (columnName == "State")
                    custList = custList.OrderBy(nm => nm.State).ToList();

                if (columnName == "Zip")
                    custList = custList.OrderBy(nm => nm.Zip).ToList();

                if (columnName == "Phone")
                    custList = custList.OrderBy(nm => nm.Phone).ToList();

                if (columnName == "Email")
                    custList = custList.OrderBy(nm => nm.Email).ToList();
                ascendingCust = false;
            }
            else
            {
                if (columnName == "CustomerID")
                    custList = custList.OrderByDescending(nm => nm.CustomerID).ToList();

                if (columnName == "LastName")
                    custList = custList.OrderByDescending(nm => nm.LastName).ToList();

                if (columnName == "FirstName")
                    custList = custList.OrderByDescending(nm => nm.FirstName).ToList();

                if (columnName == "Prefix")
                    custList = custList.OrderByDescending(nm => nm.Prefix).ToList();

                if (columnName == "Gender")
                    custList = custList.OrderByDescending(nm => nm.Gender).ToList();

                if (columnName == "Address")
                    custList = custList.OrderByDescending(nm => nm.Address).ToList();

                if (columnName == "City")
                    custList = custList.OrderByDescending(nm => nm.City).ToList();

                if (columnName == "State")
                    custList = custList.OrderByDescending(nm => nm.State).ToList();

                if (columnName == "Zip")
                    custList = custList.OrderByDescending(nm => nm.Zip).ToList();

                if (columnName == "Phone")
                    custList = custList.OrderByDescending(nm => nm.Phone).ToList();

                if (columnName == "Email")
                    custList = custList.OrderByDescending(nm => nm.Email).ToList();
                ascendingCust = true;
            }
            DisplayCustomerData();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentCell.Selected)
            {
                ViewCustomer frm = new ViewCustomer(custList, dgvCustomers.CurrentCell.RowIndex);
                
                Customer c = new Customer();
                c = custList[dgvCustomers.CurrentCell.RowIndex];
                frm.txtCustID.Text = c.CustomerID.ToString();
                frm.txtLastName.Text = c.LastName;
                frm.txtFirstName.Text = c.FirstName;
                frm.cmbPrefix.Text = c.Prefix;
                frm.txtGender.Text = c.Gender;
                frm.txtAddress.Text = c.Address;
                frm.txtZip.Text = c.Zip.ToString();
                frm.txtCity.Text = c.City;
                frm.txtState.Text = c.State;
                frm.txtPhone.Text = c.Phone;
                frm.txtEmail.Text = c.Email;

                frm.ShowDialog();               
                custList = frm.storageList;
                DisplayCustomerData();
            }
            else if (dgvComplaints.CurrentCell.Selected)
            {

                ViewComplaint frm = new ViewComplaint(compList, dgvComplaints.CurrentCell.RowIndex);
                Complaint c = new Complaint();
                c = compList[dgvComplaints.CurrentCell.RowIndex];

                frm.txtCompNo.Text = c.ComplaintNo.ToString();
                frm.txtCustID.Text = c.CustomerID.ToString();
                frm.cmbCompType.Text = c.ComplaintType;
                frm.txtCompDesc.Text = c.ComplaintDesc;
                frm.dateRec.Value = c.DateRecorded;
                frm.dateOccured.Value = c.DateOccured;
                frm.cmbCustExp.Text = c.CustExpectation;
                frm.txtStatus.Text = c.Status;
                if (c.ResolutionDate > frm.dateResolution.MinDate)
                {
                    frm.dateResolution.Value = c.ResolutionDate;
                }
                else
                {
                    frm.dateResolution.Value = DateTime.Today;
                }
                frm.txtResolutionDesc.Text = c.ResolutionDesc;
                frm.ShowDialog();
                compList = frm.storageList;            
                DisplayComplaintData();
            }     
        }

        private void tabController_Selected(object sender, TabControlEventArgs e)
        {
            if (tabController.SelectedIndex == 0)
            {
                dgvComplaints.ClearSelection();
            }
            else if(tabController.SelectedIndex == 1) {
                dgvCustomers.ClearSelection();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadCustomerListFromFile();
            LoadComplaintListFromFile();
            CounterComp();
            CounterCust();
        }

        private void dgvCustomers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvCustomers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void dgvComplaints_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            dgvComplaints.ClearSelection();
            string columnName = dgvComplaints.Columns[e.ColumnIndex].Name;

            if (ascendingComp)
            {
                if (columnName == "ComplaintNo")
                    compList = compList.OrderBy(nm => nm.ComplaintNo).ToList();

                if (columnName == "CustomerID")
                    compList = compList.OrderBy(nm => nm.CustomerID).ToList();

                if (columnName == "ComplaintType")
                    compList = compList.OrderBy(nm => nm.ComplaintType).ToList();

                if (columnName == "ComplaintDesc")
                    compList = compList.OrderBy(nm => nm.ComplaintDesc).ToList();

                if (columnName == "DateRecorded")
                    compList = compList.OrderBy(nm => nm.DateRecorded).ToList();

                if (columnName == "DateOccured")
                    compList = compList.OrderBy(nm => nm.DateOccured).ToList();

                if (columnName == "CustExpectation")
                    compList = compList.OrderBy(nm => nm.CustExpectation).ToList();

                if (columnName == "Status")
                    compList = compList.OrderBy(nm => nm.Status).ToList();

                if (columnName == "ResolutionDate")
                    compList = compList.OrderBy(nm => nm.ResolutionDate).ToList();

                if (columnName == "ResolutionDesc")
                    compList = compList.OrderBy(nm => nm.ResolutionDesc).ToList();

                ascendingComp = false;
            }
            else {
                if (columnName == "ComplaintNo")
                    compList = compList.OrderByDescending(nm => nm.ComplaintNo).ToList();

                if (columnName == "CustomerID")
                    compList = compList.OrderByDescending(nm => nm.CustomerID).ToList();

                if (columnName == "ComplaintType")
                    compList = compList.OrderByDescending(nm => nm.ComplaintType).ToList();

                if (columnName == "ComplaintDesc")
                    compList = compList.OrderByDescending(nm => nm.ComplaintDesc).ToList();

                if (columnName == "DateRecorded")
                    compList = compList.OrderByDescending(nm => nm.DateRecorded).ToList();

                if (columnName == "DateOccured")
                    compList = compList.OrderByDescending(nm => nm.DateOccured).ToList();

                if (columnName == "CustExpectation")
                    compList = compList.OrderByDescending(nm => nm.CustExpectation).ToList();

                if (columnName == "Status")
                    compList = compList.OrderByDescending(nm => nm.Status).ToList();

                if (columnName == "ResolutionDate")
                    compList = compList.OrderByDescending(nm => nm.ResolutionDate).ToList();

                if (columnName == "ResolutionDesc")
                    compList = compList.OrderByDescending(nm => nm.ResolutionDesc).ToList();

                ascendingComp = true;
            }
            DisplayComplaintData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentCell.Selected)
            {
                Email frm = new Email(custList);
                Customer c = new Customer();
                c = custList[dgvCustomers.CurrentCell.RowIndex];
                frm.txtCustomerID.Text = c.CustomerID.ToString();
                frm.txtLastName.Text = c.LastName;
                frm.txtFirstName.Text = c.FirstName;
                frm.prefix = c.Prefix;
                frm.txtTo.Text = c.Email;
                frm.ShowDialog();
                DisplayCustomerData();
            }
        }

        private void Hiding()
        {
            //Customers page
            if (chkCustomerID.Checked)
                this.dgvCustomers.Columns[0].Visible = true;
            if (chkLast.Checked)
                this.dgvCustomers.Columns[1].Visible = true;
            if (chkFirst.Checked)
                this.dgvCustomers.Columns[2].Visible = true;
            if (chkPrefix.Checked)
                this.dgvCustomers.Columns[3].Visible = true;
            if (chkGender.Checked)
                this.dgvCustomers.Columns[4].Visible = true;
            if (chkAddress.Checked)
                this.dgvCustomers.Columns[5].Visible = true;
            if (chkCity.Checked)
                this.dgvCustomers.Columns[6].Visible = true;
            if (chkState.Checked)
                this.dgvCustomers.Columns[7].Visible = true;
            if (chkZip.Checked)
                this.dgvCustomers.Columns[8].Visible = true;
            if (chkPhone.Checked)
                this.dgvCustomers.Columns[9].Visible = true;
            if (chkEmail.Checked)
                this.dgvCustomers.Columns[10].Visible = true;
            //Complaints Page
            if (chkComplaint.Checked)
                this.dgvComplaints.Columns[0].Visible = true;
            if (chkCustomer.Checked)
                this.dgvComplaints.Columns[1].Visible = true;
            if (chkType.Checked)
                this.dgvComplaints.Columns[2].Visible = true;
            if (chkDescription.Checked)
                this.dgvComplaints.Columns[3].Visible = true;
            if (chkRecorded.Checked)
                this.dgvComplaints.Columns[4].Visible = true;
            if (chkOccured.Checked)
                this.dgvComplaints.Columns[5].Visible = true;
            if (chkExpectation.Checked)
                this.dgvComplaints.Columns[6].Visible = true;
            if (chkStatus.Checked)
                this.dgvComplaints.Columns[7].Visible = true;
            if (chkResolution.Checked)
                this.dgvComplaints.Columns[8].Visible = true;
            if (chkRDescription.Checked)
                this.dgvComplaints.Columns[9].Visible = true;
        }
        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.dgvCustomers.Columns[0].Visible = false;
            this.dgvCustomers.Columns[1].Visible = false;
            this.dgvCustomers.Columns[2].Visible = false;
            this.dgvCustomers.Columns[3].Visible = false;
            this.dgvCustomers.Columns[4].Visible = false;
            this.dgvCustomers.Columns[5].Visible = false;
            this.dgvCustomers.Columns[6].Visible = false;
            this.dgvCustomers.Columns[7].Visible = false;
            this.dgvCustomers.Columns[8].Visible = false;
            this.dgvCustomers.Columns[9].Visible = false;
            this.dgvCustomers.Columns[10].Visible = false;
            Hiding();
            CounterComp();
            CounterCust();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            this.dgvCustomers.Columns[0].Visible = true;
            this.dgvCustomers.Columns[1].Visible = true;
            this.dgvCustomers.Columns[2].Visible = true;
            this.dgvCustomers.Columns[3].Visible = true;
            this.dgvCustomers.Columns[4].Visible = true;
            this.dgvCustomers.Columns[5].Visible = true;
            this.dgvCustomers.Columns[6].Visible = true;
            this.dgvCustomers.Columns[7].Visible = true;
            this.dgvCustomers.Columns[8].Visible = true;
            this.dgvCustomers.Columns[9].Visible = true;
            this.dgvCustomers.Columns[10].Visible = true;
            chkCustomerID.Checked = false;
            chkLast.Checked = false;
            chkFirst.Checked = false;
            chkPrefix.Checked = false;
            chkGender.Checked = false;
            chkAddress.Checked = false;
            chkCity.Checked = false;
            chkState.Checked = false;
            chkZip.Checked = false;
            chkPhone.Checked = false;
            chkEmail.Checked = false;
            CounterComp();
            CounterCust();
        }

        private void tbSortCust_Click(object sender, EventArgs e)
        {

        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            tabController.SelectedTab = tabPage1;
            TabShow.SelectedTab = tbShowCust;
            TabSort.SelectedTab = tbSortCust;
            TabFilter.SelectedTab = tbFilterCust;
            CounterComp();
            CounterCust();
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            tabController.SelectedTab = tabPage2;
            TabShow.SelectedTab = tbShowComp;
            TabSort.SelectedTab = tbSortComp;
            TabFilter.SelectedTab = tbFilterComp;
            CounterComp();
            CounterCust();
        }

        private void btnApplycomp_Click(object sender, EventArgs e)
        {
            this.dgvComplaints.Columns[0].Visible = false;
            this.dgvComplaints.Columns[1].Visible = false;
            this.dgvComplaints.Columns[2].Visible = false;
            this.dgvComplaints.Columns[3].Visible = false;
            this.dgvComplaints.Columns[4].Visible = false;
            this.dgvComplaints.Columns[5].Visible = false;
            this.dgvComplaints.Columns[6].Visible = false;
            this.dgvComplaints.Columns[7].Visible = false;
            this.dgvComplaints.Columns[8].Visible = false;
            this.dgvComplaints.Columns[9].Visible = false;
            Hiding();
            CounterComp();
            CounterCust();


        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.dgvComplaints.Columns[0].Visible = true;
            this.dgvComplaints.Columns[1].Visible = true;
            this.dgvComplaints.Columns[2].Visible = true;
            this.dgvComplaints.Columns[3].Visible = true;
            this.dgvComplaints.Columns[4].Visible = true;
            this.dgvComplaints.Columns[5].Visible = true;
            this.dgvComplaints.Columns[6].Visible = true;
            this.dgvComplaints.Columns[7].Visible = true;
            this.dgvComplaints.Columns[8].Visible = true;
            this.dgvComplaints.Columns[9].Visible = true;
            chkComplaint.Checked = false;
            chkCustomer.Checked = false;
            chkType.Checked = false;
            chkDescription.Checked = false;
            chkRecorded.Checked = false;
            chkOccured.Checked = false;
            chkExpectation.Checked = false;
            chkStatus.Checked = false;
            chkResolution.Checked = false;
            chkRDescription.Checked = false;
            CounterComp();
            CounterCust();
        }

        private void CounterComp()
        {
            lblCompRows.Text = dgvComplaints.Rows.Count.ToString();
        }

        private void CounterCust()
        {
            lblCustRows.Text = dgvCustomers.Rows.Count.ToString();
        }

        private void SortingCust()
        {

        }

        private void FilteringCust()
        {

            string Citys = Convert.ToString(comboBox1.SelectedItem);


            var filteredCustomers2 =
                from p in custList
                where p.City == Citys
                select p;
            dgvCustomers.DataSource = filteredCustomers2.ToList();

            if (rdFemale.Checked)
            {
                var FilteredCustomers3 =
                from p in custList
                where p.Gender == "F"
                select p;
                dgvCustomers.DataSource = FilteredCustomers3.ToList();
            }

            if (rdMale.Checked)
            {
                var FilteredCustomers =
                from p in custList
                where p.Gender == "M"
                select p;
                dgvCustomers.DataSource = FilteredCustomers.ToList();
            }
            CounterComp();
            CounterCust();
        }

        private void btnSortCust_Click(object sender, EventArgs e)
        {
            dgvCustomers.ClearSelection();

            if (chkSort2.Checked)
            {
                custList = custList.OrderBy(nm => nm.LastName).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }

            if (chkSort1.Checked)
            {
                custList = custList.OrderBy(nm => nm.CustomerID).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }

            if (chkSort3.Checked)
            {
                custList = custList.OrderBy(nm => nm.FirstName).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }

            if (chkSort4.Checked)
            {
                custList = custList.OrderBy(nm => nm.Prefix).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }

            if (chkSort5.Checked)
            {
                custList = custList.OrderBy(nm => nm.Gender).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }

            if (chkSort6.Checked)
            {
                custList = custList.OrderBy(nm => nm.City).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }

            if (chkSort7.Checked)
            {
                custList = custList.OrderBy(nm => nm.State).ToList();
                dgvCustomers.DataSource = custList.ToList();
            }
            CounterComp();
            CounterCust();
        }

        private void btnFilterCust_Click(object sender, EventArgs e)
        {
            FilteringCust();
        }

        private void btnFilterComp_Click(object sender, EventArgs e)
        {

                string Status = Convert.ToString(comboBox3.SelectedItem);
                var filtercomp =
                    from p in compList
                    where p.Status == Status
                    select p;
                dgvComplaints.DataSource = filtercomp.ToList();


            string Type = Convert.ToString(comboBox4.SelectedItem);
            var filtercomps =
                from p in compList
                where p.ComplaintType == Type
                select p;
            dgvComplaints.DataSource = filtercomps.ToList();


            CounterComp();
            CounterCust();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayCustomerData();
            rdFemale.Checked = false;
            rdMale.Checked = false;
            CounterComp();
            CounterCust();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayComplaintData();
            comboBox4.Text = "";
            comboBox3.Text = "";
            CounterComp();
            CounterCust();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DisplayComplaintData();
            chkSort3.Checked = false;
            chkSort4.Checked = false;
            chkSort1.Checked = false;
            chkSort2.Checked = false;
            chkSort5.Checked = false;
            chkSort6.Checked = false;
            chkSort7.Checked = false;
            chkSort8.Checked = false;

            CounterComp();
            CounterCust();
        }

        private void btnSortComp_Click(object sender, EventArgs e)
        {
            if (chkSort14.Checked)
            {
                compList = compList.OrderByDescending(nm => nm.ComplaintType).ToList();
                dgvComplaints.DataSource = compList.ToList();
            }
            if (chkSort12.Checked)
            {
                compList = compList.OrderByDescending(nm => nm.ComplaintNo).ToList();
                dgvComplaints.DataSource = compList.ToList();
            }

            if (chkSort13.Checked)
            {
                compList = compList.OrderByDescending(nm => nm.CustomerID).ToList();
                dgvComplaints.DataSource = compList.ToList();
            }

            if (chkSort19.Checked)
            {
                compList = compList.OrderByDescending(nm => nm.Status).ToList();
                dgvComplaints.DataSource = compList.ToList();
            }

            if (chkSort16.Checked)
            {
                compList = compList.OrderByDescending(nm => nm.DateRecorded).ToList();
                dgvComplaints.DataSource = compList.ToList();
            }

            if (chkSort17.Checked)
            {
                compList = compList.OrderByDescending(nm => nm.DateOccured).ToList();
                dgvComplaints.DataSource = compList.ToList();
            }
            CounterComp();
            CounterCust();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CounterComp();
            CounterCust();
        }

        //
        //Cambie estas 4, borre el lastname txtbox de el filter, le cambie en boton de send customer email a contact customer
        //
        private void tabController_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabController.SelectedIndex == 1)
            {
                TabSort.SelectTab(1);
                TabFilter.SelectTab(1);
                TabShow.SelectTab(1);
            }
            else if(tabController.SelectedIndex == 0)
            {
                TabSort.SelectTab(0);
                TabFilter.SelectTab(0);
                TabShow.SelectTab(0);

            }

        }

        private void TabSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabSort.SelectedIndex == 1)
            {

                tabController.SelectTab(1);
                TabFilter.SelectTab(1);
                TabShow.SelectTab(1);

            }
            else if (TabSort.SelectedIndex == 0)
            {
                tabController.SelectTab(0);
                TabFilter.SelectTab(0);
                TabShow.SelectTab(0);

            }
        }

        private void TabShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabShow.SelectedIndex == 1)
            {
                tabController.SelectTab(1);
                TabSort.SelectTab(1);
                TabFilter.SelectTab(1);
            }
            else if (TabShow.SelectedIndex == 0)
            {
                TabSort.SelectTab(0);
                tabController.SelectTab(0);
                TabFilter.SelectTab(0);

            }
        }

        
        private void TabFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (TabFilter.SelectedIndex == 1)
            {
                tabController.SelectTab(1);
                TabSort.SelectTab(1);
                TabShow.SelectTab(1);
            }
            else if (TabFilter.SelectedIndex == 0)
            {
                TabSort.SelectTab(0);
                tabController.SelectTab(0);
                TabShow.SelectTab(0);

            }
        }
    }
}


