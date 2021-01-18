using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using ChallengeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        #region Methods

        [HttpGet]
        [Route("api/user/{username}")]
        public IActionResult GetUser(string username)
        {
            Random random = new Random();
            User user = _userCache.GetOrAdd(username,
                                            _ => new User
                                            {
                                                UserName = username,
                                                Permissions = new PermissionSet(new HashSet<string>
                                                {
                                                    $"permission{random.Next(1, 100)}",
                                                    $"permission{random.Next(1, 100)}",
                                                    $"permission{random.Next(1, 100)}",
                                                    $"permission{random.Next(1, 100)}"
                                                }),
                                                CreateDate = DateTime.UtcNow,
                                                Timezone = "PST",
                                                FavoriteColor = random.Next(0, 100) % 2 == 0 ? "Green" : "Blue"
                                            });

            return Ok(user);
        }

        #endregion

        #region Fields

        private static readonly ConcurrentDictionary<string, User> _userCache = new ConcurrentDictionary<string, User>();

        #endregion
    }
}