using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCPLClinicAPI.Models.TokenMedication
{
    public class Request_Status_Medication
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public List<TknMedi_Mode> data { get; set; }
    }
    public class TknMedi_Mode
    {
        public string TokenNo { get; set; }
        public DateTime TokenDate { get; set; }
        public string PatName { get; set; }
        public string DrName { get; set; }
        public string GenericName { get; set; }
        public string TypeID { get; set; }
        public string SubTypeID { get; set; }
        public string IsMorning { get; set; }
        public string IsEvening { get; set; }
        public string IsNight { get; set; }
        public string DosageQty { get; set; }
        public string NoOfDays { get; set; }
        public string UrduText { get; set; }
        public string Remarks { get; set; }
        public string PatCNIC { get; set; }
        public string DosageInfo { get; set; }
        public string TotalQty { get; set; }
        public string SiteID { get; set; }
        public string DivisionID { get; set; }
    }
}