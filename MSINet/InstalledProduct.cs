using MSINet.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSINet
{
    public class InstalledProduct
    {
        public InstalledProduct(String GUID)
        {
            this.GUID = GUID;
        }

        /// <summary>
        /// Enumerates all MSI installed products
        /// </summary>
        /// <returns>
        /// An enumeration containing InstalledProducts
        /// </returns>
        public static IEnumerable<InstalledProduct> Enumerate()
        {
            foreach (var guid in MSI.EnumerateGUIDs())
                yield return new InstalledProduct(guid);
        }
        public readonly string GUID;

        public string InstalledProductName { get { return MSI.getProperty(GUID, InstallPropertyNames.InstalledProductName); } }
        public string VersionString { get { return MSI.getProperty(GUID, InstallPropertyNames.VersionString); } }
        public string HelpLink { get { return MSI.getProperty(GUID, InstallPropertyNames.HelpLink); } }
        public string HelpTelephone { get { return MSI.getProperty(GUID, InstallPropertyNames.HelpTelephone); } }
        public string InstallLocation { get { return MSI.getProperty(GUID, InstallPropertyNames.InstallLocation); } }
        public string InstallSource { get { return MSI.getProperty(GUID, InstallPropertyNames.InstallSource); } }
        public string InstallDate { get { return MSI.getProperty(GUID, InstallPropertyNames.InstallDate); } }
        public string Publisher { get { return MSI.getProperty(GUID, InstallPropertyNames.Publisher); } }
        public string LocalPackage { get { return MSI.getProperty(GUID, InstallPropertyNames.LocalPackage); } }
        public string URLInfoAbout { get { return MSI.getProperty(GUID, InstallPropertyNames.URLInfoAbout); } }
        public string URLUpdateInfo { get { return MSI.getProperty(GUID, InstallPropertyNames.URLUpdateInfo); } }
        public string VersionMinor { get { return MSI.getProperty(GUID, InstallPropertyNames.VersionMinor); } }
        public string VersionMajor { get { return MSI.getProperty(GUID, InstallPropertyNames.VersionMajor); } }
        public string ProductID { get { return MSI.getProperty(GUID, InstallPropertyNames.ProductID); } }
        public string RegCompany { get { return MSI.getProperty(GUID, InstallPropertyNames.RegCompany); } }
        public string RegOwner { get { return MSI.getProperty(GUID, InstallPropertyNames.RegOwner); } }
        public string Uninstallable { get { return MSI.getProperty(GUID, InstallPropertyNames.Uninstallable); } }
        public string State { get { return MSI.getProperty(GUID, InstallPropertyNames.State); } }
        public string PatchType { get { return MSI.getProperty(GUID, InstallPropertyNames.PatchType); } }
        public string LUAEnabled { get { return MSI.getProperty(GUID, InstallPropertyNames.LUAEnabled); } }
        public string DisplayName { get { return MSI.getProperty(GUID, InstallPropertyNames.DisplayName); } }
        public string MoreInfoURL { get { return MSI.getProperty(GUID, InstallPropertyNames.MoreInfoURL); } }
        public string LastUsedSource { get { return MSI.getProperty(GUID, InstallPropertyNames.LastUsedSource); } }
        public string LastUsedType { get { return MSI.getProperty(GUID, InstallPropertyNames.LastUsedType); } }
        public string MediaPackagePath { get { return MSI.getProperty(GUID, InstallPropertyNames.MediaPackagePath); } }
        public string DiskPrompt { get { return MSI.getProperty(GUID, InstallPropertyNames.DiskPrompt); } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var p in this.GetType().GetProperties())
                try
                {
                    sb.AppendFormat("{0}:{1}\r\n", p.Name, p.GetValue(this));
                }
                catch
                { }

            return sb.ToString();
        }
    }
}
