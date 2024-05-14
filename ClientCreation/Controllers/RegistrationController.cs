using ClientCreation.Data;
using ClientCreation.DataAccess;
using ClientCreation.DataAccess.Repository.IRepository;
using ClientCreation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClientCreation.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationDbContext _db;

        public RegistrationController(RegistrationDbContext db)
        {
            _db = db;
        }
        public IActionResult Registration()
        {
            //IEnumerable<RegistrationCheckList> Registrationinfo = _db.RegistrationCheckList.GroupBy(s => s.HeadingTab).ToList();
            IEnumerable<SelectListItem> Mandatory = _db.TypeLookUpMaster.Where(s => s.Context=="Mandatory").Select(u => new SelectListItem
            {
                Text = u.ParamDesc,
                Value = u.ParamValue
            });
            var Man = _db.TypeLookUpMaster.FirstOrDefault(x => x.Context == "Mandatory");
            IEnumerable<SelectListItem> Datatype = _db.TypeLookUpMaster.Where(s => s.Context == "Datatype").Select(u => new SelectListItem
            {
                Text = u.ParamDesc,
                Value = u.ParamValue
            });
            IEnumerable<SelectListItem> Dropdown = _db.TypeLookUpMaster.Where(s => s.Context == "dropdown").Select(u => new SelectListItem
            {
                Text = u.ParamDesc,
                Value = u.ParamValue
            });
            IEnumerable<SelectListItem> EditableorNot = _db.TypeLookUpMaster.Where(s => s.Context == "EditableOrNot").Select(u => new SelectListItem
            {
                Text = u.ParamDesc,
                Value = u.ParamValue
            });
            ViewBag.select = Mandatory;
            ViewBag.Dropdown = Dropdown;
            ViewBag.Datatype = Datatype;
            ViewBag.EditableorNot = EditableorNot;
            return View();
        }

        #region API CALLS
        [HttpPost]
        public IActionResult InsertRegistrationDetails([FromBody] List<RegistrationCheckList> obj)
        {
            foreach (RegistrationCheckList item in obj)
            {
                _db.RegistrationCheckList.Add(item);
            }
            _db.SaveChanges();
            return Json(new { success = true, message = "inserted" });
        }
        #endregion
    }
}
