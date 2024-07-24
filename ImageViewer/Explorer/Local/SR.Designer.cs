﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Explorer.Local {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClearCanvas.ImageViewer.Explorer.Local.SR", typeof(SR).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to import the selected items because the local services are not running.
        ///Please ensure the &apos;{0}&apos; is running or contact your system administrator for assistance..
        /// </summary>
        public static string FormatMessageImportWorkItemServiceNotRunning {
            get {
                return ResourceManager.GetString("FormatMessageImportWorkItemServiceNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import.
        /// </summary>
        public static string ImportDicomFiles {
            get {
                return ResourceManager.GetString("ImportDicomFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Activity Monitor.
        /// </summary>
        public static string LinkOpenActivityMonitor {
            get {
                return ResourceManager.GetString("LinkOpenActivityMonitor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open.
        /// </summary>
        public static string MenuOpenFiles {
            get {
                return ResourceManager.GetString("MenuOpenFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initiate an import of the selected items..
        /// </summary>
        public static string MessageFailedToImportSelection {
            get {
                return ResourceManager.GetString("MessageFailedToImportSelection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file could not be found..
        /// </summary>
        public static string MessageFileNotFound {
            get {
                return ResourceManager.GetString("MessageFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} images failed to load..
        /// </summary>
        public static string MessageFormatImagesFailedToLoad {
            get {
                return ResourceManager.GetString("MessageFormatImagesFailedToLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing files from {0} location..
        /// </summary>
        public static string MessageFormatImportingFiles {
            get {
                return ResourceManager.GetString("MessageFormatImportingFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing files from {0} locations..
        /// </summary>
        public static string MessageFormatImportingFilesPlural {
            get {
                return ResourceManager.GetString("MessageFormatImportingFilesPlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified path does not contain any files..
        /// </summary>
        public static string MessageNoFilesSelected {
            get {
                return ResourceManager.GetString("MessageNoFilesSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not have permission to open images in the viewer..
        /// </summary>
        public static string MessagePermissionToOpenFilesDenied {
            get {
                return ResourceManager.GetString("MessagePermissionToOpenFilesDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open images..
        /// </summary>
        public static string MessageUnableToOpenImages {
            get {
                return ResourceManager.GetString("MessageUnableToOpenImages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My Computer.
        /// </summary>
        public static string MyComputer {
            get {
                return ResourceManager.GetString("MyComputer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Dicom Files.
        /// </summary>
        public static string OpenDicomFilesVerbose {
            get {
                return ResourceManager.GetString("OpenDicomFilesVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import DICOM files from the local file system.
        /// </summary>
        public static string TooltipImportDicomFiles {
            get {
                return ResourceManager.GetString("TooltipImportDicomFiles", resourceCulture);
            }
        }
    }
}
