using CCPLClinicAPI.Models.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CCPLClinicAPI.Models.Patient
{
    public class Patient_Qry
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


        public DataTable Get_By_CNIC(Patient_Mod pm)
        {
            try
            {
                Refresh();
                dt = help.ReturnParameterizedDataTableProcedure("UD_Get_Employee_Data_By_CNIC_ForAPI", "@ID", pm.EmpCNIC);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}