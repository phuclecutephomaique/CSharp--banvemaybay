using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinForm1
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<DTO.LoginDTO> taiKhoan(string query)
        {
            List<DTO.LoginDTO> taiKhoan = new List<DTO.LoginDTO>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoan.Add(new DTO.LoginDTO(dataReader.GetString(1),dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return taiKhoan;
        }
    }
}
