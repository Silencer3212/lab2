// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ProtectedWeb
{
    public class AuthOptions
    {
        const string KEY = "f2L!$G5s9&3@pCqW";
        public const int LIFETIME = 60; // min
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
