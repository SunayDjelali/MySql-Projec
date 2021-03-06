﻿namespace Shoes
{
    using System;
    using System.Configuration;
    using System.Threading.Tasks;

    public class Connection
    {
        private static string worck = "SELECT * FROM `worck`";
        private static string leave = "SELECT * FROM `leave`";
        private static string manufactured = "SELECT * FROM `manufactured`";
        private static string invoiced = "SELECT * FROM `invoiced`";
        private static string bu = "SELECT * FROM `bu`";
        private static string article = "SELECT * FROM `article`";
        private static string lavoratione = "SELECT * FROM `lavoratione`";
        private static string versions = "SELECT * FROM `versions`";
        private static string foundo = "SELECT * FROM `foundo`";
        private static string linia = "SELECT * FROM `linia`";

        public static string MyConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            }
        }
        public static string TableWorck { get { return Connection.worck; } }
        public static string TableLeave 
        { 
            get 
            {
                return Connection.leave; 
            } 
            set
            {
                Connection.leave = value;
            } 
        }
        public static string TableManufactured { get { return Connection.manufactured; } }
        public static string TableDBInvoced { get { return Connection.invoiced; } }
        public static string TableBu { get { return Connection.bu; } }
        public static string TableArticle { get { return Connection.article; } }
        public static string TableLavoratione { get { return Connection.lavoratione; } }
        public static string TableVersions { get { return Connection.versions; } }
        public static string TableFoundo { get { return Connection.foundo; } }
        public static string TableLinia { get { return Connection.linia; } }
     }
}
