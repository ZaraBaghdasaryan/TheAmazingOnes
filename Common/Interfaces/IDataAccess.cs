using Common.Classes;
using System;
using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IDataAccess
    {
        List<T> GetPointsOfAction<T, U>(string sql, U parameters, string connectionString);

        //PointOfAction GetPointOfAction(string Description, string Category, string Accountable, string Project, string Status, DateTime ActionDate);
        //List<PointOfAction> GetPointOfActions(string Description, string Category, string Accountable, string Project, string Status, DateTime ActionDate);

        void SavePointOfAction<T>(string sql, T parameters, string connectionString);
    }
}