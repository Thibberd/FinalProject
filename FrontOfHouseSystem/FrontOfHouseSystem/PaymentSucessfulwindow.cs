﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrontOfHouseSystem
{
    public partial class PaymentSucessfulwindow : Form
    {
        

        
        public float RunningTotal;
        public float userID;
        public float transID;
        public int OrderID;

        Order order = new Order();
        Product product = new Product();


        public PaymentSucessfulwindow(int TransID, float runningTotal, float Change, ListBox.ObjectCollection orderItems, int UserID)
        {
            InitializeComponent();
            

            Transaction transaction = new Transaction();
            transaction.transactionID = TransID;

            OrderList.Items.AddRange(orderItems);
            userID = UserID;
            transID = TransID;

            RunningTotal = runningTotal;
            TotalAmountLbl.Text = RunningTotal.ToString("£#0.00");
            ChangeAmountlbl.Text = Change.ToString("£#0.00");
        }

        
            
private void button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();
            SqlCommand command2 = new SqlCommand();


            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO dbo.Orders ([UserID], [TransactionID], [OrderTotal]) VALUES (@userID, @transID,@OrderT)" ;

            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@transID", transID);
            command.Parameters.AddWithValue("@OrderT", RunningTotal);

     
            try
            {
                connection.Open();

                int recordsAffected = command.ExecuteNonQuery();
                
            }
            catch(SqlException)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }


        }

    }
}
