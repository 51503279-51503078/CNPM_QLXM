using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLCuaHangXe
{
    public partial class DataService : DataTable
    {
        private static SqlConnection m_Connection;
        //
        public static String m_ConnectString = "Data Source=Sylvie\\SQLEXPRESS;Initial Catalog=QLXe;Integrated Security=True;Connect Timeout=30;User ID=root;pwd=$secret Instance=True";
        //public static String m_ConnectString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=f:\\dbNhaSach.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        // The command to execute query or non-query command on a database of this data service.
        private SqlCommand m_Command;

        // The data adapter to execute query on a database of this data service.
        private SqlDataAdapter m_DataAdapter;

        public DataService()
        {

        }


        public SqlCommand Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }

        public void Load(SqlCommand command)
        {
            m_Command = command;
            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                m_DataAdapter.Fill(this);

            }
            catch (Exception e)
            {
                String str = e.Message;
                MessageBox.Show(str);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);


                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch (Exception e)
            {
              //  m_Connection.Close();
                String str = e.Message;
                MessageBox.Show(str);
                return false;
            }

        }

        /// <summary>
        /// Closes the connection of this data service.
        /// </summary>
        public static void CloseConnection()
        {
            m_Connection.Close();
        }

        /// <summary>
        /// Update DataTable
        /// </summary>
        /// <returns></returns>
        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction tr = null;
            try
            {
                tr = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = tr;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);

                tr.Commit();
            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                MessageBox.Show(e.Message.ToString());

            }
            return result;
        }
        /// <summary>
        /// Thuc thi mot command
        /// </summary>
        /// <param name="command">OleDb hay Store Procedure</param>
        /// <returns></returns>
        public int ExecuteNoneQuery(SqlCommand cmd)
        {

            int result = 0;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteNonQuery();

                this.AcceptChanges();

                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                MessageBox.Show(e.Message.ToString());
                //throw;
            }
            return result;

        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            object result = null;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteScalar();

                this.AcceptChanges();

                tr.Commit();

                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                //throw;
                MessageBox.Show(e.Message);
            }
            return result;
        }
    }
}