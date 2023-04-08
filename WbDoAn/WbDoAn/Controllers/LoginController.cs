using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using WbDoAn.Models;

namespace WbDoAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]

        [Route("registration")]
        public string registration(Account account)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("dbshoplinkkien").ToString());
            SqlCommand cmd = new SqlCommand("INSERT INTO Account(AccountID,Phone,Email,Password,Salt,Active,FullName,RoleID,LastLogin,CreateDate)VALUES('" + account.AccountId + "','" + account.Phone + "','" + account.Email + "','" + account.Password + "','" + account.Salt + "','" + account.Active + "','" + account.FullName + "','" + account.Role + "','" + account.LastLogin + "','" + account.CreateDate + "',)", con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i > 0)
            {
                return "Data inserted";
            }
            else
            {
                return "Error";
            }
           
        }
        [HttpPost]

        [Route("Login")]

        public string login(Account account)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("dbshoplinkkien".ToString()));
            SqlDataAdapter da = new  SqlDataAdapter("SELECT * FROM Account WHERE Email= '" + account.Email + "'AND Password'" + account.Password + "',)",con);
            DataTable dt  = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                return "data Found";
            }
            else { return "Error"; }
        }
    }
}
