using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using TheBetterLimited_Server.Data.Entity;
using static TheBetterLimited_Server.Helpers.SecretConf;


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
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    public static string IssueResetPasswordToken(string username , string emailAddress)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, username),
            new(ClaimTypes.Email, emailAddress),
            new(ClaimTypes.Role, "resetpassword")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Secret.GetValue("Token")));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddMinutes(_Secret["reset_password_expire_time"] is not null ? Int64.Parse(_Secret["reset_password_expire_time"]) : 10),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

}