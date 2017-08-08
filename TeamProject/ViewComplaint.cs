using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeamProject
{
    public partial class ViewComplaint : Form
    {
        int selectedindex;

        public List<Complaint> storageList = new List<Complaint>();

        public ViewComplaint(List<Complaint> inputList, int index)
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
            AddNewComplaint();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateNewComplaint();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save changes?", "Suggestion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                SaveListToFile();
            }
        }

        private void AddNewComplaint()
        {
            Complaint c = new Complaint();
            c.ComplaintNo = Convert.ToInt32(txtCompNo.Text);
            c.CustomerID = Convert.ToInt32(txtCustID.Text);
            c.ComplaintType = cmbCompType.Text;
            c.ComplaintDesc = txtCompDesc.Text;
            c.DateRecorded = dateRec.Value;
            c.DateOccured = dateOccured.Value;
            c.CustExpectation = cmbCustExp.Text;
            c.Status = txtStatus.Text;
            c.ResolutionDate = dateResolution.Value;
            c.ResolutionDesc = txtResolutionDesc.Text;

            storageList.Add(c);

            dgvTestComplaints.DataSource = null;
            dgvTestComplaints.DataSource = storageList;
        }

        private void UpdateNewComplaint()
        {
            Complaint c = new Complaint();

            c.ComplaintNo = Convert.ToInt32(txtCompNo.Text);
            c.CustomerID = Convert.ToInt32(txtCustID.Text);
            c.ComplaintType = cmbCompType.Text;
            c.ComplaintDesc = txtCompDesc.Text;
            c.DateRecorded = dateRec.Value;
            c.DateOccured = dateOccured.Value;
            c.CustExpectation = cmbCustExp.Text;
            c.Status = txtStatus.Text;
            c.ResolutionDate = dateResolution.Value;
            c.ResolutionDesc = txtResolutionDesc.Text;

            dgvTestComplaints.DataSource = null;
            dgvTestComplaints.DataSource = storageList;

            storageList[selectedindex] = c;

        }

        private void SaveListToFile()
        {

            string outputStr = "";
            const string DELIM = ",";


            FileStream fs = new FileStream("Customers.csv", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);


            foreach (Complaint c in storageList)
            {
                outputStr = 
                    c.ComplaintNo + DELIM +
                    c.CustomerID + DELIM +
                    c.ComplaintType + DELIM +
                    c.ComplaintDesc + DELIM +
                    c.DateRecorded + DELIM +
                    c.DateOccured + DELIM +
                    c.CustExpectation + DELIM +
                    c.Status + DELIM +
                    c.ResolutionDate + DELIM +
                    c.ResolutionDesc;
                writer.WriteLine(outputStr);
            }

            writer.Close();
            fs.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteComplaint();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {         
            Complaint c = new Complaint();
            selectedindex = 0;
            c = storageList[selectedindex];
            txtCompNo.Text = c.ComplaintNo.ToString();
            txtCustID.Text = c.CustomerID.ToString();
            cmbCompType.Text = c.ComplaintType;
            txtCompDesc.Text = c.ComplaintDesc;
            dateRec.Value = c.DateRecorded;
            dateOccured.Value = c.DateOccured;
            cmbCustExp.Text = c.CustExpectation;
            txtStatus.Text = c.Status;
            if (c.ResolutionDate > dateResolution.MinDate)
            {
                dateResolution.Value = c.ResolutionDate;
            }
            else
            {
                dateResolution.Value = DateTime.Today;
            }
            txtResolutionDesc.Text = c.ResolutionDesc;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (selectedindex > 0)
            {
                selectedindex--;
                Complaint c = new Complaint();
                c = storageList[selectedindex];
                txtCompNo.Text = c.ComplaintNo.ToString();
                txtCustID.Text = c.CustomerID.ToString();
                cmbCompType.Text = c.ComplaintType;
                txtCompDesc.Text = c.ComplaintDesc;
                dateRec.Value = c.DateRecorded;
                dateOccured.Value = c.DateOccured;
                cmbCustExp.Text = c.CustExpectation;
                txtStatus.Text = c.Status;
                if (c.ResolutionDate > dateResolution.MinDate)
                {
                    dateResolution.Value = c.ResolutionDate;
                }
                else
                {
                    dateResolution.Value = DateTime.Today;
                }
                txtResolutionDesc.Text = c.ResolutionDesc;
            }

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

            selectedindex++;
            Complaint c = new Complaint();
            c = storageList[selectedindex];
            txtCompNo.Text = c.ComplaintNo.ToString();
            txtCustID.Text = c.CustomerID.ToString();
            cmbCompType.Text = c.ComplaintType;
            txtCompDesc.Text = c.ComplaintDesc;
            dateRec.Value = c.DateRecorded;
            dateOccured.Value= c.DateOccured;
            cmbCustExp.Text = c.CustExpectation;
            txtStatus.Text = c.Status;
            if (c.ResolutionDate > dateResolution.MinDate)
            {
                dateResolution.Value = c.ResolutionDate;
            }
            else
            {
                dateResolution.Value = DateTime.Today;
            }
            txtResolutionDesc.Text = c.ResolutionDesc;

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

            Complaint c = new Complaint();
            selectedindex = storageList.Count - 1;   
            c = storageList[selectedindex];
            txtCompNo.Text = c.ComplaintNo.ToString();
            txtCustID.Text = c.CustomerID.ToString();
            cmbCompType.Text = c.ComplaintType;
            txtCompDesc.Text = c.ComplaintDesc;
            dateRec.Value = c.DateRecorded;
            dateOccured.Value = c.DateOccured;
            cmbCustExp.Text = c.CustExpectation;
            txtStatus.Text = c.Status;
            if (c.ResolutionDate > dateResolution.MinDate)
            {
                dateResolution.Value = c.ResolutionDate;
            }
            else
            {
                dateResolution.Value = DateTime.Today;
            }
            txtResolutionDesc.Text = c.ResolutionDesc;

        }



        private void ViewComplaint_Load(object sender, EventArgs e)
        {
            dgvTestComplaints.DataSource = null;
            dgvTestComplaints.DataSource = storageList;
        }

        private void DeleteComplaint()
        {

            DialogResult dr = MessageBox.Show("Do you wish to delete this record?", "Suggestion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                storageList.Remove(storageList[selectedindex]);

                dgvTestComplaints.DataSource = null;
                dgvTestComplaints.DataSource = storageList;

                bndSourceCust.MovePrevious();
                bndSourceCust.ResetItem(selectedindex);

                if (selectedindex > 0)
                {
                    bndNavCust.Refresh();
                    selectedindex--;
                    Complaint c = new Complaint();
                    c = storageList[selectedindex];
                    txtCompNo.Text = c.ComplaintNo.ToString();
                    txtCustID.Text = c.CustomerID.ToString();
                    cmbCompType.Text = c.ComplaintType;
                    txtCompDesc.Text = c.ComplaintDesc;
                    dateRec.Value = c.DateRecorded;
                    dateOccured.Value = c.DateOccured;
                    cmbCustExp.Text = c.CustExpectation;
                    txtStatus.Text = c.Status;
                    if (c.ResolutionDate > dateResolution.MinDate)
                    {
                        dateResolution.Value = c.ResolutionDate;
                    }
                    else
                    {
                        dateResolution.Value = DateTime.Today;
                    }
                    txtResolutionDesc.Text = c.ResolutionDesc;
                }
                else
                {

                    Complaint c = new Complaint();
                    c = storageList[selectedindex];
                    txtCompNo.Text = c.ComplaintNo.ToString();
                    txtCustID.Text = c.CustomerID.ToString();
                    cmbCompType.Text = c.ComplaintType;
                    txtCompDesc.Text = c.ComplaintDesc;
                    dateRec.Value = c.DateRecorded;
                    dateOccured.Value = c.DateOccured;
                    cmbCustExp.Text = c.CustExpectation;
                    txtStatus.Text = c.Status;
                    if (c.ResolutionDate > dateResolution.MinDate)
                    {
                        dateResolution.Value = c.ResolutionDate;
                    }
                    else
                    {
                        dateResolution.Value = DateTime.Today;
                    }
                    txtResolutionDesc.Text = c.ResolutionDesc;
                }
            }
        }

        private void dgvTestComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
                        bindingNavigatorPositionItem.Text = (dgvTestComplaints.CurrentCell.RowIndex + 1).ToString();

                        Complaint c = new Complaint();

                        c = storageList[dgvTestComplaints.CurrentCell.RowIndex];

                        txtCompNo.Text = c.ComplaintNo.ToString();
                        txtCustID.Text = c.CustomerID.ToString();
                        cmbCompType.Text = c.ComplaintType;
                        txtCompDesc.Text = c.ComplaintDesc;
                        dateRec.Value = c.DateRecorded;
                        dateOccured.Value = c.DateOccured;
                        cmbCustExp.Text = c.CustExpectation;
                        txtStatus.Text = c.Status;
                        if (c.ResolutionDate > dateResolution.MinDate)
                        {
                            dateResolution.Value = c.ResolutionDate;
                            }
                             else
                            {
                               dateResolution.Value = DateTime.Today;
                          }
                            txtResolutionDesc.Text = c.ResolutionDesc;
                            */

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
