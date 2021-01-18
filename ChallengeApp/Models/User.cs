using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp.Models
{
    public class User
    {
        #region Properties

        public DateTime CreateDate { get; set; }
        public string FavoriteColor { get; set; }
        public PermissionSet Permissions { get; set; }
        public string Timezone { get; set; }
        public string UserName { get; set; }

        #endregion
    }
}