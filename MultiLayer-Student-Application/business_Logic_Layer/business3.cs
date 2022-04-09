using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using data_Access_Layer;

namespace business_Logic_Layer
{
    public class business3:data_access
    {
        public static DataTable Select()
        {
            Link(); //link from data access layer connection to DB
            string Query = "Select * from Course";
            DataTable outPut = SelectData(Query);

            unLink(); //close connection
            return outPut;
        }
    }
}
