# MSINet
A C# wrapper for MSI.

Enumerate among all installed products using InstalledProduct.Enumerate() and look for the product by any of its properties. Always containg property access in try/catch block since some products might not have the property you are looking for, thus throwing an MSIException.

Example:

```C#
// Look for installed products containing 'Word' in their name and show their installed location
foreach (var p in InstalledProduct.Enumerate())
{
    try
    {
        if (p.InstalledProductName.Contains("Word"))                     
            Console.Out.WriteLine("{0} is intalled in {1}", p.GUID, p.InstallLocation);                    
    }
    catch (MSIException ex)
    {
        // Some products might throw an exception trying to access InstalledProductName propoerty.
    }
}
```
