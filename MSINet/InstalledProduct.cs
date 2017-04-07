using MSINet.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSINet
{
    public class InstalledProduct
    {
        public InstalledProduct(String guid)
        {
            _guid = guid;
        }

        private readonly string _guid;
        
        public string GUID => _guid;
        public string InstalledProductName => MSI.GetProperty(GUID, InstallPropertyNames.InstalledProductName);
        public string VersionString => MSI.GetProperty(GUID, InstallPropertyNames.VersionString);
        public string HelpLink => MSI.GetProperty(GUID, InstallPropertyNames.HelpLink);
        public string HelpTelephone => MSI.GetProperty(GUID, InstallPropertyNames.HelpTelephone);
        public string InstallLocation => MSI.GetProperty(GUID, InstallPropertyNames.InstallLocation);
        public string InstallSource => MSI.GetProperty(GUID, InstallPropertyNames.InstallSource);
        public string InstallDate => MSI.GetProperty(GUID, InstallPropertyNames.InstallDate);
        public string Publisher => MSI.GetProperty(GUID, InstallPropertyNames.Publisher);
        public string LocalPackage => MSI.GetProperty(GUID, InstallPropertyNames.LocalPackage);
        public string URLInfoAbout => MSI.GetProperty(GUID, InstallPropertyNames.URLInfoAbout);
        public string URLUpdateInfo => MSI.GetProperty(GUID, InstallPropertyNames.URLUpdateInfo);
        public string VersionMinor => MSI.GetProperty(GUID, InstallPropertyNames.VersionMinor);
        public string VersionMajor => MSI.GetProperty(GUID, InstallPropertyNames.VersionMajor);
        public string ProductID => MSI.GetProperty(GUID, InstallPropertyNames.ProductID);
        public string RegCompany => MSI.GetProperty(GUID, InstallPropertyNames.RegCompany);
        public string RegOwner => MSI.GetProperty(GUID, InstallPropertyNames.RegOwner);
        public string Uninstallable => MSI.GetProperty(GUID, InstallPropertyNames.Uninstallable);
        public string State => MSI.GetProperty(GUID, InstallPropertyNames.State);
        public string PatchType => MSI.GetProperty(GUID, InstallPropertyNames.PatchType);
        public string LUAEnabled => MSI.GetProperty(GUID, InstallPropertyNames.LUAEnabled);
        public string DisplayName => MSI.GetProperty(GUID, InstallPropertyNames.DisplayName);
        public string MoreInfoURL => MSI.GetProperty(GUID, InstallPropertyNames.MoreInfoURL);
        public string LastUsedSource => MSI.GetProperty(GUID, InstallPropertyNames.LastUsedSource);
        public string LastUsedType => MSI.GetProperty(GUID, InstallPropertyNames.LastUsedType);
        public string MediaPackagePath => MSI.GetProperty(GUID, InstallPropertyNames.MediaPackagePath);
        public string DiskPrompt => MSI.GetProperty(GUID, InstallPropertyNames.DiskPrompt);

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

        /// <summary>
        /// Enumerates all MSI installed products
        /// </summary>
        /// <returns>
        /// An enumeration containing InstalledProducts
        /// </returns>
        public static IEnumerable<InstalledProduct> EnumerateInstalledProducts()
        {
            foreach (var guid in MSI.EnumerateGUIDs())
            {
                yield return new InstalledProduct(guid);
            }
        }
    }
}
