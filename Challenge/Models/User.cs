using System;
using System.Collections.Generic;
using System.Linq;
using AE.CoreUtility;

namespace AE.Models
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

        #region Methods

        public BlobIO Serialize()
        {
            BlobIO blob = null;
            blob += UserName;
            blob += Permissions;
            blob += CreateDate;
            blob += Timezone;
            blob += FavoriteColor;
            return blob;
        }

        #endregion
    }
}