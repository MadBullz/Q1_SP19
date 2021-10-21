using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace Q1
{
    class Corporation{
        public int corpNo { get; set; }
        public string corpName { get; set; }
        public string street { get; set; }
        public string region { get; set; }
        public DateTime expiredDate { get; set; }
    }

    class CorporationDAO
    {
        // đối tượng kết nối
        SqlConnection connection;

        // đối tượng thực thi các truy vấn
        SqlCommand command;


        string getConnectionString()
        {
            // khai báo và lấy chuỗi từ appsettings.json
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();

            return config["ConnectionString:MyCorpDB"];
        }

        public int updateCorp(Corporation corporation)
        {
            int result = 0;

            connection = new SqlConnection(getConnectionString());
            command = new SqlCommand("update corporation set corp_name = @corpName, street = @street, expr_dt = @date where corp_no= @corpNo", connection);
            command.Parameters.AddWithValue("@corpName", corporation.corpName);
            command.Parameters.AddWithValue("@street", corporation.street);
            command.Parameters.AddWithValue("@date", corporation.expiredDate);
            command.Parameters.AddWithValue("@corpNo", corporation.corpNo);

            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public List<Corporation> getCorporations()
        {
            List<Corporation> corporations = new List<Corporation>();

            connection = new SqlConnection(getConnectionString());
            string query = "select corp_no, corp_name, corporation.street, expr_dt, region.region_name " +
                            " from corporation inner join region on corporation.region_no = region.region_no";

            command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        corporations.Add(new Corporation()
                        {
                            corpNo = reader.GetInt32("corp_no"),
                            corpName = reader.GetString("corp_name"),
                            street = reader.GetString("street"),
                            expiredDate = reader.GetDateTime("expr_dt"),
                            region = reader.GetString("region_name")
                        } 
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return corporations;
        }
    }
}
