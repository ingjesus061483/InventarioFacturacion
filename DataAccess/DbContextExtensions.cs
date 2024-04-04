using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DbContextExtensions
    {
        public static DataTable GetDataTable(this DbContext context, string sqlQuery)
        {
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(context.Database.Connection);

            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = context.Database.Connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                {
                    adapter.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
        public static void EjecutarComando(this DbContext context, string sqlQuery)
        {
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(context.Database.Connection);
            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = context.Database.Connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                cmd.ExecuteNonQuery();
            }
        }
        public static DataRow GetColumn(this DbContext context, string tableName, string column)
        {
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(context.Database.Connection);

            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = context.Database.Connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select COLUMN_NAME columna,DATA_TYPE tipo from INFORMATION_SCHEMA.COLUMNS " +
                                  "where TABLE_NAME='" + tableName + "' and COLUMN_NAME='" + column + "'";
                using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                {
                    adapter.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt.Rows[0];
                }
            }
        }
        public  static DbCommand GetCommand(this DbContext context, string sqlQuery)
        {
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(context.Database.Connection);

            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = context.Database.Connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                return cmd;
            }
        }
        public static void ExecuteComandWithParammeters(DbCommand command , List<DbParameter> parameters, DataTable table)
        {
            try
            {
                command.Parameters.AddRange(parameters.ToArray());
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        command.Parameters[col.ColumnName].Value = row[col];
                    }
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        
    }
}
