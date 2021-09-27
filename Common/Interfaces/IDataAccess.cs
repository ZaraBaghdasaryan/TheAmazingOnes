using Common.Classes;
using System;
using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IDataAccess
    {
        List<T> GetPointsOfAction<T, U>(string sql, U parameters, string connectionString);
        void SavePointOfAction<T>(string sql, T parameters, string connectionString);
    }
}