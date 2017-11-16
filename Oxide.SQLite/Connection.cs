﻿using System.Data.SQLite;
#if NET35
using System.Security.Permissions;
#endif
using Oxide.Core.Plugins;

namespace Oxide.Ext.SQLite
{
#if NET35
    [ReflectionPermission(SecurityAction.Deny, Flags = ReflectionPermissionFlag.AllFlags)]
#endif
    public sealed class Connection
    {
        internal string ConnectionString { get; set; }
        internal bool ConnectionPersistent { get; set; }
        internal SQLiteConnection Con { get; set; }
        internal Plugin Plugin { get; set; }
        public long LastInsertRowId { get; internal set; }

        public Connection(string connection, bool persistent)
        {
            ConnectionString = connection;
            ConnectionPersistent = persistent;
        }
    }
}
