using CCPLClinicAPI.Models.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CCPLClinicAPI.Models.TokenMedication
{
    public class TknMedi_Qry
    {
        DB_Helper help = new DB_Helper();
        DataTable dt = new DataTable();
        string ReturnJS = string.Empty;


        void Refresh()
        {
            help = new DB_Helper();
            dt = new DataTable();
            ReturnJS = string.Empty;
        }


        public DataTable Get_By_Token(TknMedi_Mode pm)
        {
            try
            {
                Refresh();
                dt = help.ReturnParameterizedDataTableProcedure("UD_Get_Token_Medicine_List_ForPharmacy", "@TokenNo", pm.TokenNo);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}