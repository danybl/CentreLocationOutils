using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using CentreLocationOutils.exception.db;

namespace CentreLocationOutils.db
{
    public class Connection
    {
        //private OracleConnection connection;

        DbProviderFactory provider = DbProviderFactories.GetFactory("System.Data.OracleClient");
        DbConnection connection;

    private static const string TYPE_SERVEUR_LOCAL = "local";

    //private static const string TYPE_SERVEUR_DISTANT = "distant";

    //private static const string TYPE_SERVEUR_POSTGRES = "postgres";

    //private static const string TYPE_SERVEUR_ACCESS = "access";

    //private static const string SERVEUR_DISTANT_CLASS = "com.mysql.jdbc.Driver";

    private static const string SERVEUR_LOCAL_CLASS = "oracle.jdbc.driver.OracleDriver";

    //private static const string SERVEUR_POSTGRES_CLASS = "org.postgresql.Driver";

    //private static const string SERVEUR_ACCESS_CLASS = "org.postgresql.Driver";

    //private static const string SERVEUR_DISTANT_URL = "jdbc:mysql://localhost:3306/";

    private static const string SERVEUR_LOCAL_URL = "jdbc:oracle:thin:@localhost:1521:";

    //	private static final string SERVEUR_DISTANT_URL = "jdbc:oracle:thin:@collegeahunstic.info:1521:";

    //private static const string SERVEUR_POSTGRES_URL = "jdbc:postgresql:";

    //private static const string SERVEUR_ACCESS_URL = "jdbc:postgresql:";

        public Connection(string typeServeur,
        //string schema,
        string nomUtilisateur,
        string motPasse) {
        string urlBD = null;

        try {
           // DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
            if(typeServeur.Equals(Connection.TYPE_SERVEUR_LOCAL)) {
                connection= provider.CreateConnection();
                connection.ConnectionString=@"Data Source=xe;User ID=" + nomUtilisateur + ";Password="+ motPasse+";Unicode=True";

            } 
           // connection.

        }catch(DbException dbException){
            throw new ConnectionException();
        }
            
     /**
      * Getter de la variable d'instance <code>this.connection</code>.
      *
      * @return La variable d'instance <code>this.connection</code>
      */
        public DbConnection getConnection() {
        return this.connection;
    }
    /**
     * Setter de la variable d'instance <code>this.connection</code>.
     *
     * @param connection La valeur à utiliser pour la variable d'instance <code>this.connection</code>
     */
    private void setConnection(DbConnection connection) {
        this.connection = connection;
    }

        
    /**
     * Effectue un commit sur la {@link java.sql.Connection} JDBC.
     *
     */
        public void close() {
       try{
        getConnection().Close();
        Console.WriteLine("\nConnexion fermée"
            + " "
            + getConnection());
       }catch(DbException dbException){
           throw new ConnectionException();
       }
    }

    }
}
