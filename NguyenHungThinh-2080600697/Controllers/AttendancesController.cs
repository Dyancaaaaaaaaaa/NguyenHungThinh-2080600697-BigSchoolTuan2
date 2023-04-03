using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Provider;
using NguyenHungThinh_2080600697.DTOs;
using NguyenHungThinh_2080600697.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;


namespace NguyenHungThinh_2080600697.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();

             if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            return BadRequest("The Attendance already exits!");


                var attendance = new Attendance {



                    CourseId = attendanceDto . CourseId,
                 AttendeeId = userId



            };
                _dbContext.Attendances.Add(attendance);
                _dbContext.SaveChanges();
                return Ok();
            }

        }
    }

