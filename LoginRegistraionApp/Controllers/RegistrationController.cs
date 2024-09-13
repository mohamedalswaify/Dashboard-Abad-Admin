using LoginRegistraionApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LoginRegistraionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public RegistrationController(IConfiguration configuration)
        {
                _configuration= configuration;
        }

        [HttpPost]
        [Route("registration")]
        public string registraion(Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            SqlCommand cmd =new SqlCommand("insert into TraineeData (ArabicName,EnglishName,Idnumber,Email,Phone,Gender,CountriesCode,CityCode,Password) values('" + registration.ArabicName+ "','"+ registration.EnglishName+ "','"+ registration.Idnumber+ "','"+ registration.Email+ "','"+ registration.Phone+ "','"+ registration.Gender+ "','"+ registration.CountriesCode+ "','"+ registration.CityCode+ "','"+ registration.Password+ "')",con);
            con.Open();
            int i =cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0) {
                return "Data inserted";
            }
            else
            {
                return "Error";
            }


           
        }


        [HttpPost]
        [Route("login")]
        public string login(Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TraineeData where email ='"+ registration.Email+ "'  and password= '"+registration.Password+"'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return "vaild user";
            }
            else
            { return "Invalid user"; }
        }

    }
}
