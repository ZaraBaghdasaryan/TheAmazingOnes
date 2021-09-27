using Common.Interfaces;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Common.Enum;

namespace Common.Classes
{
    public class DataAccess : IDataAccess
    {
        //public PointOfAction GetPointOfAction(string Description, string Category, string Accountable, string Project, string Status, DateTime ActionDate)
        //{
        //    var _oPointsOfAction = new List<PointOfAction>();
        //    using (IDbConnection con = new SqlConnection("DagligStyrningDB"))
        //    {

        //        string sql = string.Format(@"SELECT * FROM PointsOfAction", ActionDate.ToString("dd-MMM-yyyy"));

        //        var oPointsOfAction = con.Query<PointOfAction>(sql).ToList();

        //        if (oPointsOfAction != null && oPointsOfAction.Count() > 0)
        //        {
        //            _oPointsOfAction = oPointsOfAction;
        //        }
        //    }


        public List<T> GetPointsOfAction<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();

                return rows;
            }
        }

        public void SavePointOfAction<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, parameters);
            }
        }
    }
}
