using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInstallerNET;

namespace WindowsInstallerNET
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

        public string InstalledProductName { get { return MSI.getProperty(GUID, InstallProperty.InstalledProductName); } }
        public string VersionString { get { return MSI.getProperty(GUID, InstallProperty.VersionString); } }
        public string HelpLink { get { return MSI.getProperty(GUID, InstallProperty.HelpLink); } }
        public string HelpTelephone { get { return MSI.getProperty(GUID, InstallProperty.HelpTelephone); } }
        public string InstallLocation { get { return MSI.getProperty(GUID, InstallProperty.InstallLocation); } }
        public string InstallSource { get { return MSI.getProperty(GUID, InstallProperty.InstallSource); } }
        public string InstallDate { get { return MSI.getProperty(GUID, InstallProperty.InstallDate); } }
        public string Publisher { get { return MSI.getProperty(GUID, InstallProperty.Publisher); } }
        public string LocalPackage { get { return MSI.getProperty(GUID, InstallProperty.LocalPackage); } }
        public string URLInfoAbout { get { return MSI.getProperty(GUID, InstallProperty.URLInfoAbout); } }
        public string URLUpdateInfo { get { return MSI.getProperty(GUID, InstallProperty.URLUpdateInfo); } }
        public string VersionMinor { get { return MSI.getProperty(GUID, InstallProperty.VersionMinor); } }
        public string VersionMajor { get { return MSI.getProperty(GUID, InstallProperty.VersionMajor); } }
        public string ProductID { get { return MSI.getProperty(GUID, InstallProperty.ProductID); } }
        public string RegCompany { get { return MSI.getProperty(GUID, InstallProperty.RegCompany); } }
        public string RegOwner { get { return MSI.getProperty(GUID, InstallProperty.RegOwner); } }
        public string Uninstallable { get { return MSI.getProperty(GUID, InstallProperty.Uninstallable); } }
        public string State { get { return MSI.getProperty(GUID, InstallProperty.State); } }
        public string PatchType { get { return MSI.getProperty(GUID, InstallProperty.PatchType); } }
        public string LUAEnabled { get { return MSI.getProperty(GUID, InstallProperty.LUAEnabled); } }
        public string DisplayName { get { return MSI.getProperty(GUID, InstallProperty.DisplayName); } }
        public string MoreInfoURL { get { return MSI.getProperty(GUID, InstallProperty.MoreInfoURL); } }
        public string LastUsedSource { get { return MSI.getProperty(GUID, InstallProperty.LastUsedSource); } }
        public string LastUsedType { get { return MSI.getProperty(GUID, InstallProperty.LastUsedType); } }
        public string MediaPackagePath { get { return MSI.getProperty(GUID, InstallProperty.MediaPackagePath); } }
        public string DiskPrompt { get { return MSI.getProperty(GUID, InstallProperty.DiskPrompt); } }

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
