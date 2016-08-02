using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace DatabaseClassConverter
{
    public partial class MainForm : Form
    {
        public Dictionary<string, string> DicColumnDefintions = new Dictionary<string, string>();

        public void InitColumnDefinitions() 
        {
            // DB Type, C# Type
            DicColumnDefintions.Add("int", "int");
            DicColumnDefintions.Add("int identity", "int");
            DicColumnDefintions.Add("varchar", "string");
            DicColumnDefintions.Add("nvarchar", "string");
            DicColumnDefintions.Add("text", "string");
            DicColumnDefintions.Add("ntext", "string");
            DicColumnDefintions.Add("datetime", "DateTime");
            DicColumnDefintions.Add("timestamp", "DateTime");
            
        }

        public MainForm()
        {
            InitializeComponent();
            InitColumnDefinitions();
            textBox_RenderedClass.ShortcutsEnabled = true;
        }

        private void button_GetTables_Click(object sender, EventArgs e)
        {

            listBox_TableListing.Items.Clear();

            try
            {
                if (!String.IsNullOrEmpty(textBox_ConnectionString.Text))
                {
                    var tableLists = GetTablesFromDatabase(textBox_ConnectionString.Text);

                    if(tableLists.Count() > 0)
                    {
                        listBox_TableListing.Items.AddRange(tableLists.ToArray());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        private List<String> GetTablesFromDatabase(string connString)
        {
            List<String> tableList = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = "exec sp_tables";

                    SqlCommand command = new SqlCommand(sql, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string tableQualifier = reader["TABLE_QUALIFIER"].ToString();
                            string tableOwner = reader["TABLE_OWNER"].ToString();
                            string tableName = reader["TABLE_NAME"].ToString();
                            string tableType = reader["TABLE_TYPE"].ToString();

                            if (tableType.ToLower() != "table")
                                continue;

                            if (tableOwner.ToLower() != "dbo")
                                continue;

                            tableList.Add(tableName);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tableList;
        }

        private void button_GetTableDefinition_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_TableListing.SelectedItem == null)
                {
                    throw new Exception("No table selected.");
                }

                dataGridView_TableDefinition.Rows.Clear();
                label_TableName.Text = "";

                string tableName = listBox_TableListing.SelectedItem.ToString();

                label_TableName.Text = tableName;

                // Populate the datagrid view.
                using (SqlConnection conn = new SqlConnection(textBox_ConnectionString.Text))
                {
                    conn.Open();

                    string sql = "exec sp_columns " + tableName;

                    SqlCommand command = new SqlCommand(sql, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView_TableDefinition.Rows.Add(
                                reader["COLUMN_NAME"],
                                reader["TYPE_NAME"],
                                reader["LENGTH"],
                                reader["NULLABLE"]
                            );
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_RenderClassDefinition_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_TableDefinition.Rows.Count < 1)
                {
                    throw new Exception("No column/table definition to render.");
                }

                List<TableColumn> columnList = new List<TableColumn>();

                var rows = dataGridView_TableDefinition.Rows;

                foreach (DataGridViewRow row in rows)
                {
                    TableColumn t = new TableColumn();

                    t.col_name = Convert.ToString(row.Cells[0].Value);
                    t.col_type = Convert.ToString(row.Cells[1].Value);
                    t.col_length = Convert.ToInt32(row.Cells[2].Value);
                    t.col_nullable = Convert.ToInt32(row.Cells[3].Value);


                    columnList.Add(t);
                }

                if (columnList.Count() > 0)
                {
                    RenderToClassDefinition(label_TableName.Text, columnList);
                }
                else
                {
                    throw new Exception("Somehow there's no columns to be rendered. Bug?");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RenderToClassDefinition(string tableName, List<TableColumn> columns)
        {
            StringBuilder sb = new StringBuilder();

            // Templates
            string template_PC_TableName = @"[PetaPoco.TableName(""{0}"")]";
            string template_PC_PrimaryKey = @"[PetaPoco.PrimaryKey(""{0}"")]";
            string template_CC_Class = @"public class {0}";
            string template_PC_Column = @"	[PetaPoco.Column(""{0}"")]";
            string template_CC_definition = @"	public {0}{1} {2} {{ get; set; }} ";

            // Render the table name first
            sb.AppendLine(String.Format(template_PC_TableName, tableName));

            // Try to find Primary Key; if not, then don't render it.
            TableColumn primaryKeyColumn = null;

            foreach (var c in columns)
            {
                if (c.col_type.Contains("identity"))
                {
                    // primaryKeyColumn = c;

                    sb.AppendLine(String.Format(template_PC_PrimaryKey, c.col_name));
                    break;
                }
            }

            sb.AppendLine(String.Format(template_CC_Class, tableName));

            sb.AppendLine("{");


            foreach (var col in columns)
            {
                if (checkBox_RenderColumnDefinition.Checked)
                {
                    sb.AppendLine(String.Format(template_PC_Column, col.col_name));
                }

                string dataType = "";
                string nullable = "";
                string columnName = col.col_name;

                if (!DicColumnDefintions.TryGetValue(col.col_type, out dataType))
                {
                    dataType = "string";
                }


                if (col.col_nullable == 1)
                {
                    if (dataType != "string")
                    {
                        nullable = "?";
                    }
                }

                sb.AppendLine(String.Format(template_CC_definition, dataType, nullable, columnName));

                sb.AppendLine("");
            }


            sb.AppendLine("}");

            sb.AppendLine("");

            string output = sb.ToString();

            // textBox_RenderedClass.Text = "";

            textBox_RenderedClass.Text += output;
        }

        private void button_ConvertAllTables_Click(object sender, EventArgs e)
        {

            List<TableColumn> tableColumnList = new List<TableColumn>();

            try
            {

                if (listBox_TableListing.Items.Count > 0)
                {
                    foreach (var item in listBox_TableListing.Items)
                    {
                        var tableName = item.ToString();

                        if (!String.IsNullOrEmpty(tableName))
                        {
                            // Populate the datagrid view.
                            using (SqlConnection conn = new SqlConnection(textBox_ConnectionString.Text))
                            {
                                conn.Open();
                                string sql = "exec sp_columns " + tableName;
                                SqlCommand command = new SqlCommand(sql, conn);
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.HasRows)
                                {

                                    tableColumnList = new List<TableColumn>();

                                    while (reader.Read())
                                    {
                                        TableColumn tb = new TableColumn()
                                        {
                                            col_name = reader["COLUMN_NAME"].ToString(),
                                            col_type = reader["TYPE_NAME"].ToString(),
                                            col_length = Convert.ToInt32(reader["LENGTH"]),
                                            col_nullable = Convert.ToInt32(reader["NULLABLE"])
                                        };

                                        tableColumnList.Add(tb);
                                    }

                                    RenderToClassDefinition(tableName, tableColumnList);

                                }

                            }
                        }

                        // MessageBox.Show("Batch converted all tables to C# Classes (See output window.)");
                    }
                }
                else
                {
                    throw new Exception("No tables found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_RenderedClass.Text);
        }

    }

    public class TableColumn
    {
        public string col_name { get; set; }
        public string col_type { get; set; }
        public int col_length { get; set; }
        public int col_nullable { get; set; }
    }
}
