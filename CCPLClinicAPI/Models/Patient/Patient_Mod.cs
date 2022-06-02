using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCPLClinicAPI.Models.Patient
{
    public class Request_Status_patient
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public List<Patient_Mod> data { get; set; }
    }
    public class Patient_Mod
    {
        public string EmpID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string GuardianName { get; set; }
        public string EmpCNIC { get; set; }
        public string CNICIssueDate { get; set; }
        public string CNICExpiryDate { get; set; }
        public string FamilyNumber { get; set; }
        public string CNICIdentity { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string AgeY { get; set; }
        public string AgeM { get; set; }
        public string AgeD { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string ReferBy { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Remarks { get; set; }
        public string Relation { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Discount1 { get; set; }
        public string Discount2 { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpPayroll { get; set; }
        public string EmpType { get; set; }
        public string InActive { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public string LoginID { get; set; }
        public string CCPL_ROW_ID { get; set; }
    }
}