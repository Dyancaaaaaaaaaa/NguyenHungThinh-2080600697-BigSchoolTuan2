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
    public class FollowingsController : ApiController
    {
        // GET: Followings
        private ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();

            if (_dbContext.Followings.Any(a => a.FollowerId == userId && a.FollowerId == followingDto.FolloweeId))
                return BadRequest("The Following already exits!");


            var following = new Following
            {

                FollowerId = userId,


               FolloweeId=followingDto.FolloweeId



            };
            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}