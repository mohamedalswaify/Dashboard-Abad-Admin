using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.CompanyData.Controllers
{
    [Area("CompanyData")]
    public class ContractController : Controller
    {

        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext application;

        public ContractController(IUnitOfWork work, ApplicationDbContext application)
        {
            this.work = work;
            this.application = application;
        }

        public IActionResult Index()
        { 
                var GetAllData = application.ContractData.Where(b => !b.IsDeletae).ToList();
                return View(GetAllData);

        }

        //Get Contract
        public IActionResult Create() 
        { 
        
        return View();
        }

   

    }
}
