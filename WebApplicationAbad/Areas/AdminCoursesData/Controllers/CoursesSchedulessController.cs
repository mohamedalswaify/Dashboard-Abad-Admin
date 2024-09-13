using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Contracts;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
	public class CoursesSchedulessController : Controller
	{
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        public int CoursesCode = 0;
		
		public CoursesSchedulessController(IUnitOfWork work ,ApplicationDbContext context) {
            this.work = work;
            this.context = context;
		}
		
		public int Cotal = 0;
		public IActionResult GetCoursesSchedulessIndex()
		{
            var allData = context.CoursesSchedulesses.Where(b => !b.IsDelete).OrderByDescending(s => s.StartDate).ToList();
            return View(allData);
        }

		public IActionResult GetCoursesSchedulessCreate(int  id)
		{
            var FindId = work.CoursesScheduless.GetByID(id);
            

            if (FindId == null)
            {
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
                FilDataCourses();
            }


            else
            {

                ViewBag.Cost = false;
                int modelCost = context.CoursesReserveds.Count(b=>b.CoursesSchedulessId==id);
                if(modelCost > 0)
                {
                    ViewBag.Cost = true;
                }


                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                FilDataCourses(id);
                return View(FindId);

            }
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesSchedulessCreate(CoursesScheduless scheduless, int id)
        {
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            var FindId = work.CoursesScheduless.GetByID(id);
            if (FindId == null)
            {
                scheduless.TokenNumber=Guid.NewGuid().ToString();
                scheduless.CloseDay=scheduless.StartDate.Value.AddDays(3);
                scheduless.UserCode = employee.Email;
                scheduless.CreatedDate = DateTime.Now;
                work.CoursesScheduless.AddNewRow(scheduless);
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
               // FindId.TokenNumber= Guid.NewGuid().ToString();
                FindId.StartDate = scheduless.StartDate;
                FindId.EndDate = scheduless.EndDate;
                FindId.StartTime = scheduless.StartTime;
                FindId.EndTime = scheduless.EndTime;
                FindId.NumberOfWeek = scheduless.NumberOfWeek;
                FindId.NumberOfHourse = scheduless.NumberOfHourse;
                FindId.Cost = scheduless.Cost;
                FindId.IsHide = scheduless.IsHide;
                FindId.CoursesDataId = scheduless.CoursesDataId;
                FindId.TrainerId = scheduless.TrainerId;
                FindId.BranchId = scheduless.BranchId;
                FindId.IsFares= scheduless.IsFares;
                FindId.IsHadaf = scheduless.IsHadaf;
                FindId.TimeCoures = scheduless.TimeCoures;
                FindId.LinkWhatsApp = scheduless.LinkWhatsApp;
                FindId.CoursesTypeCode = scheduless.CoursesTypeCode;
                FindId.CoursesIsonlineId = scheduless.CoursesIsonlineId;
                FindId.CoursesStatusId= scheduless.CoursesStatusId;
                FindId.RoomId= scheduless.RoomId;
                FindId.LastUpdateDate = DateTime.Now;
                FindId.LastUpdateUserCode = employee.Email;
                FindId.detailsTime = scheduless.detailsTime;
                


                work.CoursesScheduless.UpdateRow(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
            }
            return RedirectToAction("GetCoursesSchedulessIndex");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesSchedulessIndex(CoursesScheduless coursesScheduless, int id)
        {
            var fintID = work.CoursesScheduless.GetByID(id);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                work.CoursesScheduless.UpdateRow(fintID);
            }
            return Redirect("GetCoursesStutesIndex");
        }
        
        [HttpGet]
        public IActionResult GetCost(int coursesDataId,int CoursesID)
        {
            int modelCost = context.CoursesReserveds.Count(b => b.CoursesSchedulessId == CoursesID);
            
            if (modelCost > 0)
            {
                return null;
            }
            decimal cost = context.CoursesData.Where(b => b.Id==coursesDataId).Select(b => b.Price).FirstOrDefault();
            return Json(cost);
        }

        [HttpGet]
        public ActionResult Tarnsform(int IdSecc, int idResved,int NewSeccId)
        {
			string? EmployeeId = Request.Cookies["EmployeeId"];
			Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);
			try
			 {
				DateTime DateNow = DateTime.Now;
				var SeIdNew = context.coursesSchedulesses.Find(NewSeccId);
                var ResvId = context.CoursesReserveds.FirstOrDefault(b => b.Id == idResved);
				var StudentId = context.Students.Find(ResvId.StudentId);

				if (ResvId.StutusPaidup == true)
				{
					StudentId.Amount += ResvId.Payment;
					context.Students.Update(StudentId);
				}
				var NewResvId = new CoursesReserved
				{
					CoursesSchedulessId = NewSeccId,
					Nots = $"تم نقل الطالب {ResvId.Student.ArabicName} من دورة " +
					$"{ResvId.CoursesScheduless.CoursesData.HeaderAr} الى دورة " +
					$"{SeIdNew.CoursesData.HeaderAr} بتاريخ " +$"{DateNow} " +
                    $"الموظف الذي قام بعملية النقل {employee.Name}",
					Payment = 0,
					StutusPaidup = false,
					Paidup = SeIdNew.Cost,
					Discount = 0,
					BalanceDue = 0,
                    StudentId= ResvId.StudentId,
                    UserCode= employee.Email,
				};

				context.Remove(ResvId);
				context.SaveChanges();
				
				context.Add(NewResvId);
				context.SaveChanges();


				context.MoveStudent.Add(new MoveStudent
				{
					CoursesSchedulessId = IdSecc,
					ToCourses = NewSeccId,
					StudntId = StudentId.Id,
					DateTraform = DateNow,
					Nots = ResvId.Nots,
					Amount = ResvId.Payment,
					EmpId = employee.Id
				});

				context.SaveChanges();



				return Json(true);
			}
            catch (Exception)
            {

                throw;
            }
          
        }

        public IActionResult GetDaitlsCoursesSchduless(int IdCourses)
        {
         
            var StudentReserved = context.CoursesReserveds.Where(b => b.CoursesSchedulessId == IdCourses).ToList();
            var DataCourses = work.CoursesScheduless.GetByID(IdCourses);
            var select = context.SelectDatas.FirstOrDefault(v => v.Id == 1);
            select.VlaueData = IdCourses;
            context.SelectDatas.Update(select);
            ViewBag.ModelDataSchedulss = DataCourses;
            ViewBag.StudentReserveds = StudentReserved;
            context.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult GetFilteredCoursesData(int courseTypeCode)
        {
            var filteredCoursesData = context.CoursesData.Where(cd => cd.CoursesTypeId == courseTypeCode && !cd.IsDelete && !cd.IsHide ).ToList();
            var jsonData = filteredCoursesData.Select(item => new
            {
                value = item.Id,
                text = item.HeaderEn   
            });

            return Json(jsonData);
        }

        [HttpGet]
        public IActionResult GetDateAction(int type)
        {
            if (type == 1)
            {
                var filteredItems = work.CoursesScheduless.GetEntity();
                return View("GetTanleView", filteredItems);
            }
            else if (type == 2)
            {
                var today = DateOnly.FromDateTime(DateTime.Now.Date);
                var oneWeekLater = today.AddDays(7);
                var filteredItems = context.coursesSchedulesses
                    .Where(b => b.EndDate.HasValue && b.EndDate.Value > today && b.EndDate.Value <= oneWeekLater).OrderByDescending(b=>b.EndDate)
                    .ToList();
                return View("GetTanleView", filteredItems);
            }
            else if (type == 3)
            {
                var today = DateOnly.FromDateTime(DateTime.Now.Date);
                var oneWeekLater = today.AddDays(7);
                var filteredItems = context.coursesSchedulesses
                    .Where(b => b.EndDate.HasValue && b.StartDate.Value > today).OrderBy(b=>b.StartDate)
                    .ToList();
                return View("GetTanleView", filteredItems);
            }
            else if (type == 4)
            {
                var today = DateOnly.FromDateTime(DateTime.Now.Date);
                var filteredItems = context.coursesSchedulesses
                    .Where(b => b.EndDate.HasValue && b.StartDate.Value <= today).OrderBy(b => b.StartDate)
                    .ToList();
                return View("GetTanleView", filteredItems);
            }
            else if (type == 5)
            {
                var today = DateOnly.FromDateTime(DateTime.Now.Date);
                var filteredItems = context.coursesSchedulesses
                    .Where(b=>b.EndDate.Value < today).OrderBy(b => b.EndDate)
                    .ToList();
                return View("GetTanleView", filteredItems);
            }

            return View();
        }

        [HttpGet]
        public IActionResult GetDateStudent(string id)
        {
            try
            {
                int idNumber;
                var filteredStudent = new Student();
                filteredStudent = context.Students.FirstOrDefault(b => b.Idnumber == id || b.Phone == id||b.Email==id);
                if (filteredStudent != null)
                {
                    ViewBag.MatchedStudent = true;
                    return View("GetFormStudent", filteredStudent);
                }
                ViewBag.MatchedStudent = false;
                return View("GetFormStudent", filteredStudent);
            
            }
            catch(Exception)
            {
                return View();
            }
           
        }

        [HttpGet]
        public ActionResult DeleteStudent(int Id)
        {
            var ResvedID = context.CoursesReserveds.FirstOrDefault(b=>b.Id==Id);
            context.CoursesReserveds.Remove(ResvedID);
            context.SaveChanges();
            return Json(true);
        }


        [HttpPost]
        public IActionResult GetStudentCreate(Student student, int CoursesId, int ContractID, bool IsCompany)
        {
			string? EmployeeId = Request.Cookies["EmployeeId"];
			Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

			try
			{ 
            if (student != null)
            {
                Student findId = context.Students.FirstOrDefault(b => b.Idnumber == student.Idnumber);
                CoursesReserved CoursesReserved;
                if (findId == null)
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    findId = student;
                }

                var contextSecc = context.coursesSchedulesses.Find(CoursesId);
                if (IsCompany)
                {
                    CoursesReserved = new CoursesReserved
                    {
                        StutusReserved = true,
                        StutusPaidup = true,
                        IsCompany = IsCompany,
                        Paidup = contextSecc.Cost,
                        ContractDatumId = ContractID,
                        CoursesSchedulessId = contextSecc.Id,
                        UserCode = employee.Email,
                        CreatedDate = DateTime.Now,
                        StudentId = findId.Id,
                    };
                }
                else
                {
                    CoursesReserved = new CoursesReserved
                    {
                        StutusReserved = true,
                        StutusPaidup = false,
                        IsCompany = IsCompany,
                        Paidup = contextSecc.Cost,
                        ContractDatumId = null,
                        CoursesSchedulessId = contextSecc.Id,
                        UserCode = employee.Email,
                        CreatedDate = DateTime.Now,
                        StudentId = findId.Id,
                    };
                }

                context.CoursesReserveds.Add(CoursesReserved);
            }

            context.SaveChanges();

            return RedirectToAction("GetDaitlsCoursesSchduless", "CoursesScheduless", new { IdCourses = CoursesId });
            }
            catch(Exception) {
                return RedirectToAction("GetDaitlsCoursesSchduless", "CoursesScheduless", new { IdCourses = CoursesId });

            }
        }


        public IActionResult GetCompanyData(int CopanyId)
        {
            var jsonData = context.ContractData.Where(b=>b.CompaniesDataId==CopanyId).Select(b => new
            {
                value = b.Id,
                text = b.Tiltle
            });
            return Json(jsonData);
        }


        [HttpGet]
        public IActionResult CheckID(string StudentID, bool IsCompany, int SchedulID, int Contract, bool boolValue, string email)
        {
            var CountStudent = context.CoursesReserveds.Count();
            var SelectMessage = context.SelectDatas.Find(1);

            var studnetnumber = context.Students.FirstOrDefault(b => b.Idnumber == StudentID);

            var Email = context.Students.Where(b =>b.Email== email).Count();
            if (studnetnumber == null)
            {
                SelectMessage.MessageData = "تم اضافة الطالب";
                context.SelectDatas.Update(SelectMessage);
                context.SaveChanges();
                return Json(true);
            }

            var Isexist = context.CoursesReserveds.Count(b => b.StudentId == studnetnumber.Id && b.CoursesSchedulessId == SchedulID);
            var StudentCode = context.Students.Count(b => b.Idnumber == StudentID);

            if (IsCompany)
            {
                var CountResved = context.CoursesReserveds.Count(b => b.ContractDatumId == Contract);
                var CountStudentResd = context.ContractData.FirstOrDefault(b => b.Id == Contract);

                if (CountStudentResd != null)
                {
                    if (CountResved >= CountStudentResd.StudentCount)
                    {
                        SelectMessage.MessageData = "العقد مكتمل بعدد الطلاب";
                        context.SelectDatas.Update(SelectMessage);
                        context.SaveChanges();
                        return Json(false);
                    }
                }
            }

            if (Isexist > 0)
            {
                SelectMessage.MessageData = "الطالب موجود بالدورة من قبل";
                context.SelectDatas.Update(SelectMessage);
                context.SaveChanges();
                return Json(false);
            }
            return Json(true);
        }


       public IActionResult GetEditSchedulessCourses(int id)
        {
            var contexdate = context.CoursesReserveds.FirstOrDefault(b=>b.Id==id);
            return View(contexdate);
        }


        public void FilDataCourses(int IdOnlin = 1)
        {
            var Online = context.CoursesIsonlines.Where(b => !b.IsHide && !b.IsDelete);
            SelectList select = new SelectList(Online, "Id", "EnglishName");
            ViewBag.FilDataOnline = select;

            if(IdOnlin == 1) { 
            var CoresesMotel = context.CoursesTypes.FirstOrDefault();
            if (CoresesMotel == null)
            {
                var Data = context.CoursesData.Where(b => !b.IsHide && !b.IsDelete);
                SelectList selectData = new SelectList(Data, "Id", "HeaderEn");
                ViewBag.FilDataCourseData = selectData;
            }
            else
            {
                var Data = context.CoursesData.Where(b=>b.CoursesTypeId==0 );
                SelectList selectData = new SelectList(Data, "Id", "HeaderEn");
                ViewBag.FilDataCourseData = selectData;
            }
            }
            else
            {
                var call = context.coursesSchedulesses.Find(IdOnlin);
                var Data = context.CoursesData.Where(b => !b.IsHide && !b.IsDelete && b.CoursesTypeId== call.CoursesTypeCode);
                SelectList selectData = new SelectList(Data, "Id", "HeaderEn");
                ViewBag.FilDataCourseData = selectData;
            }



            var Trainer = context.TrainerData.Where(b => !b.IsDelete);
            SelectList selecTrainer = new SelectList(Trainer, "Id", "NameEn");
            ViewBag.FilDataTrinaer = selecTrainer;

            var Branches = context.Branches.Where(b => !b.IsHide && !b.IsDelete);
            SelectList selecBranches = new SelectList(Branches, "Id", "EnglishName");
            ViewBag.FilDataBranches = selecBranches;

            var Status = context.CoursesStatuses.Where(b=>!b.IsDelete && !b.IsHide);
            SelectList selecStatus = new SelectList(Status, "Id", "EnglishName");
            ViewBag.FilDataStatus = selecStatus;

            var Types = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
            SelectList selecType = new SelectList(Types, "Code", "EnglishName");
            ViewBag.FilDataCoursesType = selecType;

            var Rooms = context.Rooms.Where(b => !b.IsDelete && !b.IsHide);
            SelectList selectRoom = new SelectList(Rooms, "Id", "RoomNameEN");
            ViewBag.FilDataRoomNumber = selectRoom;

            var contarct = context.ContractData.Where(b=>!b.IsDeletae);
            SelectList selectContarct = new SelectList(contarct, "", "");
            ViewBag.filterContract = selectContarct;

        }
      

        [HttpGet]
        public IActionResult UpdateStduentResved(bool IsCompany,int Contract ,int ResveId , string Nots)
        {
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            try
            {
                var contextel = context.CoursesReserveds.FirstOrDefault(c => c.Id == ResveId);
                if (contextel != null)
                {
                    decimal pay = contextel.Payment;
                    if (IsCompany)
                    {
                        int contract = context.CoursesReserveds.Count(b => b.ContractDatumId == Contract);
                        var contractCount = context.ContractData.Find(Contract);
                        if (contract != contractCount.StudentCount)
                        {
                            context.CoursesReserveds.Attach(contextel);
                            contextel.ContractDatumId = Contract;
                            contextel.IsCompany = true;
                            contextel.StutusPaidup = true;
                            contextel.Payment = pay;
                            contextel.Nots = Nots;
                            contextel.LastUpdateUserCode = employee.Email;
                            contextel.LastUpdateDate = DateTime.Now;

                            if (contextel.StutusPaidup == true)
                            {
                                var Student = context.Students.Find(contextel.Student.Id);
                                Student.Amount += pay;
                                context.Students.Update(Student);
                            }
                        }
                        else
                        {
                            return Json(false);
                        }
                    }
                    else
                    {
                      if (contextel.IsCompany==true) {
                            context.CoursesReserveds.Attach(contextel);
                            contextel.ContractDatumId = null;
                        contextel.IsCompany = false;
                        contextel.StutusPaidup = false;
                        contextel.Payment = 0;
                        contextel.Nots = Nots;
                        contextel.LastUpdateUserCode = employee.Email;
                        contextel.LastUpdateDate = DateTime.Now;
                        }
                    }

                    context.SaveChanges();
                }
                return Json(true);
            }
            catch (Exception)
            {

                throw;
            }
            

        }

    }
}





