using CCPLClinicAPI.Models.Patient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCPLClinicAPI.Controllers
{
    public class PatientController : ApiController
    {
        DataTable dt = new DataTable();
        Patient_Qry _PQry = new Patient_Qry();

        [HttpGet]
        public IHttpActionResult GetData(string CNIC)
        {
            Patient_Mod pm = new Patient_Mod();
            pm.EmpCNIC = CNIC;
            return Ok(Get_Detail(pm));
        }

        public Request_Status_patient Get_Detail(Patient_Mod pm)
        {
            try
            {
                dt = new DataTable();
                Request_Status_patient _request = new Request_Status_patient();
                dt = _PQry.Get_By_CNIC(pm);
                if (dt.Rows.Count > 0)
                {
                    _request.Code = 200;
                    _request.Msg = "Data Found.";

                    Patient_Mod item = new Patient_Mod();
                    List<Patient_Mod> _patientlist = new List<Patient_Mod>();

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        item = new Patient_Mod();
                        item.EmpID = dt.Rows[i]["EmpID"].ToString();
                        item.EmpCNIC = dt.Rows[i]["EmpCNIC"].ToString();
                        item.Name = dt.Rows[i]["Name"].ToString();
                        item.Title = dt.Rows[i]["Title"].ToString();
                        item.FirstName = dt.Rows[i]["FirstName"].ToString();
                        item.MidName = dt.Rows[i]["MidName"].ToString();
                        item.LastName = dt.Rows[i]["LastName"].ToString();
                        item.Gender = dt.Rows[i]["Gender"].ToString();
                        item.CNIC = dt.Rows[i]["CNIC"].ToString();
                        item.Tel1 = dt.Rows[i]["Tel1"].ToString();
                        item.Tel2 = dt.Rows[i]["Tel2"].ToString();
                        item.Address = dt.Rows[i]["Address"].ToString();
                        item.City = dt.Rows[i]["City"].ToString();
                        item.Country = dt.Rows[i]["Country"].ToString();
                        item.DOB = dt.Rows[i]["DOB"].ToString();
                        item.AgeY = dt.Rows[i]["AgeY"].ToString();
                        item.Remarks = dt.Rows[i]["Remarks"].ToString();
                        item.Relation = dt.Rows[i]["Relation"].ToString();
                        item.CompanyID = dt.Rows[i]["CompanyID"].ToString();
                        item.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                        item.GuardianName = dt.Rows[i]["GuardianName"].ToString();
                        item.CNICIssueDate = dt.Rows[i]["CNICIssueDate"].ToString();
                        item.CNICExpiryDate = dt.Rows[i]["CNICExpiryDate"].ToString();
                        item.FamilyNumber = dt.Rows[i]["FamilyNumber"].ToString();
                        item.CNICIdentity = dt.Rows[i]["CNICIdentity"].ToString();
                        item.ReferBy = dt.Rows[i]["ReferBy"].ToString();
                        item.Discount1 = dt.Rows[i]["Discount1"].ToString();
                        item.Discount2 = dt.Rows[i]["Discount2"].ToString();

                        _patientlist.Add(item);
                    }
                    _request.data = _patientlist;
                }
                else
                {
                    _request.Code = 401;
                    _request.Msg = "Data Not Found.";
                }
                return _request;
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }

    }
}
