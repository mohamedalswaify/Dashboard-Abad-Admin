using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class InvoiceController : Controller
    {
        private readonly IUnitOfWork _work;
        private readonly ApplicationDbContext _context;

        public InvoiceController(IUnitOfWork work, ApplicationDbContext context)
        {
            _work = work;
            _context = context;
        }
        //View invoice to employee


        public void FillLast(int IndexValue = 1)
        {

            var datas = _context.TypePaidData.Where(b => !b.IsDelete && !b.IsHide);
            SelectList list = new SelectList(datas, "Id", "ArabicName");


            ViewBag.FillData = list;

        }


        public IActionResult GetInvoice(int id)
        {
            CoursesReserved reserved = _context.CoursesReserveds.FirstOrDefault(c => c.Id == id);
            FillLast();
          
                if (reserved != null)
                {
                    if (reserved.StutusPaidup == true)
                    {
                        ViewBag.PaidOK = true;
                    }
                    return View(reserved);
                }
            return View(reserved);
            //return Redirect("/Identity/Account/login");
        }


        [HttpGet]
        public ActionResult ConfirmIvoice(int id, int tax, int preDiscount, int discount, int balanceDue,int typePaid, int payment,int vrice,bool checkbooks)
        {
			try
			{
				if (balanceDue != 0)
				{
					return Json(false);
				}

				var res = _context.CoursesReserveds.FirstOrDefault(b => b.Id == id);
				if (res == null)
				{
					return Json(false); 
				}

				if (checkbooks)
				{
					int Balance = Convert.ToInt32(res.BalanceDue);
					var student = _context.Students.Find(res.StudentId);
					if (student != null)
					{
                        student.Amount -= payment;
                        if(student.Amount <= 0)
                        {
                            student.Amount = 0;
                        }
						student.Amount += Balance;
						_context.Students.Update(student);
						_context.SaveChanges();
					}
				}
				_context.Attach(res);

				res.StutusPaidup = true;
				res.Tax = Convert.ToDecimal(tax);
				res.PreDiscount = preDiscount;
				res.Discount = Convert.ToDecimal(discount);
				res.BalanceDue = balanceDue;
				res.LastUpdateDate = DateTime.Now;
				res.TypePaidId = typePaid;
				res.Payment = payment;
				res.Paidup = Convert.ToDecimal(vrice);

				_context.Entry(res).Property(x => x.Id).IsModified = false;

				_context.SaveChanges();

				return Json(true);
			}
			catch (Exception)
			{
				throw;
			}



		}



		[HttpPost]
        public IActionResult ProcessInvoice(CoursesReserved coursesReserved)
        {
            if (coursesReserved != null)
            {
                string? EmployeeId = Request.Cookies["EmployeeId"];
                Employee employee = _context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

                CoursesReserved reserved = _context.CoursesReserveds.FirstOrDefault(b=>b.Id==coursesReserved.Id);

                if (reserved != null)
                {
                    reserved.StutusPaidup = true;
                    reserved.LastUpdateUserCode = employee.Email;
                    _context.SaveChanges();
                }
            }
            return View("ViewInvoice");
        }




       
    }
}
