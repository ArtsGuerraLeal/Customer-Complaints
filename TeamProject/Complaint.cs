using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public class Complaint
    {

        private int complaintNo;
        private int customerID;
        private string complaintType;
        private string complaintDesc;
        private DateTime dateRecorded;
        private DateTime dateOccured;
        private string custExpectation;
        private string status;
        private DateTime resolutionDate;
        private string resolutionDesc;


        public int ComplaintNo
        {
            get { return complaintNo; }
            set { complaintNo = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string ComplaintType
        {
            get { return complaintType; }
            set { complaintType = value; }
        }

        public string ComplaintDesc
        {
            get { return complaintDesc; }
            set { complaintDesc = value; }
        }

        public DateTime DateRecorded
        {
            get { return dateRecorded; }
            set { dateRecorded = value; }
        }
        public DateTime DateOccured
        {
            get { return dateOccured; }
            set { dateOccured = value; }
        }
        public string CustExpectation
        {
            get { return custExpectation; }
            set { custExpectation = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime ResolutionDate
        {
            get { return resolutionDate; }
            set { resolutionDate = value; }
        }

        public string ResolutionDesc
        {
            get { return resolutionDesc; }
            set { resolutionDesc = value; }
        }

        public Complaint()
        {

        }

    }
}



