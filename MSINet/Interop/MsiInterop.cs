using System;
using System.Runtime.InteropServices;

namespace MSINet.Interop
{
    public static class MsiInterop
    {
        [DllImport("msi.dll", CharSet = CharSet.Unicode)]
        public static extern MsiExitCodes MsiGetProductInfo(string product, string property, [Out] String valueBuf, ref int len);

        [DllImport("msi.dll", EntryPoint = "MsiEnumProductsExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern MsiExitCodes MsiEnumProductsEx(string szProductCode, string szUserSid, InstallContext dwContext, uint dwIndex, string szInstalledProductCode, out object pdwInstalledProductContext, string szSid, ref uint pccSid);
    }
}
