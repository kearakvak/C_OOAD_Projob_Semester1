using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ProjectCSharpSQLServer
{
    public partial class FormStaff : Form
    {
        //Create Object(op) for accessing all methods in class
        Operations op = new Operations();
        string sql, fp, str, status; //fp = File Path
        byte[] binpic; //Store binary data of picture
        MemoryStream ms;

        public FormStaff()
        {
            InitializeComponent();
            this.Load += FormStaff_Load;
            this.KeyDown += FormStaff_KeyDown;
            txtNameKH.GotFocus += txtNameKH_GotFocus;
            txtNameEN.GotFocus += txtNameEN_GotFocus;
            txtSearch.GotFocus += txtSearch_GotFocus;
            btnNew.Click += btnNew_Click;
            btnBrowse.Click += btnBrowse_Click;
            LstStaff.Click += LstStaff_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnSave.Click += btnSave_Click;
            btnClose.Click += btnClose_Click;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            op.CloseForm(this);
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool chk = op.CheckEmpty(errorProvider1, txtID, txtNameKH,
                txtNameEN, cboGender, txtBirthDate, txtAddress, 
                cboPosition, txtSalary, txtHiredDate, cboStopWork);
            if (chk == true) return; // force exit from event
            string pos, snKH, snEN, g, ph, bd, hd, ad, sms = "";
            float sal;
            int sw;
            SqlTransaction t = null;
            op.objCmd = op.objCon.CreateCommand();
            t = op.objCon.BeginTransaction();
            op.objCmd.Connection = op.objCon;
            op.objCmd.Transaction = t;
            try
            {
                if (cboStopWork.Text == "False")
                    sw = 0;
                else
                    sw = 1;
                int n = txtSalary.Text.Length;
                if (txtSalary.Text.Substring(0, 1) == "$")
                    sal = float.Parse(txtSalary.Text.Substring(1, n - 1));
                else
                    sal = float.Parse(txtSalary.Text);
                snKH = "N'" + txtNameKH.Text + "'";
                snEN = "'" + txtNameEN.Text + "'";
                g = "'" + cboGender.Text + "'";
                bd = "'" + txtBirthDate.Text + "'";
                ph = "'" + txtPhone.Text + "'";
                ad = "'" + txtAddress.Text + "'";
                pos = "'" + cboPosition.Text + "'";
                hd = "'" + txtHiredDate.Text + "'";
                short id = Int16.Parse(txtID.Text);
                if (status == "New")
                {
                    sql = "Exec dbo.spInsertStaff  " + id + "," + snKH + "," 
                        + snEN + "," + g + "," + bd + "," + ph + "," + ad + "," 
                        + pos + "," + sal + "," + hd + "," + sw + ", @img";
                    sms = "Staff's Information was inserted!";
                }
                else if (status == "Old")
                {
                    sql = "Exec dbo.spEditStaff  " + id + "," + snKH + ","
                        + snEN + "," + g + "," + bd + "," + ph + "," + ad 
                        + "," + pos + "," + sal + "," + hd + "," + sw + ", @img";
                    sms = "Staff's Information was updated!";
                }

                op.objCmd = new SqlCommand(sql, op.objCon, t);
                op.objCmd.Parameters.AddWithValue("@img", binpic);
                op.objCmd.ExecuteNonQuery();
                MessageBox.Show(sms, "Information", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                op.objCmd.Dispose();
                t.Commit();
                FormStaff_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Commit Exception Type: " + ex.GetType()
                    + "\nMessage: " + ex.Message, "Error", btn, icon);
                // Attempt to roll back the transaction.
                try
                {
                    t.Rollback();
                }
                catch (Exception ex1)
                {
                    MessageBoxButtons btn1 = MessageBoxButtons.OK;
                    MessageBoxIcon icon1 = MessageBoxIcon.Error;
                    MessageBox.Show("Rollback Exception Type: " + ex1.GetType()
                        + "\nMessage: " + ex1.Message, "Error", btn1, icon1);
                }
            }

        }

        void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sn, sql;
            sn = "N'%" + txtSearch.Text + "%'";
            sql = "SELECT StaffID, StaffNameKH FROM tbStaff WHERE "
                + " StaffNameKH Like " + sn + " ORDER BY StaffNameKH";
            op.BindListBox(LstStaff, sql, "StaffNameKH", "StaffID");
            if (LstStaff.Items.Count == 0)
            {
                op.ClearControls(txtID, txtNameKH, txtNameEN, cboGender, 
                  txtPhone, txtAddress, cboPosition, txtSalary, cboStopWork);
                txtBirthDate.Value = DateTime.Today;
                txtHiredDate.Value = DateTime.Today;
                fp = Path.GetDirectoryName(Application.ExecutablePath);
                fp = fp + "/Staff.jpg";
                binpic = System.IO.File.ReadAllBytes(fp);
                ms = new MemoryStream(binpic);
                Photo.Image = Image.FromStream(ms);
            }
            else
            {
                LstStaff.SetSelected(0, true);
                string id = LstStaff.SelectedValue.ToString();
                StaffInformation(id);
            }
        }

        void LstStaff_Click(object sender, EventArgs e)
        {
            string id = LstStaff.SelectedValue.ToString();
            StaffInformation(id);
        }

        void StaffInformation(string id)
        {
            errorProvider1.Clear();
            string sql = "Select * From tbStaff Where StaffID = " + id;
            op.objCmd = new SqlCommand("dbo.spRunSQL", op.objCon);
            op.objCmd.CommandType = CommandType.StoredProcedure;
            op.objCmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
            op.objDR = op.objCmd.ExecuteReader();
            if (op.objDR.Read())
            {
                txtID.Text = op.objDR.GetInt16(0).ToString();
                txtNameKH.Text = op.objDR.GetString(1);
                txtNameEN.Text = op.objDR.GetString(2);
                cboGender.Text = op.objDR.GetString(3);
                txtBirthDate.Text = op.objDR.GetDateTime(4).ToShortDateString();
                txtPhone.Text = op.objDR.GetString(5);
                txtAddress.Text = op.objDR.GetString(6);
                cboPosition.Text = op.objDR.GetString(7);
                double sal = op.objDR.GetSqlMoney(8).ToDouble();
                txtSalary.Text = String.Format("{0:C}", sal);
                txtHiredDate.Text = op.objDR.GetDateTime(9).ToShortDateString();
                cboStopWork.Text = op.objDR.GetBoolean(10).ToString();
                if (op.objDR.GetSqlBinary(11).IsNull == true)
                {
                    fp = Path.GetDirectoryName(Application.ExecutablePath);
                    fp = fp + "/Staff.jpg";
                    binpic = System.IO.File.ReadAllBytes(fp);
                }
                else
                {
                    binpic = (byte[])op.objDR.GetSqlBinary(11);
                }
            }
            op.objDR.Close();
            op.objCmd.Dispose();
            //sql = "Exec dbo.spGetPhoto tbStaff, StaffID, " + id;
            //op.objCmd = new SqlCommand(sql, op.objCon);
            //binpic = (byte[])op.objCmd.ExecuteScalar();
            //op.objCmd.Dispose();
            ms = new MemoryStream(binpic);
            Photo.Image = Image.FromStream(ms);
            btnSave.Enabled = true; status = "Old"; 
            
        }


        void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Files (*.*)| *.*|BMP FILE (*.bmp)| *.bmp|"
                      + "JPEG FILE (*.jpg; *.jpeg)| *.jpg; *.jpeg|"
                      + "PNG FILE (*.png)| *.png";
            fd.Title = "OPEN IMAGE FILES:";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                if (fp == null)
                {
                    fp = Path.GetDirectoryName(Application.ExecutablePath);
                    fp = fp + "/Staff.jpg";
                }
                binpic = File.ReadAllBytes(fp);
                ms = new MemoryStream(binpic);
                Photo.Image = Image.FromStream(ms);
            }

        }

        void btnNew_Click(object sender, EventArgs e)
        {
            op.ClearControls(txtNameKH, txtNameEN, cboGender, 
                txtPhone, txtAddress, cboPosition, txtSalary);
            txtID.Focus(); status = "New"; btnSave.Enabled = true;
            cboStopWork.Text = "False";
            fp = Path.GetDirectoryName(Application.ExecutablePath);
            fp = fp + "/Staff.jpg";
            binpic = File.ReadAllBytes(fp);
            ms = new MemoryStream(binpic);
            Photo.Image = Image.FromStream(ms);
        }

        void txtSearch_GotFocus(object sender, EventArgs e)
        {
            op.SetToKhmer();
        }

        void txtNameEN_GotFocus(object sender, EventArgs e)
        {
            op.SetToEnglish();
        }

        void txtNameKH_GotFocus(object sender, EventArgs e)
        {
            op.SetToKhmer();
        }

        void FormStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        void FormStaff_Load(object sender, EventArgs e)
        {
            op.SetConnection(@"OUSSAPHEA\MSSQLSERVER2014",
                "dbProjectCSharpSQLServer");
            sql = "Select * From tbStaff Order By StaffNameKH";
            op.BindListBox(LstStaff, sql, "StaffNameKH", "StaffID");
            sql = "Select Distinct StaffPosition From tbStaff";
            op.PutDataIntoComboBox(sql, cboPosition);
            this.KeyPreview = true;
            btnNew.Focus(); btnSave.Enabled = false;
            if (LstStaff.Items.Count != 0) LstStaff.SetSelected(0, false);   
        }

       
    }
}
