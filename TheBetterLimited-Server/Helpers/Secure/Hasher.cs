using System.Security.Cryptography;

namespace TheBetterLimited_Server.Helpers.Secure;

public static class Hasher
{
    private const int SaltSize = 16;

    private const int HashSize = 20;

    private readonly static string header = "$HASH|V1";

    public static string Hash(this string password, int iterations)
    {
        // Create salt
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] salt;
            rng.GetBytes(salt = new byte[SaltSize]);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                var hash = pbkdf2.GetBytes(HashSize);
                // Combine salt and hash
                var hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);
                // Convert to base64
                var base64Hash = Convert.ToBase64String(hashBytes);

                // Format hash with extra information
                return $"{header}${iterations}${base64Hash}";
            }
        }
    }

    public static string Hash(this string password)
    {
        return password.Hash(10000);
    }

    public static bool IsHashSupported(this string hashString)
    {
        return hashString.Contains($"{header}");
    }

    public static bool Verify(this string password, string hashedPassword)
    {
        // Check hash
        if (! hashedPassword.IsHashSupported() )
            throw new NotSupportedException("The hashtype is not supported");

        // Extract iteration and Base64 string
        var splittedHashString = hashedPassword.Replace($"{header}$", "").Split('$');
        var iterations = int.Parse(splittedHashString[0]);
        var base64Hash = splittedHashString[1];

        // Get hash bytes
        var hashBytes = Convert.FromBase64String(base64Hash);

        // Get salt
        var salt = new byte[SaltSize];
        Array.Copy(hashBytes, 0, salt, 0, SaltSize);

        // Create hash with given salt
        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
        {
            var hash = pbkdf2.GetBytes(HashSize);

            // Get result
            for (var i = 0; i < HashSize; i++)
                if (hashBytes[i + SaltSize] != hash[i])
                    return false;

            return true;
        }
    }
}