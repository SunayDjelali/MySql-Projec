using System.Threading.Tasks;

namespace CSharpMySqlSample
{
    public class Connection
    {
        private static string worck = "select * from worck";
        private static string bu = "select * from bu";
        private static string article = "select * from article";
        private static string lavoratione = "select * from lavoratione";
        private static string versions = "select * from versions";
        private static string foundo = "select * from foundo";
        private static string linia = "select * from linia";
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

     }
}
