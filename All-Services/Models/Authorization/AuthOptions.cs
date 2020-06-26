using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace All_Services.Models.Authorization
{
    public class AuthOptions
    {
        public const string ISSUER = "AllServicesServer"; // издатель токена
        public const string AUDIENCE = "AllServicesClient"; // потребитель токена
        const string KEY = "dev_security_key!";   // ключ для шифрации
        public const int LIFETIME = 30000; // время жизни токена - 1 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
