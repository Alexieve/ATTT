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
    public partial class Audit_View : Form
    {
        public Audit_View()
        {
            InitializeComponent();
            Load(null);
            Load_State();
        }
        private void Load(string keyword)
        {

            string procName = "USP_AUDIT_GET_USER_AUDIT_TRAIL";
            OracleParameter[] parameters =
            {
                new("P_RES", OracleDbType.RefCursor, ParameterDirection.Output),
                new("P_KEYWORD", OracleDbType.Varchar2, ParameterDirection.Input) { Value = keyword }
            };
            DataTable dt = Connection.ExecuteQuery(procName, CommandType.StoredProcedure, parameters);
            AuditTb.DataSource = dt;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = SearchBox.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else Load(keyword);
        }
    }
}
