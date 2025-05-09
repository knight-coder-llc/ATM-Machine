﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ATM_Machine
{
    class Transaction
    {
        int transactionNum;
        int accountNum;
        string transactionType;
        double amount;
        int fromAccount;
        int toAccount;
        DateTime date;

        public Transaction(int accNum, string transTy, double amountMoney, int fromAcc, int toAcc)
        {
            accountNum = accNum;
            transactionType = transTy;
            amount = amountMoney;
            fromAccount = fromAcc;
            toAccount = toAcc;
            transactionNum = -1;
        }

        public int getTransNum()
        {
            return transactionNum;
        }

        public double getAmount()
        {
            return amount;
        }
        public void saveTransaction()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                System.Diagnostics.Debug.WriteLine("Connecting to MySQL...");
                conn.Open();
                //string sql = "SELECT MAX(TransNum) FROM changTransaction WHERE accountNum=@num";
                string sql = "SELECT MAX(transactionNum) FROM 834_kilburn_transaction WHERE accountNum=@num";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@num", accountNum);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    object result = myReader[0];
                    System.Diagnostics.Debug.WriteLine($"Raw SQL Result: {result}");

                    if (result != DBNull.Value && !string.IsNullOrWhiteSpace(result.ToString()))
                    {
                        transactionNum = Convert.ToInt32(myReader[0].ToString());
                        System.Diagnostics.Debug.WriteLine("newTrans number" + transactionNum);
                    }
                    else
                    {
                        transactionNum = 0; // default start
                        System.Diagnostics.Debug.WriteLine("No previous transaction, starting at 0.");
                    }
                    
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            conn.Close();
            System.Diagnostics.Debug.WriteLine("Done.");

            if (transactionNum == -1)
            {
                System.Diagnostics.Debug.WriteLine("Error:  Cannot find and assign a new transaction number.");
            }
            else
            {
                transactionNum = transactionNum + 1;
                connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try
                {
                    System.Diagnostics.Debug.WriteLine("Connecting to MySQL...");
                    conn.Open();
                    string sql = "INSERT INTO 834_kilburn_transaction (transactionNum, accountNum, transactionType, amount, fromAccount, toAccount, date)" +
                        " VALUES (@tNum, @aNum, @tType, @amo, @fAcc, @tAcc, @dT)";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tNum", transactionNum);
                    cmd.Parameters.AddWithValue("@aNum", accountNum);
                    cmd.Parameters.AddWithValue("@tType", transactionType);
                    cmd.Parameters.AddWithValue("@amo", amount);
                    cmd.Parameters.AddWithValue("@fAcc", fromAccount);
                    cmd.Parameters.AddWithValue("@tAcc", toAccount);
                    date = DateTime.Now;
                    cmd.Parameters.AddWithValue("@dT", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                conn.Close();
                System.Diagnostics.Debug.WriteLine("Done.");
            }
        }
    }
}
