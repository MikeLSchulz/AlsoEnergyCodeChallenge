using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AE.Models
{
    public class PermissionSet
    {
        #region Constructors And Destructors

        public PermissionSet(ISet<string> permissions)
        {
            Permissions = permissions ?? new HashSet<string>();
        }

        public PermissionSet(byte[] data)
        {
            string permissionCollection = Encoding.UTF8.GetString(data ?? new byte[0]);

            if (string.IsNullOrEmpty(permissionCollection))
            {
                Permissions = new HashSet<string>();
                return;
            }

            HashSet<string> permissions = new HashSet<string>(permissionCollection.Split(_delimiter));
            Permissions = permissions;
        }

        #endregion

        #region Properties

        public ISet<string> Permissions { get; }

        #endregion

        #region Methods

        public byte[] ToByteArray()
        {
            return Encoding.UTF8.GetBytes(string.Join(_delimiter.ToString(), Permissions.ToArray()));
        }

        #endregion

        #region Fields

        private const char _delimiter = ',';

        #endregion
    }
}