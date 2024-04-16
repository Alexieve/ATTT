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
using Oracle.ManagedDataAccess.Client;

namespace PH1
{
    public partial class Audit_Object : Form
    {
        private string[] auditOption_Arr = { "ALL", "ALTER", "AUDIT", "COMMENT", "DELETE", "GRANT", "INDEX", "INSERT", "LOCK", "RENAME", "SELECT", "UPDATE", "EXECUTE", "CREATE", "FLASHBACK" };

        private int[][] auditChoice_Arr =
        [
            [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1],
            [1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1],
            [1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0]
        ];
        public Audit_Object()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            Load_ObjTypeCbb();
            Load_AuditOptionCbb();
            Load_ObjectCbb();
            Load_WhenCbb();
            Load_AuditTb();
        }

        private void Load_ObjTypeCbb()
        {
            ObjTypeCbb.Items.Add("TABLES");
            ObjTypeCbb.Items.Add("VIEW");
            ObjTypeCbb.Items.Add("PROCEDURE / FUNCTION");
            ObjTypeCbb.SelectedIndex = 0;
        }
        
        private void Load_AuditOptionCbb()
        {
            AuditOptionCbb.Items.Clear();
            for (int i = 0; i < auditOption_Arr.Length; i++)
                if (auditChoice_Arr[ObjTypeCbb.SelectedIndex][i] == 1)
                    AuditOptionCbb.Items.Add(auditOption_Arr[i]);

            AuditOptionCbb.SelectedIndex = 0;
        }

        private void Load_ObjectCbb()
        {
            ObjectCbb.Items.Clear();
            string procName;
            switch (ObjTypeCbb.SelectedIndex)
            {
                case 0:
                    procName = "USP_GET_TABLE_NAME";
                    break;
                case 1:
                    procName = "USP_GET_VIEW_NAME";
                    break;
                case 2:
                    procName = "USP_GET_PROCEDURE_FUNCTION_NAME";
                    break;
                default:
                    procName = "USP_GET_TABLE_NAME";
                    break;
            }
            OracleParameter[] parameters =
            {
                // RETURN VALUES P_TABLE_NAMES
                new OracleParameter("P_TABLE_NAMES", OracleDbType.RefCursor, ParameterDirection.ReturnValue)
            };
            DataTable dt = Connection.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
            foreach (DataRow dr in dt.Rows)
            {
                ObjectCbb.Items.Add(dr[0].ToString());
            }
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
            string procName = "USP_AUDIT_GET_OBJ";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_RES", OracleDbType.RefCursor, ParameterDirection.Output)
            };
            DataTable dt = Connection.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
            AuditTb.DataSource = dt;
            AuditTb.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AuditTb.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ObjTypeCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_AuditOptionCbb();
            Load_ObjectCbb();
        }
        private void AuditBtn_Click(object sender, EventArgs e)
        {
            string auditOption = AuditOptionCbb.SelectedItem.ToString();
            string objName = ObjectCbb.SelectedItem.ToString();
            string when = WhenCbb.SelectedItem.ToString();
            string procName = "USP_AUDIT_ADD_OBJ";
            OracleParameter[] parameters = {
                new OracleParameter("P_AUDIT_OPTION", auditOption),
                new OracleParameter("P_OBJ_NAME", objName),
                new OracleParameter("P_WHEN", when)
            };
            Connection.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
            Load_AuditTb();
            MessageBox.Show("Thêm Audit thành công!", "Thông báo");
        }

        private void NoAuditBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = AuditTb.SelectedCells[0].RowIndex;
            if (rowIndex < 0) { return; }

            string objName = AuditTb.Rows[rowIndex].Cells[0].Value.ToString();
            string auditOption;
            int columnIndex = AuditTb.SelectedCells[0].ColumnIndex;
            if (columnIndex < 2)
            {
                auditOption = "ALL";
            }
            else
            {
                auditOption = auditOption_Arr[columnIndex - 1];
            }

            string procName = "USP_AUDIT_DELETE_OBJ";
            OracleParameter[] parameters =
            {
                new OracleParameter("P_AUDIT_OPTION", auditOption),
                new OracleParameter("P_OBJ_NAME", objName)
            };
            Connection.ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
            Load_AuditTb();
            MessageBox.Show("Xóa Audit thành công!", "Thông báo");
        }
    }
}
