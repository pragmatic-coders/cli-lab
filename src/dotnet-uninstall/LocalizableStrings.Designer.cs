﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DotNet.Tools.Uninstall {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DotNet.Tools.Uninstall.LocalizableStrings", typeof(LocalizableStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall arm32 .NET Core bundles only.
        /// </summary>
        internal static string Arm32OptionDescription {
            get {
                return ResourceManager.GetString("Arm32OptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specified the bundle type to uninstall.
        /// </summary>
        internal static string BundleTypeNotSpecifiedExceptionMessage {
            get {
                return ResourceManager.GetString("BundleTypeNotSpecifiedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use either command arguments or the specified option: {0}.
        /// </summary>
        internal static string CommandArgOptionConflictExceptionMessageFormat {
            get {
                return ResourceManager.GetString("CommandArgOptionConflictExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified version is not valid: {0}.
        /// </summary>
        internal static string InvalidInputVersionExceptionMessageFormat {
            get {
                return ResourceManager.GetString("InvalidInputVersionExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Linux operating systems are not supported.
        /// </summary>
        internal static string LinuxNotSupportedExceptionMessage {
            get {
                return ResourceManager.GetString("LinuxNotSupportedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List the .NET Core bundles that are installed globally on the machine.
        /// </summary>
        internal static string ListCommandDescription {
            get {
                return ResourceManager.GetString("ListCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Core Runtimes:.
        /// </summary>
        internal static string ListCommandRuntimeHeader {
            get {
                return ResourceManager.GetString("ListCommandRuntimeHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Core SDKs:.
        /// </summary>
        internal static string ListCommandSdkHeader {
            get {
                return ResourceManager.GetString("ListCommandSdkHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current user does not have administrator privileges. Please re-run the command prompt as administrator.
        /// </summary>
        internal static string NotAdminExceptionMessage {
            get {
                return ResourceManager.GetString("NotAdminExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify only one of the options: {0}, {1}.
        /// </summary>
        internal static string OptionsConflictExceptionMessageFormat {
            get {
                return ResourceManager.GetString("OptionsConflictExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required argument missing for the uninstall command.
        /// </summary>
        internal static string RequiredArgMissingForUninstallCommandExceptionMessage {
            get {
                return ResourceManager.GetString("RequiredArgMissingForUninstallCommandExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall .NET Core Runtimes only.
        /// </summary>
        internal static string RuntimeOptionDescription {
            get {
                return ResourceManager.GetString("RuntimeOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall .NET Core SDKs only.
        /// </summary>
        internal static string SdkOptionDescription {
            get {
                return ResourceManager.GetString("SdkOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified version is not found: {0}.
        /// </summary>
        internal static string SpecifiedVersionNotFoundExceptionMessageFormat {
            get {
                return ResourceManager.GetString("SpecifiedVersionNotFoundExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified .NET Core bundle version.
        /// </summary>
        internal static string UninstallAllBelowOptionArgumentDescription {
            get {
                return ResourceManager.GetString("UninstallAllBelowOptionArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BUNDLE-VERSION.
        /// </summary>
        internal static string UninstallAllBelowOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallAllBelowOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core bundles below specified version. The specified version will remain.
        /// </summary>
        internal static string UninstallAllBelowOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllBelowOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core bundles, except the highest version.
        /// </summary>
        internal static string UninstallAllButLatestOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllButLatestOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified .NET Core bundle versions to remain.
        /// </summary>
        internal static string UninstallAllButOptionArgumentDescription {
            get {
                return ResourceManager.GetString("UninstallAllButOptionArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BUNDLE-VERSIONS.
        /// </summary>
        internal static string UninstallAllButOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallAllButOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core bundles, except those listed.
        /// </summary>
        internal static string UninstallAllButOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllButOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core bundles that have been replaced by higher patches.
        /// </summary>
        internal static string UninstallAllLowerPatchesOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllLowerPatchesOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core bundles installed globally on the machine.
        /// </summary>
        internal static string UninstallAllOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core Preview bundles that are marked as previews, except the latest preview.
        /// </summary>
        internal static string UninstallAllPreviewsButLatestOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllPreviewsButLatestOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core Preview bundles that are marked as previews.
        /// </summary>
        internal static string UninstallAllPreviewsOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllPreviewsOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to wait for the uninstallation operation to complete: {0}.
        /// </summary>
        internal static string UninstallationFailedExceptionMessageFormat {
            get {
                return ResourceManager.GetString("UninstallationFailedExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The uninstallation operation failed with the exit code: {1}. Command: {0}.
        /// </summary>
        internal static string UninstallationFailedExceptionWithExitCodeMessageFormat {
            get {
                return ResourceManager.GetString("UninstallationFailedExceptionWithExitCodeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified major.minor version.
        /// </summary>
        internal static string UninstallMajorMinorOptionArgumentDescription {
            get {
                return ResourceManager.GetString("UninstallMajorMinorOptionArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MAJOR-MINOR.
        /// </summary>
        internal static string UninstallMajorMinorOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallMajorMinorOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core bundles that match the specified major.minor version.
        /// </summary>
        internal static string UninstallMajorMinorOptionDescription {
            get {
                return ResourceManager.GetString("UninstallMajorMinorOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified .NET Core bundle versions to uninstall.
        /// </summary>
        internal static string UninstallNoOptionArgumentDescription {
            get {
                return ResourceManager.GetString("UninstallNoOptionArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BUNDLE-VERSIONS.
        /// </summary>
        internal static string UninstallNoOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallNoOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the .NET Core bundles specified.
        /// </summary>
        internal static string UninstallNoOptionDescription {
            get {
                return ResourceManager.GetString("UninstallNoOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified verbosity level.
        /// </summary>
        internal static string UninstallVerbosityOptionArgumentDescription {
            get {
                return ResourceManager.GetString("UninstallVerbosityOptionArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VERBOSITY-LEVEL.
        /// </summary>
        internal static string UninstallVerbosityOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallVerbosityOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the verbosity level. Allowed values are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].
        /// </summary>
        internal static string UninstallVerbosityOptionDescription {
            get {
                return ResourceManager.GetString("UninstallVerbosityOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation was canceled by the user.
        /// </summary>
        internal static string UserCancelationExceptionMessage {
            get {
                return ResourceManager.GetString("UserCancelationExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall x64 .NET Core bundles only.
        /// </summary>
        internal static string X64OptionDescription {
            get {
                return ResourceManager.GetString("X64OptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall x86 .NET Core bundles only.
        /// </summary>
        internal static string X86OptionDescription {
            get {
                return ResourceManager.GetString("X86OptionDescription", resourceCulture);
            }
        }
    }
}
