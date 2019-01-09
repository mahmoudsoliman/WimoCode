using System;
using System.Collections.Generic;
using System.Text;

namespace Wimo.Models
{
    public static class Helpers
    {
        public static string GenerateUniqueKey(int keyLength = 10)
        {
            string result = Guid.NewGuid().ToString();

            if (result.Length > keyLength)
                result = result.Substring(0, keyLength);

            return result;
        }
    }
}
