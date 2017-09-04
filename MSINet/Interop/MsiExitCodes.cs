﻿namespace MSINet.Interop
{
    /// <summary>
    /// All avalible MSI Setup install exit codes.
    /// </summary>
    public enum MsiExitCodes : uint
    {
        /// <summary>
        /// Action completed successfully.
        /// </summary>
        /// <value>
        /// ERROR_SUCCESS
        /// </value>
        Success = 0,

        /// <summary>
        /// The data is invalid.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_DATA
        /// </value>
        InvalidDataError = 13,

        /// <summary>
        /// One of the parameters was invalid.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_PARAMETER
        /// </value>
        InvalidParameterError = 87,

        /// <summary>
        /// This function is not available for this platform. 
        /// It is only available on Windows 2000 and 
        /// Windows XP with Window Installer version 2.0.
        /// </summary>
        /// <value>
        /// ERROR_CALL_NOT_IMPLEMENTED
        /// </value>
        CallNotImplementedError = 120,


        MoreData = 234,

        /// <summary>
        /// This error happens when there is no more items available for enumeration
        /// </summary>
        NoMoreItems = 259,


        /// <summary>
        /// This error code only occurs when using 
        /// Windows Installer version 2.0 and Windows XP or later. 
        /// If Windows Installer determines a product may be incompatible 
        /// with the current operating system, 
        /// it displays a dialog informing the user and asking whether to try to install anyway. 
        /// This error code is returned if the user chooses not to try the installation.
        /// </summary>
        /// <value>
        /// ERROR_APPHELP_BLOCK 
        /// </value>        
        ApplicationHelpBlockedError = 1259,

        /// <summary>
        /// The Windows Installer service could not be accessed. 
        /// Contact your support personnel to verify that the 
        /// Windows Installer service is properly registered.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SERVICE_FAILURE
        /// </value>
        InstallServiceFailureError = 1601,

        /// <summary>
        /// User cancel installation.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_USEREXIT
        /// </value>
        UserExitError = 1602,

        /// <summary>
        /// Fatal error during installation.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_FAILURE
        /// </value>
        FatalInstallFailureError = 1603,

        /// <summary>
        /// Installation suspended, incomplete.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SUSPEND
        /// </value>
        InstallSuspendedError = 1604,

        /// <summary>
        /// This action is only valid for products that are currently installed.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_PRODUCT
        /// </value>
        UnknownProductError = 1605,

        /// <summary>
        /// Feature ID not registered.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_FEATURE
        /// </value>
        UnknownFeatureError = 1606,

        /// <summary>
        /// Component ID not registered.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_COMPONENT
        /// </value>
        UnknownComponentError = 1607,

        /// <summary>
        /// Unknown property.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_PROPERTY
        /// </value>
        UnknownPropertyError = 1608,

        /// <summary>
        /// Handle is in an invalid state.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_HANDLE_STATE
        /// </value>
        InvalidHandleStateError = 1609,

        /// <summary>
        /// The configuration data for this product is corrupt. 
        /// Contact your support personnel.
        /// </summary>
        /// <value>
        /// ERROR_BAD_CONFIGURATION
        /// </value>
        BadConfigurationError = 1610,

        /// <summary>
        /// Component qualifier not present.
        /// </summary>
        /// <value>
        /// ERROR_INDEX_ABSENT
        /// </value>
        IndexAbsentError = 1611,

        /// <summary>
        /// The installation source for this product is not available. 
        /// Verify that the source exists and that you can access it.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SOURCE_ABSENT
        /// </value>
        InstallSourceAbsentError = 1612,

        /// <summary>
        /// This installation package cannot be installed by the Windows Installer service. 
        /// You must install a Windows service pack that contains 
        /// a newer version of the Windows Installer service.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_VERSION
        /// </value>
        WrongInstallPackageVersionError = 1613,

        /// <summary>
        /// Product is uninstalled.
        /// </summary>
        /// <value>
        /// ERROR_PRODUCT_UNINSTALLED
        /// </value>
        ProductUninstalledError = 1614,

        /// <summary>
        /// SQL query syntax invalid or unsupported.
        /// </summary>
        /// <value>
        /// ERROR_BAD_QUERY_SYNTAX
        /// </value>
        BadQuerySyntaxError = 1615,

        /// <summary>
        /// Record field does not exist.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_FIELD
        /// </value>
        InvalidFieldError = 1616,

        /// <summary>
        /// Another installation is already in progress. 
        /// Complete that installation before proceeding with this install.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_ALREADY_RUNNING
        /// </value>
        InstallInProgressError = 1618,

        /// <summary>
        /// This installation package could not be opened. 
        /// Verify that the package exists and that you can access it, 
        /// or contact the application vendor to verify that 
        /// this is a valid Windows Installer package.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_OPEN_FAILED
        /// </value>
        InstallPackageOpenError = 1619,

        /// <summary>
        /// This installation package could not be opened. 
        /// Contact the application vendor to verify that 
        /// this is a valid Windows Installer package.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_INVALID
        /// </value>
        InstallPackageInvalidError = 1620,

        /// <summary>
        /// There was an error starting the Windows Installer service user interface. 
        /// Contact your support personnel.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_UI_FAILURE
        /// </value>
        InstallUIError = 1621,

        /// <summary>
        /// Error opening installation log file. 
        /// Verify that the specified log file location exists and is writable.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_LOG_FAILURE
        /// </value>
        InstallLogError = 1622,

        /// <summary>
        /// This language of this installation package is not supported by your system.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_LANGUAGE_UNSUPPORTED
        /// </value>
        InstallLanguageUnsupportedError = 1623,

        /// <summary>
        /// Error applying transforms. 
        /// Verify that the specified transform paths are valid.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_TRANSFORM_FAILURE
        /// </value>
        InstallTransformError = 1624,

        /// <summary>
        /// This installation is forbidden by system policy. 
        /// Contact your system administrator.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_REJECTED
        /// </value>
        InstallPackageRejectedError = 1625,

        /// <summary>
        /// Function could not be executed.
        /// </summary>
        /// <value>
        /// ERROR_FUNCTION_NOT_CALLED
        /// </value>
        FunctionNotCalledError = 1626,

        /// <summary>
        /// Function failed during execution.
        /// </summary>
        /// <value>
        /// ERROR_FUNCTION_FAILED
        /// </value>
        FunctionFailedError = 1627,

        /// <summary>
        /// Invalid or unknown table specified.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_TABLE
        /// </value>
        InvalidTableError = 1628,

        /// <summary>
        /// Data supplied is of wrong type.
        /// </summary>
        /// <value>
        /// ERROR_DATATYPE_MISMATCH
        /// </value>
        DatatypeMismatchError = 1629,

        /// <summary>
        /// Data of this type is not supported.
        /// </summary>
        /// <value>
        /// ERROR_UNSUPPORTED_TYPE
        /// </value>
        UnsupportedTypeError = 1630,

        /// <summary>
        /// The Windows Installer service failed to start. 
        /// Contact your support personnel.
        /// </summary>
        /// <value>
        /// ERROR_CREATE_FAILED
        /// </value>
        CreateFailedError = 1631,

        /// <summary>
        /// The temp folder is either full or inaccessible. 
        /// Verify that the temp folder exists and that you can write to it.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_TEMP_UNWRITABLE
        /// </value>
        InstallTempUnwritableError = 1632,

        /// <summary>
        /// This installation package is not supported on this platform. 
        /// Contact your application vendor.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PLATFORM_UNSUPPORTED
        /// </value>
        InstallPlatformUnsupportedError = 1633,

        /// <summary>
        /// Component not used on this machine
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_NOTUSED
        /// </value>
        InstallNotusedError = 1634,

        /// <summary>
        /// This patch package could not be opened. 
        /// Verify that the patch package exists and that you can access it, 
        /// or contact the application vendor to verify that 
        /// this is a valid Windows Installer patch package.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_OPEN_FAILED
        /// </value>
        PatchPackageOpenFailedError = 1635,

        /// <summary>
        /// This patch package could not be opened. 
        /// Contact the application vendor to verify that 
        /// this is a valid Windows Installer patch package.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_INVALID
        /// </value>
        PatchPackageInvalidError = 1636,

        /// <summary>
        /// This patch package cannot be processed by the Windows Installer service. 
        /// You must install a Windows service pack that contains 
        /// a newer version of the Windows Installer service.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_UNSUPPORTED
        /// </value>
        PatchPackageUnsupportedError = 1637,

        /// <summary>
        /// Another version of this product is already installed. 
        /// Installation of this version cannot continue. 
        /// To configure or remove the existing version of this product, 
        /// use Add/Remove Programs on the Control Panel.
        /// </summary>
        /// <value>
        /// ERROR_PRODUCT_VERSION
        /// </value>
        ProductVersionError = 1638,

        /// <summary>
        /// Invalid command line argument. 
        /// Consult the Windows Installer SDK for detailed command line help.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_COMMAND_LINE
        /// </value>
        InvalidCommandLineError = 1639,

        /// <summary>
        /// Installation from a Terminal Server client session not permitted for current user.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_REMOTE_DISALLOWED
        /// </value>
        RemoteInstallDisallowedError = 1640,

        /// <summary>
        /// The installer has started a reboot. 
        /// This error code not available on Windows Installer version 1.0.
        /// </summary>
        /// <value>
        /// ERROR_SUCCESS_REBOOT_INITIATED
        /// </value>
        RebootSuccessInitiatedError = 1641,

        /// <summary>
        /// The installer cannot install the upgrade patch because 
        /// the program being upgraded may be missing or the upgrade 
        /// patch updates a different version of the program. 
        /// Verify that the program to be upgraded exists on your 
        /// computer and that you have the correct upgrade patch. 
        /// </summary>
        /// <value>
        /// ERROR_PATCH_TARGET_NOT_FOUND
        /// </value>
        PatchTargetNotFoundError = 1642,

        /// <summary>
        /// The patch package is not permitted by system policy. 
        /// This error code is available with Windows Installer versions 2.0 or later.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_REJECTED
        /// </value>
        PatchPackageRejectedError = 1643,

        /// <summary>
        /// One or more customizations are not permitted by system policy. 
        /// This error code is available with Windows Installer versions 2.0 or later.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_TRANSFORM_REJECTED
        /// </value>
        InstallTransformRejectedError = 1644,

        /// <summary>
        /// A reboot is required to complete the install. 
        /// This does not include installs where the ForceReboot action is run. 
        /// This error code not available on Windows Installer version 1.0.
        /// </summary>
        /// <value>
        /// ERROR_SUCCESS_REBOOT_REQUIRED
        /// </value>
        RebootRequiredSuccessError = 3010
    }
}
