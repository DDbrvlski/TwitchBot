﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitchBot.Data {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class DeathCounterUsersPermissions : global::System.Configuration.ApplicationSettingsBase {
        
        private static DeathCounterUsersPermissions defaultInstance = ((DeathCounterUsersPermissions)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DeathCounterUsersPermissions())));
        
        public static DeathCounterUsersPermissions Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Marek\r\nKarek")]
        public string UsersWithPermission {
            get {
                return ((string)(this["UsersWithPermission"]));
            }
            set {
                this["UsersWithPermission"] = value;
            }
        }
    }
}
