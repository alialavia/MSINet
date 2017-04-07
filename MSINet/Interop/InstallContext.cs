using System;

namespace MSINet.Interop
{
    [Flags]
    public enum InstallContext : uint
    {
        Node = 0,
        UserManaged = 1,
        UserUnmanaged = 2,
        Machine = 4,
        All = (UserManaged | UserUnmanaged | Machine),
    }
}
