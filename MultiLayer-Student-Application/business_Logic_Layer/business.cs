using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using data_Access_Layer;

namespace business_Logic_Layer
{
    public class business:data_access
    {
        public static DataTable Select()
        {
            Link(); //link from data access layer connection to DB
            string Query = "Select * from Student";
            DataTable outPut = SelectData(Query);

            unLink(); //close connection
            return outPut;
        }

        public static void Insert(DataRow student)
        {
            Link();
            string Query = $"INSERT INTO Student ([StudentID],[Name],[Family],[BirthDate]) VALUES('{student["StudentID"]}','{student["Name"]}','{student["Family"]}','{student["BirthDate"]}')";
            ExecuteQuery(Query);
            unLink();
        }

        public static void Delete(String ID )
        {
            Link();
            string Query = $"DELETE Student WHERE StudentID = '{ID}'";
            ExecuteQuery(Query);
            unLink();
        }

        public static void Update(DataRow student)
        {
            Link();
            string Query = $"UPDATE Student SET [Name] ='{student["Name"]}',[Family] ='{student["Family"]}',[BirthDate] = '{student["BirthDate"]}' WHERE [StudentID] = '{student["StudentID"]}'";
            ExecuteQuery(Query);
            unLink();
        }
    }
}
