using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostController : ControllerBase
    {
        //api/post/GetPosts
        [HttpGet("GetPosts")]
        public string GetPosts()
        {
            return "Users and/or admins can see it";
        }

        //api/post/GetPostsAdmin
        [HttpGet("GetPostsAdmin")]
        [Authorize(Roles = "Admin")]
        public string GetPostsAdmin()
        {
            return "Only admins can see it";
        }

        //api/post/GetPostsUser
        [HttpGet("GetPostsUser")]
        [Authorize(Roles = "User")]
        public string GetPostsUser()
        {
            return "Only users can see it";
        }
    }
}