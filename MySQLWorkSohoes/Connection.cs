namespace CSharpMySqlSample
{
    using System.Threading.Tasks;
    public class Connection
    {
        private static string worck = "SELECT * FROM `worck`";
        private static string bu = "SELECT * FROM `bu`";
        private static string article = "SELECT * FROM `article`";
        private static string lavoratione = "SELECT * FROM `lavoratione`";
        private static string versions = "SELECT * FROM `versions`";
        private static string foundo = "SELECT * FROM `foundo`";
        private static string linia = "SELECT * FROM `linia`";
        private static string manufactured = "SELECT * FROM `manufactured`";
        private static string leave = "SELECT * FROM `leave`";
        public static string MyConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            }
        }
        public static string TableWorck { get { return worck; } }
        public static string TableBu { get { return bu; } }
        public static string TableArticle { get { return article; } }
        public static string TableLavoratione { get { return lavoratione; } }
        public static string TableVersions { get { return versions; } }
        public static string TableFoundo { get { return foundo; } }
        public static string TableLinia { get { return linia; } }
        public static string TableManufactured { get { return manufactured; } }
        public static string TableLeave { get { return leave; } }

     }
}
