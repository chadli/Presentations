﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Attendee.Web_CS.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("VBSLocal")]
        public string DB_Instance {
            get {
                return ((string)(this["DB_Instance"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("2007")]
        public string Year {
            get {
                return ((string)(this["Year"]));
            }
        }
    }
}
