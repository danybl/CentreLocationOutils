using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.Common;

namespace CentreLocationOutils.db
{
    public class Connexion
    {
        private OdbcConnection connexion;

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
        string schema,
        string nomUtilisateur,
        string motPasse) {
        string urlBD = null;

        try {
            DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
            if(typeServeur.Equals(Connexion.TYPE_SERVEUR_LOCAL)) {
                csb.Add("Provider", Connexion.TYPE_SERVEUR_LOCAL);
                csb.Add("Data Source", Connexion.SERVEUR_LOCAL_CLASS+schema);
                //Class.forName(Connexion.SERVEUR_LOCAL_CLASS);
                //urlBD = Connexion.SERVEUR_LOCAL_URL
                  //  + schema;
            } 
            //else if(typeServeur.Equals(Connexion.TYPE_SERVEUR_DISTANT)) {
            //    Class.forName(Connexion.SERVEUR_DISTANT_CLASS);
            //    urlBD = Connexion.SERVEUR_DISTANT_URL
            //        + schema;
            //} else if(typeServeur.equals(Connexion.TYPE_SERVEUR_POSTGRES)) {
            //    Class.forName(Connexion.SERVEUR_POSTGRES_CLASS);
            //    urlBD = Connexion.SERVEUR_POSTGRES_URL
            //        + schema;
            //} else if(typeServeur.equals(Connexion.TYPE_SERVEUR_ACCESS)) {
            //    Class.forName(Connexion.SERVEUR_ACCESS_CLASS);
            //    urlBD = Connexion.SERVEUR_ACCESS_URL
            //        + schema;
            //} else {
            //    throw new IllegalArgumentException("Type de serveur "
            //        + typeServeur
            //        + "n'est pas valide.");
            //}
            setConnection(DriverManager.getConnection(urlBD,
                nomUtilisateur,
                motPasse));

            // Mettre en mode de commit manuel
            getConnection().setAutoCommit(false);

        }catch(OdbcException odbcException){
            throw new ConnexionException;
        }
    }
}
