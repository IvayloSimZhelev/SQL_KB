using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient; 

namespace SQL_KB
{


    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Utils.recolorListItems(lswSQLItems);

            tstAddNewSrvr.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tstAddNewSrvr.TextAlign = ContentAlignment.BottomLeft;
            tstAddNewSrvr.TextImageRelation = TextImageRelation.ImageBeforeText;
            tstAddNewSrvr.AutoCompleteCustomSource = Utils.GetAutoComplSQLs();

            cmsTW.ImageList = imageList1;
            tstAddNewSrvr.ImageIndex = 0;

            SQL oSQL = new SQL();
            ListViewItem item = null;
            Pair oPair = null;

            oSQL.SQLIP = "bla-bla-bla";

            oSQL.SQLName = "bla-bla-bla";

            foreach (var item1 in oSQL.GetType().GetProperties())
            {
                item = new ListViewItem(item1.Name);
                item.SubItems.Add((item1.GetValue(oSQL, null) == null ? "" : item1.GetValue(oSQL, null).ToString()));
                lswSQLItems.Items.Add(item);
            }

            foreach (var item1 in oSQL.GetType().GetFields())
            {
                oPair = (Pair)(item1.GetValue(oSQL));
                item = new ListViewItem(oPair.Name);
                item.SubItems.Add(oPair.Value);
                lswSQLItems.Items.Add(item);
                (lswSQLItems.Items[item.Index]).Tag = oPair;
            }

            Utils.recolorListItems(lswSQLItems);

        }

        private void lswSQLItems_Click(object sender, EventArgs e)
        {

            if (((ListView)sender).SelectedItems[0].Tag == null)
            {
                lblDescr.Text = "...";
            }
            else
            {
                lblDescr.Text = ((Pair)(((ListView)sender).SelectedItems[0].Tag)).Descr;
            }
        }

        private void AddNewSQLSrvr(string sqlServerName)
        {
            try
            {
                Utils.ConfigSet("SQLs" + DateTime.Now.ToString ("yyyymmddThhmmss"), tstAddNewSrvr.Text );
                MessageBox.Show(sqlServerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void KBTreeView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                KBTreeView.SelectedNode = KBTreeView.GetNodeAt(e.X, e.Y);

                if ((KBTreeView.SelectedNode != null) && (KBTreeView.SelectedNode.Name == "Root"))
                {
                    tstAddNewSrvr.SelectAll();
                    cmsTW.Show(KBTreeView, e.Location);
                    tstAddNewSrvr.Focus();
                }
            }
        }

        private void cmsTW_Paint(object sender, PaintEventArgs e)
        {
            const int iconSize = 16;
            if (e.ClipRectangle.IntersectsWith(tstAddNewSrvr.Bounds))
            {
                float x = (26 / 2) - (iconSize / 2);
                float y = tstAddNewSrvr.Bounds.Y + ((tstAddNewSrvr.Bounds.Height / 2) - (iconSize / 2));
                e.Graphics.DrawImage(tstAddNewSrvr.Image, x, y);
            }
        }

        //[Microsoft.SqlServer.Server.SqlProcedure]
        //public static void CreateNewRecord()
        //{
        //    // Variables.
        //    SqlMetaData column1Info;
        //    SqlMetaData column2Info;
        //    SqlMetaData column3Info;
        //    SqlDataRecord record;

        //    // Create the column metadata.
        //    column1Info = new SqlMetaData("Column1", SqlDbType.NVarChar, 12);
        //    column2Info = new SqlMetaData("Column2", SqlDbType.Int);
        //    column3Info = new SqlMetaData("Column3", SqlDbType.DateTime);

        //    // Create a new record with the column metadata.      
        //    record = new SqlDataRecord(new SqlMetaData[] { column1Info,
        //                                          column2Info,
        //                                          column3Info });

        //    // Set the record fields.
        //    record.SetString(0, "Hello World!");
        //    record.SetInt32(1, 42);
        //    record.SetDateTime(2, DateTime.Now);

        //    // Send the record to the calling program.
        //    SqlContext.Pipe.Send(record);
        //}


        //public static void getDatabaseMetaData(string SQLIP, string SQLDB, string SQLUser, string SQLPass)
        //{
        //    try
        //    {
        //        string connString = String.Format(@"Data Source = {0}; Initial Catalog = {1}; Persist Security Info = true; User ID = {2}; Password = {3}",
        //                                                      SQLIP, SQLDB, SQLUser, SQLPass);

        //        using (SqlConnection conn = new SqlConnection(connString))
        //        {
        //            conn.Open();

        //            DatabaseMetaData dbmd = conn. ();
        //            MessageBox.Show("dbmd:driver version = " + dbmd.getDriverVersion() + "\n" +
        //                             "dbmd:driver name = " + dbmd.getDriverName() + "\n" +
        //                             "db name = " + dbmd.getDatabaseProductName() + "\n" +
        //                             "db ver = " + dbmd.getDatabaseProductVersion() + "\n";
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message.ToString () );
        //    }
        //}


        private void button1_Click(object sender, EventArgs e)
        {


            Microsoft.SqlServer.Management.SqlParser.Parser.ParseOptions parseOptions = new Microsoft.SqlServer.Management.SqlParser.Parser.ParseOptions();
            parseOptions.BatchSeparator = "GO";

            Microsoft.SqlServer.Management.SqlParser.Parser.Scanner parser = new Microsoft.SqlServer.Management.SqlParser.Parser.Scanner(parseOptions);

            //string Sql = @"Create Procedure MyProc as Select top(10) * from dbo.Table";


            //string Sql = @"Create Procedure MyProc as Select top(10) * from dbo.Table";

            string Sql = @"select*
                           from cust_service_order cso (nolock)
                           where NOT EXISTS(SELECT 1 FROM dbo.camp_ro_data z(nolock) WHERE z.ro_id = cso.service_ord_id1)";





            parser.SetSource(Sql, 0);

            int state = 0, start, end, token;
            bool pair, param;
            string tokenName = "", tokenValue = "";
            do
            {
                token = parser.GetNext(ref state, out start, out end, out pair, out param);
                tokenName = ((Microsoft.SqlServer.Management.SqlParser.Parser.Tokens)token).ToString();
                if (tokenName != "EOF")
                {
                    tokenValue = Sql.Substring(start, (end - start) + 1);
                    MessageBox.Show(tokenName + ":" + tokenValue);
                }

                // Do some stuff here with the token
            } while (token != 128); // 128 signifies the end of the query


            //MessageBox.Show(DateTime.Now.ToString("yyyymmddThhmss"));
            //getDatabaseMetaData("10.55.207.29", "NissanNNA", "nnadb", "!tms991");

            //CreateNewRecord();
        }

        private void tstAddNewSrvr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewSQLSrvr(tstAddNewSrvr.Text);
        }
    }
}
