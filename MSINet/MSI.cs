using MSINet.Interop;
using System;
using System.Collections.Generic;

namespace MSINet
{
    public static class MSI
    {
        /// <summary>
        /// Enumerate all installed product GUIDs
        /// </summary>
        /// <returns>A List of strings containing all GUIDs</returns>
        public static List<string> EnumerateGUIDs()
        {
            var guidList = new List<string>();
            MsiExitCodes ret = 0;
            uint i = 0, dummy2 = 0;
            do
            {
                string GUID = new string(new char[39]);
                object dummy1;
                ret = MsiInterop.MsiEnumProductsEx(null, null, InstallContext.All, i, GUID, out dummy1, null, ref dummy2);
                if (ret == 0)
                {
                    guidList.Add(GUID);
                }
                i++;
            } while (ret != MsiExitCodes.NoMoreItems);

            return guidList;
        }
        /// <summary>
        /// Get property of a product indicated by GUID. Throws exception if cannot read the property.
        /// </summary>
        /// <param name="productGUID">Product GUID</param>
        /// <param name="PropertyName">Property name</param>
        /// <returns>Property value, if available.</returns>
        /// <exception cref="MSIException">Throws MSIException if reading property was not successful</exception>
        public static String getProperty(string productGUID, string PropertyName)
        {
            int len = 0;
            // Get the data len
            MsiInterop.MsiGetProductInfo(productGUID, PropertyName, null, ref len);
            // increase for the terminating \0
            len++;

            String r = new string(new char[len]);
            MsiExitCodes returnValue = MsiInterop.MsiGetProductInfo(productGUID, PropertyName, r, ref len);
            if (returnValue != 0)
                throw new MSIException(returnValue);

            return r;
        }
    }
}
