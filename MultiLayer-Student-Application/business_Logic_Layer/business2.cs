using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using data_Access_Layer;

namespace business_Logic_Layer
{
    public class business2:data_access
    {

        public static DataTable Select()
        {
            Link(); //link from data access layer connection to DB
            string Query = "Select * from Grade";
            DataTable outPut = SelectData(Query);

            unLink(); //close connection
            return outPut;
        }

        public static void Insert(String StudentID, String CourseID, String Grade)
        {
            Link();
            string Query = $"INSERT INTO Grade ([StudentID], [CourseID], [Grade]) VALUES('{StudentID}','{CourseID}','{Grade}')";
            ExecuteQuery(Query);
            unLink();
        }
        public static void Update(DataRow grade)
        {
            Link();
            string Query = $"UPDATE Grade SET [StudentID] ='{grade["StudentID"]}',[CourseID] ='{grade["CourseID"]}',[Grade] = '{grade["Grade"]}' WHERE [StudentID] = '{grade["StudentID"]}' AND [CourseID] = '{grade["CourseID"]}'";
            ExecuteQuery(Query);
            unLink();
        }
    }
}
