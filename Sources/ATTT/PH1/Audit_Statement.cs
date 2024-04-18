using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATTT;

namespace PH1
{
    public partial class Audit_Statement : Form
    {
        public Audit_Statement()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            Load_AuditOptionCbb();
            Load_UserCbb();
            Load_WhenCbb();
            Load_AuditTb();
        }

        private void Load_AuditOptionCbb()
        {
            AuditOptionCbb.Items.Add("ALL");
            AuditOptionCbb.Items.Add("SELECT TABLE");
            AuditOptionCbb.Items.Add("INSERT TABLE");
            AuditOptionCbb.Items.Add("UPDATE TABLE");
            AuditOptionCbb.Items.Add("DELETE TABLE");
            AuditOptionCbb.Items.Add("ALTER TABLE");
            AuditOptionCbb.Items.Add("EXECUTE PROCEDURE");
            AuditOptionCbb.Items.Add("ALTER SEQUENCE");
            AuditOptionCbb.Items.Add("GRANT DIRECTORY");
            AuditOptionCbb.Items.Add("GRANT PROCEDURE");
            AuditOptionCbb.Items.Add("GRANT SEQUENCE");
            AuditOptionCbb.Items.Add("GRANT TABLE");
            AuditOptionCbb.Items.Add("GRANT TYPE");
            AuditOptionCbb.Items.Add("LOCK TABLE");

            AuditOptionCbb.SelectedIndex = 0;
        }

        private void Load_UserCbb()
        {
            string procName = "USP_GET_USER";
            OracleParameter[] parameters =
            {
                new OracleParameter("CUR_USER", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            DataTable dt = Connection.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
            foreach (DataRow dr in dt.Rows)
            {
                UserCbb.Items.Add(dr["USERNAME"].ToString());
            }
            UserCbb.SelectedIndex = 0;
        }

        private void Load_WhenCbb()
        {
            WhenCbb.Items.Add("ALL");
            WhenCbb.Items.Add("SUCCESSFUL");
            WhenCbb.Items.Add("NOT SUCCESSFUL");
            WhenCbb.SelectedIndex = 0;
        }

        private void Load_AuditTb()
        {
            string procName = "USP_AUDIT_GET_STMT";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            DataTable dt = Connection.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
            AuditTb.DataSource = dt;
        }
        private void AuditBtn_Click(object sender, EventArgs e)
        {
            string auditOption = AuditOptionCbb.SelectedItem.ToString();
            string username = UserCbb.SelectedItem.ToString();
            string when = WhenCbb.SelectedItem.ToString();
            string procName = "USP_AUDIT_ADD_STMT";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_AUDIT_OPTION", OracleDbType.Varchar2, auditOption, ParameterDirection.Input),
                new OracleParameter("P_USER_NAME", OracleDbType.Varchar2, username, ParameterDirection.Input),
                new OracleParameter("P_WHEN", OracleDbType.Varchar2, when, ParameterDirection.Input)
            };
            Connection.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
            Load_AuditTb();
            MessageBox.Show("Thêm Audit thành công!", "Thông báo");

        }
        private void NoAuditBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = AuditTb.SelectedCells[0].RowIndex;
            if (rowIndex < 0) { return; }
            string username = AuditTb.Rows[rowIndex].Cells[0].Value.ToString();
            string auditOption = AuditTb.Rows[rowIndex].Cells[1].Value.ToString();
            string procName = "USP_AUDIT_DELETE_STMT";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_AUDIT_OPTION", OracleDbType.Varchar2, auditOption, ParameterDirection.Input),
                new OracleParameter("P_USER_NAME", OracleDbType.Varchar2, username, ParameterDirection.Input)
            };
            Connection.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
            AuditTb.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Huỷ trạng thái Audit thành công!", "Thông báo");
        }
    }
}
