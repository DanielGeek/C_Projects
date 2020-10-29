using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMySql
{
    class settings_mysql
    {
        //definimos atributos constantes de la conexión
        // Zona horaria para chile
        private TimeZoneInfo myZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific SA Standard Time");
        private const String host = "localhost";
        private const String user = "root";
        private const String password = "";
        private const String nombreBD = "balanzadinamica";

        // definimos propiedades
        public TimeZoneInfo MyZone
        {
            get
            {
                return myZone;
            }
        }
        public String Host
        {
            get
            {
                return host;
            }
        }
        public String User
        {
            get
            {
                return user;
            }
        }
        public String Password
        {
            get
            {
                return password;
            }
        }
        public String NombreBD
        {
            get
            {
                return nombreBD;
            }
        }

    }
}
