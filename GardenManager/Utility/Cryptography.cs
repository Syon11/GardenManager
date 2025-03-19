using System.Security.Cryptography;
using System.Text;

namespace GardenManager.Utility;

public static class Cryptography
{
    public static string HashSHA256(string PlainText)
    {
        StringBuilder sb = new StringBuilder();
        using (SHA256 hash = SHA256.Create())
        {
            byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(PlainText));
            foreach (Byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
        }
        return sb.ToString();
    }
}