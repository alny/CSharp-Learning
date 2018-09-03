using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace FormUI {
    public class DataAccess {
        public List<Person> GetPeople(string lastname) {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("master"))) {

                var output = connection.Query<Person>($"select * from People where LastName = '{ lastname }'").ToList();
                return output;
            }
        }

        public void InsertRecord(string firstName, string lastName, string emailAddress, string phoneNumber) {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("master"))) {

                string sql = "INSERT INTO People (FirstName, LastName, EmailAddress, PhoneNumber) Values (@FirstName, @LastName, @EmailAddress, @PhoneNumber);";
                connection.Execute(sql, new { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
            }

        }
    }
}
