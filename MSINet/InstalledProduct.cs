using MSINet.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSINet
{
    public class InstalledProduct
    {
        public InstalledProduct(Guid guid)
        {
            _guid = guid;
        }

        private readonly Guid _guid;
        
        public Guid GUID => _guid;
        public string InstalledProductName => TryGetProperty(InstallPropertyNames.InstalledProductName);
        public string VersionString => TryGetProperty(InstallPropertyNames.VersionString);
        public string HelpLink => TryGetProperty(InstallPropertyNames.HelpLink);
        public string HelpTelephone => TryGetProperty(InstallPropertyNames.HelpTelephone);
        public string InstallLocation => TryGetProperty(InstallPropertyNames.InstallLocation);
        public string InstallSource => TryGetProperty(InstallPropertyNames.InstallSource);
        public string InstallDate => TryGetProperty(InstallPropertyNames.InstallDate);
        public string Publisher => TryGetProperty(InstallPropertyNames.Publisher);
        public string LocalPackage => TryGetProperty(InstallPropertyNames.LocalPackage);
        public string URLInfoAbout => TryGetProperty(InstallPropertyNames.URLInfoAbout);
        public string URLUpdateInfo => TryGetProperty(InstallPropertyNames.URLUpdateInfo);
        public string VersionMinor => TryGetProperty(InstallPropertyNames.VersionMinor);
        public string VersionMajor => TryGetProperty(InstallPropertyNames.VersionMajor);
        public string ProductID => TryGetProperty(InstallPropertyNames.ProductID);
        public string RegCompany => TryGetProperty(InstallPropertyNames.RegCompany);
        public string RegOwner => TryGetProperty(InstallPropertyNames.RegOwner);
        public string Uninstallable => TryGetProperty(InstallPropertyNames.Uninstallable);
        public string State => TryGetProperty(InstallPropertyNames.State);
        public string PatchType => TryGetProperty(InstallPropertyNames.PatchType);
        public string LUAEnabled => TryGetProperty(InstallPropertyNames.LUAEnabled);
        public string DisplayName => TryGetProperty(InstallPropertyNames.DisplayName);
        public string MoreInfoURL => TryGetProperty(InstallPropertyNames.MoreInfoURL);
        public string LastUsedSource => TryGetProperty(InstallPropertyNames.LastUsedSource);
        public string LastUsedType => TryGetProperty(InstallPropertyNames.LastUsedType);
        public string MediaPackagePath => TryGetProperty(InstallPropertyNames.MediaPackagePath);
        public string DiskPrompt => TryGetProperty(InstallPropertyNames.DiskPrompt);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(InstalledProductName))
            {
                sb.Append(InstalledProductName);
                sb.Append(" ");
            }
            sb.Append(_guid);
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

        private string TryGetProperty(string propertyName)
        {
            string propertyValue;
            if (MSI.TryGetProperty(_guid, propertyName, out propertyValue) != MsiExitCodes.Success)
                propertyValue = null;
            return propertyValue;
        }
    }
}
