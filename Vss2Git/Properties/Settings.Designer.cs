﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hpdi.Vss2Git.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VssDirectory {
            get {
                return ((string)(this["VssDirectory"]));
            }
            set {
                this["VssDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$")]
        public string VssProject {
            get {
                return ((string)(this["VssProject"]));
            }
            set {
                this["VssProject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VssExcludePaths {
            get {
                return ((string)(this["VssExcludePaths"]));
            }
            set {
                this["VssExcludePaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OutDirectory {
            get {
                return ((string)(this["OutDirectory"]));
            }
            set {
                this["OutDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string DefaultEmailDomain {
            get {
                return ((string)(this["DefaultEmailDomain"]));
            }
            set {
                this["DefaultEmailDomain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Vss2Git.log")]
        public string LogFile {
            get {
                return ((string)(this["LogFile"]));
            }
            set {
                this["LogFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TranscodeComments {
            get {
                return ((bool)(this["TranscodeComments"]));
            }
            set {
                this["TranscodeComments"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int AnyCommentSeconds {
            get {
                return ((int)(this["AnyCommentSeconds"]));
            }
            set {
                this["AnyCommentSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int SameCommentSeconds {
            get {
                return ((int)(this["SameCommentSeconds"]));
            }
            set {
                this["SameCommentSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ForceAnnotatedTags {
            get {
                return ((bool)(this["ForceAnnotatedTags"]));
            }
            set {
                this["ForceAnnotatedTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("git")]
        public string VcsType {
            get {
                return ((string)(this["VcsType"]));
            }
            set {
                this["VcsType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SvnRepo {
            get {
                return ((string)(this["SvnRepo"]));
            }
            set {
                this["SvnRepo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SvnUser {
            get {
                return ((string)(this["SvnUser"]));
            }
            set {
                this["SvnUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SvnPassword {
            get {
                return ((string)(this["SvnPassword"]));
            }
            set {
                this["SvnPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SvnStandardLayout {
            get {
                return ((bool)(this["SvnStandardLayout"]));
            }
            set {
                this["SvnStandardLayout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("trunk")]
        public string SvnTrunk {
            get {
                return ((string)(this["SvnTrunk"]));
            }
            set {
                this["SvnTrunk"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tags")]
        public string SvnTags {
            get {
                return ((string)(this["SvnTags"]));
            }
            set {
                this["SvnTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("branches")]
        public string SvnBranches {
            get {
                return ((string)(this["SvnBranches"]));
            }
            set {
                this["SvnBranches"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ResetRepo {
            get {
                return ((bool)(this["ResetRepo"]));
            }
            set {
                this["ResetRepo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SvnProjectPath {
            get {
                return ((string)(this["SvnProjectPath"]));
            }
            set {
                this["SvnProjectPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastSettingsFile {
            get {
                return ((string)(this["LastSettingsFile"]));
            }
            set {
                this["LastSettingsFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ContinueSync {
            get {
                return ((bool)(this["ContinueSync"]));
            }
            set {
                this["ContinueSync"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GitFirstCommitIgnoreFile
        {
            get {
                return ((string)(this["GitFirstCommitIgnoreFile"]));
            }
            set {
                this["GitFirstCommitIgnoreFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GitFirstCommitAttributesFile
        {
            get {
                return ((string)(this["GitFirstCommitAttributesFile"]));
            }
            set {
                this["GitFirstCommitAttributesFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GitFirstCommitUserName
        {
            get {
                return ((string)(this["GitFirstCommitUserName"]));
            }
            set {
                this["GitFirstCommitUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GitFirstCommitUserMail
        {
            get {
                return ((string)(this["GitFirstCommitUserMail"]));
            }
            set {
                this["GitFirstCommitUserMail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GitFirstCommitComment
        {
            get {
                return ((string)(this["GitFirstCommitComment"]));
            }
            set {
                this["GitFirstCommitComment"] = value;
            }
        }
    }
}
