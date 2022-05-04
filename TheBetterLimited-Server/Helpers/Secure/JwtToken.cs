using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Helpers.Secure
{
	public static class JwtToken
	{
		public static string Issue(Account user)
        {
			List<Claim> claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name , user.UserName),
				new Claim(ClaimTypes.Role, "admin")
			};


            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Helpers.SecretConf.Instance.GetValue("Token")));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
	}
}

