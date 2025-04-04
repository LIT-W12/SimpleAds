﻿using Microsoft.Data.SqlClient;
using System;

namespace SimpleAds.Data
{
    public static class ReaderExtensions
    {
        public static T GetOrNull<T>(this SqlDataReader reader, string name)
        {
            object value = reader[name];
            if (value == DBNull.Value)
            {
                return default(T);
            }

            return (T)value;
        }
    }
}