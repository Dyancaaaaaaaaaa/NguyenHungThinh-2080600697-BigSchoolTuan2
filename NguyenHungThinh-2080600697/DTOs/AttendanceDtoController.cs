using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHungThinh_2080600697.DTOs
{
    public class AttendanceDto
    {
        public int CourseId { get; set; }
    }
    public class AttendanceDtoController : Controller
    {
        // GET: AttendanceDto
        public ActionResult Index()
        {
            return View();
        }
    }
  
}