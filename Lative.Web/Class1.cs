using System;
using System.Data.SqlClient;
using Dapper;
namespace CleanCodeApp
{
    public class Class1
    {
        public decimal Calc(decimal amnt /* $100 */, int uid)
        {
            int tp = 0;
            int y = 0;

            var connection = new SqlConnection("Data Source=SW-GBHA-TISL281;Initial Catalog=TWDC_CustDis;User Id=dev;Password=dev;");
            tp = connection.ExecuteScalar<int>("SELECT type FROM Employees WHERE id=" + uid);
            DateTime sd = connection.ExecuteScalar<DateTime>("SELECT start_date FROM Customers where id=" + uid);

            y = DateTime.Now.Year - sd.Year;

            decimal result = 0;
            decimal discB = (y > 5) ? (decimal)3 / 100 : (decimal)5 / 100;


            // Permanent 
            if (tp == 1)
            {
                if (y > 3)
                    result = (amnt * 10 / 100) - (decimal)0.05 * (amnt * 10 / 100);
                else
                    result = (amnt * 10 / 100); // RETURN $10
            }



            // Part-Time 
            else if (tp == 2)
            {
                result = (y > 5) ? (amnt * 5 / 100) - ((decimal)3/100) * (amnt * 5 / 100) 
                                 : (amnt * 5 / 100); // RETURN $5
            }



            // Interns 
            else if (tp == 3)
            {
                if (amnt > 30)
                    result = amnt * 5 / 100;
                else
                    result = amnt; // RETURN $100
            }



            // Contractors 
            else if (tp == 4)
            {
                result = amnt; // RETURN $100
            }




            connection.Execute("UPDATE Employees SET discount=" + result + " WHERE id=" + uid);

            //return the result
            return result;
        }
    }
}
