﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clickerheroes.autoplayer.Properties
{
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"// Buy King Midas and Broyl for some extra starting gold
15, 125, 5, false, true
13, 100, 4, false, true
// Get some starting power from Atlas
27, 1, -1, true, true
27, 10, 0
27, 30, 1
27, 50, 2
27, 100, 3, false, true

// Level important low level ancients and get upgrades
0, 150, 6
1, 100, 4
2, 100, 4
4, 100, 4
5, 100, 4
7, 75, 3
9, 100, 4
11, 100, 4
12, 100, 4
14, 100, 4
16, 125, 4
17, 75, 3
19, 75, 2
20, 100, 4
22, 125, 4
23, 100 ,4
24, 75, 3
25, 75, 3

// Continue progressing Atlas
27, 500, -1, false, true

// Start progressing Terra
28, 1, -1
28, 10, 0
28, 25, 1
28, 50, 2
28, 100, 3, false, true
28, 500, -1, false, true

// Start progressing Phthalo
29, 1, -1
29, 10, 0
29, 25, 1
29, 50, 2
29, 100, 3, false, true
29, 500, -1, false, true

// Start progressing Banana
30, 1, -1
30, 10, 0
30, 25, 1
30, 50, 2
30, 100, 3, false, true
30, 500, -1, false, true

// Start progressing Lilin
31, 1, -1
31, 10, 0
31, 25, 1
31, 50, 2
31, 100, 3, false, true
31, 1500, -1, false, true

// Time to ascend Lilin reached 1500)
Ascend")]
        public string taskList {
            get {
                return ((string)(this["taskList"]));
            }
            set {
                this["taskList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int top {
            get {
                return ((int)(this["top"]));
            }
            set {
                this["top"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int bot {
            get {
                return ((int)(this["bot"]));
            }
            set {
                this["bot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int left {
            get {
                return ((int)(this["left"]));
            }
            set {
                this["left"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int right {
            get {
                return ((int)(this["right"]));
            }
            set {
                this["right"] = value;
            }
        }
    }
}
