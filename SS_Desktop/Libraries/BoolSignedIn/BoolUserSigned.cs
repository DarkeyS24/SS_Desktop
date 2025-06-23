using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Text.Json;
using SS_Desktop.Models;

namespace SS_Desktop.Libraries.BoolSignedIn
{
    public class BoolUserSigned
    {
        private static string userSigned = "BoolSignedIn.json";

        public static void SetUserSigned(int index)
        {
            string jsonSigned = JsonSerializer.Serialize(index, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            File.WriteAllText(userSigned, jsonSigned);
        }

        public static int? GetUserSigned()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            if (!File.Exists(userSigned))
            {
                File.WriteAllText("BoolSignedIn.json", "");
            }
            var jsonSigned = File.ReadAllText(userSigned);
            return !string.IsNullOrEmpty(jsonSigned) ? JsonSerializer.Deserialize<int>(jsonSigned, options) : null;
        }
    }
}
