﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.34209
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grabacr07.KanColleViewer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("37564")]
        public int LocalProxyPort {
            get {
                return ((int)(this["LocalProxyPort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.dmm.com/netgame/social/application/-/detail/=/app_id=854854/")]
        public global::System.Uri KanColleUrl {
            get {
                return ((global::System.Uri)(this["KanColleUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("body {\r\n    margin:0;\r\n    overflow:hidden\r\n}\r\n\r\n#game_frame {\r\n    position:fixe" +
            "d;\r\n    left:50%;\r\n    top:-16px;\r\n    margin-left:-450px;\r\n    z-index:1\r\n}")]
        public string OverrideStyleSheet {
            get {
                return ((string)(this["OverrideStyleSheet"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("480")]
        public double UIContentWidth {
            get {
                return ((double)(this["UIContentWidth"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8000")]
        public int FeatureBrowserEmulation {
            get {
                return ((int)(this["FeatureBrowserEmulation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.github.com/FreyYa/KCVKrTranslation/master/resources/Translations/")]
        public global::System.Uri XMLTransUrl {
            get {
                return ((global::System.Uri)(this["XMLTransUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.github.com/FreyYa/KCVKrTranslation/master/resources/Version.xml")]
        public global::System.Uri KCVUpdateUrl {
            get {
                return ((global::System.Uri)(this["KCVUpdateUrl"]));
            }
        }
    }
}
