﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _PwSG__Lab3.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Ustawienia : global::System.Configuration.ApplicationSettingsBase {
        
        private static Ustawienia defaultInstance = ((Ustawienia)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Ustawienia())));
        
        public static Ustawienia Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int Wiersze {
            get {
                return ((int)(this["Wiersze"]));
            }
            set {
                this["Wiersze"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int Kolumny {
            get {
                return ((int)(this["Kolumny"]));
            }
            set {
                this["Kolumny"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int Prawdopodobienstwo {
            get {
                return ((int)(this["Prawdopodobienstwo"]));
            }
            set {
                this["Prawdopodobienstwo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color KolorBomba {
            get {
                return ((global::System.Drawing.Color)(this["KolorBomba"]));
            }
            set {
                this["KolorBomba"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Coral")]
        public global::System.Drawing.Color KolorFlaga {
            get {
                return ((global::System.Drawing.Color)(this["KolorFlaga"]));
            }
            set {
                this["KolorFlaga"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LightGray")]
        public global::System.Drawing.Color KolorBezpieczne {
            get {
                return ((global::System.Drawing.Color)(this["KolorBezpieczne"]));
            }
            set {
                this["KolorBezpieczne"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gray")]
        public global::System.Drawing.Color KolorNieodkryte {
            get {
                return ((global::System.Drawing.Color)(this["KolorNieodkryte"]));
            }
            set {
                this["KolorNieodkryte"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ObrazBomba {
            get {
                return ((string)(this["ObrazBomba"]));
            }
            set {
                this["ObrazBomba"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ObrazFlaga {
            get {
                return ((string)(this["ObrazFlaga"]));
            }
            set {
                this["ObrazFlaga"] = value;
            }
        }
    }
}
