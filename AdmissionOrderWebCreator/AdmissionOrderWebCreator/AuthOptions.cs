using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionOrderWebCreator
{
    public class AuthOptions
    {
        public const string ISSUER = "FroniusMonitoring2Api";
        public const string AUDIENCE = "FroniusMonitoring2WebClient";
        const string KEY = "Punks not dead Punks not dead Punks not dead";
        public const int LIFETIME = 100; // время жизни токена - 100 минут(а)
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
        }
    }
}
