using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SqlCleanerHelper
{
    public partial class SqlCleanForm : Form
    {
        public SqlCleanForm()
        {
            InitializeComponent();
        }

        private void btnCleanFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Filter = "SQL|*.sql",
                DefaultExt = "sql"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                if (string.IsNullOrEmpty(fileName))
                    return;
                var sql = File.ReadAllText(fileName);
                sql = CleanSql(sql);
                File.WriteAllText(fileName, sql);

                tbSqlFile.Text = fileName;
            }
        }

        private void tbSqlFile_MouseClick(object sender, MouseEventArgs e)
        {
            btnCleanFile_Click(sender, EventArgs.Empty);
        }

        private void btnCleanText_Click(object sender, EventArgs e)
        {
            var newSql = CleanSql(tbSqlText.Text);
            tbSqlText.Text = newSql;
        }

        private string CleanSql(string sql)
        {
            var keywordsList = new List<string> {
                "add", "alter", "all", "and", "any", "as", "asc", "select", "by", "bulk", "commit", "tran", "rollback",
                "between", "backup", "constraint", "column", "case", "check", "create", "count", "drop", "rowcount",
                "exec", "exists", "table", "database", "delete", "desc", "distinct", "index", "procedure", "revert",
                "stored", "unique", "view", "default", "foreign", "primary", "key", "from", "where", "group", "join",
                "left", "right", "full", "inner", "outer", "having", "in", "insert", "into", "is", "null", "not", "like",
                "limit", "or", "order", "apply", "rownum", "top", "set", "update", "truncate", "union", "values",
                "declare", "fillfactor", "raiserror", "reconfigure", "freetext", "return", "goto", "break", "function",
                "max", "identity", "identity_insert", "close", "if", "while", "clustered", "coalesce", "isnull",
                "collate", "object_id", "continue", "convert", "cast", "kill", "nonclustered", "cursor", "transaction",
                "nullif", "open", "pivot", "unpivot", "disk", "openquery", "trigger", "double", "option", "dump", "except",
                "execute", "with", "print", "proc", "exit", "percent", "over", "waitfor", "varying", "deallocate", "go",
                "use", "int", "bigint", "char", "varchar", "nvarchar", "varbinary", "sysname", "datetime", "numeric",
                "begin", "end", "else", "on", "sum", "avg", "when", "then", "dense_rank", "binary", "error_number",
                "error_severity", "error_state", "error_procedure", "error_line", "error_message", "try", "catch",
                "substring", "charindex", "reverse", "quotename", "fetch_status", "first", "fetch", "dynamic", "log",
                "getdate", "datediff", "minute", "second", "hour", "returns", "row_number", "bit", "rtrim", "ltrim",
                "output", "inserted", "deleted"
            };
            
            // Change all keywords in list to upper case
            sql = Regex.Replace(sql, "\\w+", (Match m) =>
            {
                return keywordsList.Contains(m.Value.ToLower()) ? m.Value.ToUpper() : m.Value;
            });

            return sql;
        }
    }
}
