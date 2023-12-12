using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCSharpSQLServer
{
    public partial class FormStudent : Form
    {
        Operations op = new Operations();
        string sql, status;

        public FormStudent()
        {
            InitializeComponent();
            this.Load += FormStudent_Load;
            this.KeyDown += FormStudent_KeyDown;
            btnNew.Click += btnNew_Click;
            LstStudent.Click += LstStudent_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnSave.Click += btnSave_Click;
            btnClose.Click += btnClose_Click;
            txtSearch.GotFocus += txtSearch_GotFocus;
            txtNameKH.GotFocus += txtNameKH_GotFocus;
        }

        void txtNameKH_GotFocus(object sender, EventArgs e)
        {
            op.SetToKhmer();
        }

        void txtSearch_GotFocus(object sender, EventArgs e)
        {
            op.SetToKhmer();
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            op.CloseForm(this);
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool chk = op.CheckEmpty(errorProvider1, txtNameKH,
                txtNameEN, cboGender, txtBirthDate, txtAddress,
                txtContactAddress);
            if (chk == true) return; // force exit from event
            string snKH, snEN, g, bd, ph, pph, ad, cad, sms = "";
            SqlTransaction t = null;
            op.objCmd = op.objCon.CreateCommand();
            t = op.objCon.BeginTransaction();
            op.objCmd.Connection = op.objCon;
            op.objCmd.Transaction = t;
            try
            {
                snKH = "N'" + txtNameKH.Text + "'";
                snEN = "'" + txtNameEN.Text + "'";
                g = "'" + cboGender.Text + "'";
                bd = "'" + txtBirthDate.Text + "'";
                ph = "'" + txtPhone.Text + "'";
                pph = "'" + txtParentPhone.Text + "'";
                ad = "'" + txtAddress.Text + "'";
                cad = "'" + txtContactAddress.Text + "'";
                if (status == "New")
                {
                    sql = "INSERT INTO tbStudent (StuNameKH, StuNameEN, " 
                        + "Gender, BirthDate, StuPhone, ParentPhone, "
                        + "PersonalAddress, ContactAddress) VALUES ("
                        + snKH + "," + snEN + "," + g + "," + bd + "," 
                        + ph + "," + pph + "," + ad + "," + cad + ")";
                    sms = "Staff's Information was inserted!";
                }
                else if (status == "Old")
                {
                    sql = "UPDATE tbStudent SET StuNameKH = " + snKH 
                        + ", StuNameEN = " + snEN + ", Gender = " + g 
                        + ", BirthDate = " + bd + ", StuPhone = " + ph 
                        + ", ParentPhone = " + pph + ", PersonalAddress = " 
                        + ad + ", ContactAddress = " + cad 
                        + " WHERE StudentID = " + txtID.Text;
                    sms = "Staff's Information was updated!";
                }
                op.RunSQL(sql, t);
                MessageBox.Show(sms, "Information", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                op.objCmd.Dispose();
                t.Commit();
                FormStudent_Load(sender, e);
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
            sql = "SELECT StudentID, StuNameKH FROM tbStudent WHERE "
                + " StuNameKH Like " + sn + " ORDER BY StuNameKH";
            op.BindListBox(LstStudent, sql, "StuNameKH", "StudentID");
            if (LstStudent.Items.Count == 0)
            {
                op.ClearControls(txtID, txtNameKH, txtNameEN, cboGender,
                  txtPhone, txtAddress, txtContactAddress);
                txtBirthDate.Value = DateTime.Today;
                btnSave.Enabled = false;
            }
            else
            {
                sql = "Select * From tbStudent Where StudentID = "
                + LstStudent.SelectedValue.ToString();
                op.DisplayInformation(sql, txtID, txtNameKH, txtNameEN,
                        cboGender, txtBirthDate, txtPhone, txtParentPhone,
                        txtAddress, txtContactAddress);
                txtID.ReadOnly = true;
                status = "Old"; btnSave.Enabled = true;
            }
        }

        void LstStudent_Click(object sender, EventArgs e)
        {
            sql = "Select * From tbStudent Where StudentID = "
                + LstStudent.SelectedValue.ToString();
            op.DisplayInformation(sql, txtID, txtNameKH, txtNameEN,
                    cboGender, txtBirthDate, txtPhone, txtParentPhone,
                    txtAddress, txtContactAddress);
            txtID.ReadOnly = true;
            status = "Old"; btnSave.Enabled = true;
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            op.ClearControls(txtNameKH, txtNameEN, cboGender,
                txtPhone, txtParentPhone, txtAddress, txtContactAddress);
            txtNameKH.Focus();
            txtID.Text = "AutoNumber"; txtID.ReadOnly = true;
            status = "New"; btnSave.Enabled = true;
        }

        void FormStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        void FormStudent_Load(object sender, EventArgs e)
        {
            op.SetConnection("OUSSAPHEA\\MSSQLSERVER2014",
                "dbProjectCSharpSQLServer");
            sql = "Select * From tbStudent Order By StuNameKH";
            op.BindListBox(LstStudent, sql, "StuNameKH", "StudentID");
            this.KeyPreview = true;
            btnNew.Focus(); btnSave.Enabled = false;
            if (LstStudent.Items.Count != 0)
            {
                LstStudent.SetSelected(0, true);
                sql = "Select * From tbStudent Where StudentID = " 
                    + LstStudent.SelectedValue.ToString();
                op.DisplayInformation(sql, txtID, txtNameKH, txtNameEN, 
                    cboGender, txtBirthDate, txtPhone, txtParentPhone, 
                    txtAddress, txtContactAddress);
                status = "Old"; btnSave.Enabled = true;
            }
        }
    }
}
