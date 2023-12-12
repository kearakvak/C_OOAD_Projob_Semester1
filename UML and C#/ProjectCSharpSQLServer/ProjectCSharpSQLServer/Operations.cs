using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectCSharpSQLServer
{
    class Operations
    {
        public SqlConnection objCon;
        public SqlCommand objCmd;
        public SqlDataReader objDR;
        public SqlDataAdapter objDA;
        public DataTable objDT;
        //Default Constructor
        public Operations() { }

        public void SetConnection(string serverName, string dbName)
        {
            string conStr;
            conStr = "Server = " + serverName + "; Database = "
                   + dbName + "; Integrated Security = SSPI";
            //SSPI = Security Support Provider Interface
            try
            {
                objCon = new SqlConnection(conStr);
                objCon.Open();
            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void RunSQL(string sql, SqlTransaction t = null)
        {
            //sql is Insert, Update or Delete Statement
            try
            {
                objCmd.Connection = objCon;
                if (t != null) objCmd.Transaction = t;
                //---Fat Client/Server Systems---
                //objCmd.CommandType = CommandType.Text;
                //objCmd.CommandText = sql;
                //objCmd.ExecuteNonQuery();
                //---Thin Client/Server Systems---
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "dbo.spRunSQL";
                objCmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
                objCmd.ExecuteNonQuery(); //Run Stored Procedure
                objCmd.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void PutDataIntoComboBox(string sql, ComboBox cbo)
        {
            //sql is Select One Column Statement
            try
            {
                //---Fat Client/Server Systems---
                //objCmd = new SqlCommand(sql, objCon);
                //objDR = objCmd.ExecuteReader(); 
                //---Thin Client/Server Systems---
                objCmd = new SqlCommand("dbo.spRunSQL", objCon);
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
                objDR = objCmd.ExecuteReader(); 
                cbo.Items.Clear();
                while (objDR.Read())
                {
                    cbo.Items.Add(objDR.GetString(0));
                }
                objDR.Close();

            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void FillDataTable(string sql)
        {
            //sql is Select two Columns Statement
            try
            {
                objCmd = new SqlCommand("dbo.spRunSQL", objCon);
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
                //--Initialize the DataAdapter object 
                //--and set the SelectCommand property
                objDA = new SqlDataAdapter();
                objDA.SelectCommand = objCmd;
                //Initialize the DataTable object
                objDT = new DataTable();
                //Populate the DataTable
                objDA.Fill(objDT);
                objDA.Dispose(); objDA = null;
                objCmd.Dispose(); objCmd = null;
            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void BindComboBox(ComboBox cbo, string sql,
                    string DisplayField, string ValueField)
        {
            //sql is Select two Columns Statement
            try
            {
                FillDataTable(sql);
                cbo.DisplayMember = DisplayField;
                cbo.ValueMember = ValueField;
                cbo.DataSource = objDT;

            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void BindListBox(ListBox Lst, string sql,
            string DisplayField, string ValueField)
        {
            try
            {
                FillDataTable(sql);
                Lst.DisplayMember = DisplayField;
                Lst.ValueMember = ValueField;
                Lst.DataSource = objDT;

            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void DisplayInformation(string sql, params Control[] ctr)
        {
            //sql is Select all Columns Statement
            try
            {
                int n = ctr.Length; //n is number of Controls
                objCmd = new SqlCommand("dbo.spRunSQL", objCon);
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
                objDR = objCmd.ExecuteReader();
                if (objDR.Read())
                {
                    for (int i = 0; i < n; i++)
                    {
                        ctr[i].Text = objDR.GetValue(i).ToString();
                    }
                }
                objDR.Close();
                objCmd.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(Ex.Message, "Error", btn, icon);
            }
        }

        public void ClearControls(params Control[] ctr)
        {
            int n = ctr.Length; //n is number of Controls
            for (int i = 0; i < n; i++)
                ctr[i].Text = "";
        }

        public void EnabledControls(Form frm, bool b)
        {
            foreach (Control ctr in frm.Controls)
                if (ctr is TextBox || ctr is DateTimePicker
                    || ctr is MaskedTextBox || ctr is RichTextBox)
                    if (ctr.Tag == null) ctr.Enabled = b;
        }

        public bool CheckEmpty(System.Windows.Forms.ErrorProvider ep,
            params Control[] ctr)
        {
            int n = ctr.Length; //n is number of Controls
            bool b = false;
            for (int i = 0; i < n; i++)
            {
                if (ctr[i].Text == "")
                {
                    ep.SetError(ctr[i], "Please, Input " + ctr[i].Tag + "!");
                    b = true;
                }
            }
            return b;
        }

        public void CloseForm(Form frm)
        {
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult ans;
            ans = MessageBox.Show("Do you want to close?", "Close Form",
                btn, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes) frm.Close();

        }

        public void SetToKhmer()
        {
            //if (Application.CurrentInputLanguage.Culture.Name != "km-KH")
            //    SendKeys.Send("+%");
            InputLanguage.CurrentInputLanguage =
                InputLanguage.InstalledInputLanguages[1];
        }

        public void SetToEnglish()
        {
            //if (Application.CurrentInputLanguage.Culture.Name != "en-US")
            //    SendKeys.Send("+%");
            InputLanguage.CurrentInputLanguage =
                InputLanguage.InstalledInputLanguages[0];
        }


    }
}
