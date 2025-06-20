using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Text.Json;
using SS_Desktop.Models;

namespace SS_Desktop.Libraries.SignedIn
{
    public class UserSigned
    {
        private static string userSigned = "ActualUserSignedIn.json";

        public static void SetUserSigned(User user)
        {
            string jsonUser = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            File.WriteAllText(userSigned, jsonUser);
        }

        public static User? GetUserSigned()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            if (!File.Exists(userSigned))
            {
                File.WriteAllText("ActualUserSignedIn.json", "");
            }
            var jsonUser = File.ReadAllText(userSigned);
            return !string.IsNullOrEmpty(jsonUser) ? JsonSerializer.Deserialize<User>(jsonUser, options) : null;
        }
    }
}
