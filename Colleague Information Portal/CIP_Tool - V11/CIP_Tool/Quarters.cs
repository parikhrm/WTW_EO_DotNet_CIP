using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace CIP_Tool
{
    internal class Quarters
    {
        public void quarters(DataTable dta)
        {
            string connectionstringtxt = "Data Source=A20-CB-DBSE01P;Initial Catalog=DRD;User ID=DRDUsers;Password=24252425";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                conn.ConnectionString = connectionstringtxt;
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "WITH NextFiveYears AS (\r\n    SELECT 1 AS QtrNum, CAST('2026-01-01' AS DATE) AS QDate\r\n    UNION ALL\r\n    SELECT QtrNum + 1, DATEADD(quarter, 1, QDate)\r\n    FROM NextFiveYears\r\n    WHERE QtrNum < 20\r\n)\r\nSELECT CONCAT('Q', DATEPART(quarter, QDate), '-', YEAR(QDate)) AS QuarterYear\r\nFROM NextFiveYears;";
                sda.SelectCommand = cmd;
                dt = dta;
                sda.Fill(dta);
            }
            catch (Exception ab)
            {
                MessageBox.Show("Error Generated Details : " + ab.ToString());
            }
        }
    }
}
