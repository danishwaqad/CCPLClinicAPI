using CCPLClinicAPI.Models.TokenMedication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCPLClinicAPI.Controllers
{
    public class TokenMediController : ApiController
    {
        DataTable dt = new DataTable();
        TknMedi_Qry _Qry = new TknMedi_Qry();


        [HttpGet]
        public IHttpActionResult GetMediData(string TokenNo)
        {
            TknMedi_Mode pm = new TknMedi_Mode();
            pm.TokenNo = TokenNo;
            return Ok(Get_Medication_fromTkn(pm));
        }
        public Request_Status_Medication Get_Medication_fromTkn(TknMedi_Mode pm)
        {
            try
            {
                dt = new DataTable();
                Request_Status_Medication _request = new Request_Status_Medication();
                dt = _Qry.Get_By_Token(pm);
                if (dt.Rows.Count > 0)
                {
                    _request.Code = 200;
                    _request.Msg = "Data Found.";

                    TknMedi_Mode item = new TknMedi_Mode();
                    List<TknMedi_Mode> _Medilist = new List<TknMedi_Mode>();

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        item = new TknMedi_Mode();
                        item.TokenNo = dt.Rows[i]["TokenNo"].ToString();
                        item.TokenDate = DateTime.Parse(dt.Rows[i]["TokenDate"].ToString());
                        item.PatName = dt.Rows[i]["PatName"].ToString();
                        item.DrName = dt.Rows[i]["DrName"].ToString();
                        item.GenericName = dt.Rows[i]["GenericName"].ToString();
                        item.TypeID = dt.Rows[i]["TypeID"].ToString();
                        item.SubTypeID = dt.Rows[i]["SubTypeID"].ToString();
                        item.IsMorning = dt.Rows[i]["IsMorning"].ToString();
                        item.IsEvening = dt.Rows[i]["IsEvening"].ToString();
                        item.IsNight = dt.Rows[i]["IsNight"].ToString();
                        item.DosageQty = dt.Rows[i]["DosageQty"].ToString();
                        item.NoOfDays = dt.Rows[i]["NoOfDays"].ToString();
                        item.UrduText = dt.Rows[i]["UrduText"].ToString();
                        item.Remarks = dt.Rows[i]["Remarks"].ToString();
                        item.PatCNIC = dt.Rows[i]["PatCNIC"].ToString();
                        item.DosageInfo = dt.Rows[i]["DosageInfo"].ToString();
                        item.TotalQty = dt.Rows[i]["TotalQty"].ToString();
                        item.SiteID = dt.Rows[i]["SiteID"].ToString();
                        item.DivisionID = dt.Rows[i]["DivisionID"].ToString();

                        _Medilist.Add(item);
                    }
                    _request.data = _Medilist;
                }
                else
                {
                    _request.Code = 401;
                    _request.Msg = "Data Not Found.";
                }
                return _request;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}