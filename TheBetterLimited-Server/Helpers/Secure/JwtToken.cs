using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using TheBetterLimited_Server.Data.Entity;
using static TheBetterLimited_Server.Helpers.SecretConf;
using TheBetterLimited_Server.Helpers.LogHelper;


namespace TheBetterLimited_Server.Helpers.Secure;

public static class JwtToken
{
    public static string Issue(Account user)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.UserName),
            new(ClaimTypes.Role, "admin")
        };


        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Secret.GetValue("Token")));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddHours(10),
            signingCredentials: creds
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        return jwt;
    }


    internal static ClaimsPrincipal ReadToken(string token)
    {
        var jwtSecurityHandler = new JwtSecurityTokenHandler();
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Secret.GetValue("Token")))
        };
        var principal = jwtSecurityHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);
        return principal;
    }


    public static string IssueResetPasswordToken(string username , string emailAddress, string lang)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, username),
            new(ClaimTypes.Email, emailAddress),
            new(ClaimTypes.Country, lang),
            new(ClaimTypes.Role, "resetpassword")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Secret.GetValue("Token")));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddMinutes(Int32.Parse(_Secret["reset_password_expire_time"])),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

}