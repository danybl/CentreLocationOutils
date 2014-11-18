using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace CentreLocationOutils.db
{
    public class Connexion
    {
        //private OracleConnection connection;

        DbProviderFactory provider = DbProviderFactories.GetFactory("System.Data.OracleClient");
        DbConnection connection;

    private static const String TYPE_SERVEUR_LOCAL = "local";

    //private static const String TYPE_SERVEUR_DISTANT = "distant";

    //private static const String TYPE_SERVEUR_POSTGRES = "postgres";

    //private static const String TYPE_SERVEUR_ACCESS = "access";

    //private static const String SERVEUR_DISTANT_CLASS = "com.mysql.jdbc.Driver";

    private static const String SERVEUR_LOCAL_CLASS = "oracle.jdbc.driver.OracleDriver";

    //private static const String SERVEUR_POSTGRES_CLASS = "org.postgresql.Driver";

    //private static const String SERVEUR_ACCESS_CLASS = "org.postgresql.Driver";

    //private static const String SERVEUR_DISTANT_URL = "jdbc:mysql://localhost:3306/";

    private static const String SERVEUR_LOCAL_URL = "jdbc:oracle:thin:@localhost:1521:";

    //	private static final String SERVEUR_DISTANT_URL = "jdbc:oracle:thin:@collegeahunstic.info:1521:";

    //private static const String SERVEUR_POSTGRES_URL = "jdbc:postgresql:";

    //private static const String SERVEUR_ACCESS_URL = "jdbc:postgresql:";

        public Connexion(String typeServeur,
        //string schema,
        string nomUtilisateur,
        string motPasse) {
        string urlBD = null;

        try {
           // DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
            if(typeServeur.Equals(Connexion.TYPE_SERVEUR_LOCAL)) {
                connection= provider.CreateConnection();
                connection.ConnectionString=@"Data Source=xe;User ID=" + nomUtilisateur + ";Password="+ motPasse+";Unicode=True";

            } 
           // connection.

        }catch(DbException dbException){
            throw new ConnectionException;
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
        rollback();
        getConnection().Close();
        Console.WriteLine("\nConnexion fermée"
            + " "
            + getConnection());
       }catch(DbException dbException){
           throw new ConnectionException
       }
    }

    /**
     * Effectue un rollback sur la {@link java.sql.Connection} JDBC.
     *
     */
    public void rollback() {
        getConnection().rollback();
    }

    }
}
