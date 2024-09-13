using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace WebApplicationMasartk.Areas.CompanyData.Controllers
{
    [Area("CompanyData")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly IHostingEnvironment host;
        private readonly ApplicationDbContext application;

        public HomeController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext application)
        {
            this.work = work;
            this.host = host;
            this.application = application;
        }

        public IActionResult Index()
        {
           
                var GetAllData = application.CompaniesData.Where(b => !b.IsDelete).ToList();
                return View(GetAllData);

           



        }



    
    }
}
