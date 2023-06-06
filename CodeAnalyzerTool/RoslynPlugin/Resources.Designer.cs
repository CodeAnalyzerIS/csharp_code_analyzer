﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoslynPlugin {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoslynPlugin.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Detects whether a local variable can be made a constant. This rule shows for which local variables the &apos;const&apos; keyword can be utilized. It is recommended to change all unchanging variable to constants for code readability and maintanability..
        /// </summary>
        internal static string MakeLocalVariableConstantDescription {
            get {
                return ResourceManager.GetString("MakeLocalVariableConstantDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local variable should be made constant.
        /// </summary>
        internal static string MakeLocalVariableConstantMessageFormat {
            get {
                return ResourceManager.GetString("MakeLocalVariableConstantMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local variable should be made constant.
        /// </summary>
        internal static string MakeLocalVariableConstantTitle {
            get {
                return ResourceManager.GetString("MakeLocalVariableConstantTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detects whether a namespace contains the configured substring. This rule is used for enforcing that all namespaces in your project contain for a certain string (configurable in options)..
        /// </summary>
        internal static string NamespaceContains_Description {
            get {
                return ResourceManager.GetString("NamespaceContains_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Namespace should contain &apos;{0}&apos;.
        /// </summary>
        internal static string NamespaceContains_MessageFormat {
            get {
                return ResourceManager.GetString("NamespaceContains_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Namespaces should contain the configured substring.
        /// </summary>
        internal static string NamespaceContains_Title {
            get {
                return ResourceManager.GetString("NamespaceContains_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detects whether a code block uses a single line statement format without curly braces. This rule purely checks formatting of code, it does not indicate any code smell or mistake. This rule is meant for enforcing a certain code style (requiring braces for all code blocks)..
        /// </summary>
        internal static string RequireBracesInBlock_Description {
            get {
                return ResourceManager.GetString("RequireBracesInBlock_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{&apos; brace expected.
        /// </summary>
        internal static string RequireBracesInBlock_MessageFormat {
            get {
                return ResourceManager.GetString("RequireBracesInBlock_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enclose code block with curly braces.
        /// </summary>
        internal static string RequireBracesInBlock_Title {
            get {
                return ResourceManager.GetString("RequireBracesInBlock_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detects whether a test method contains any assertion statements like Assert.Equals(), Assert.True(), etc. Supports only NUnit tests marked with a [Test] attribute..
        /// </summary>
        internal static string TestMethodWithoutAssertion_Description {
            get {
                return ResourceManager.GetString("TestMethodWithoutAssertion_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test method &apos;{0}&apos; does not contain any assertions.
        /// </summary>
        internal static string TestMethodWithoutAssertion_MessageFormat {
            get {
                return ResourceManager.GetString("TestMethodWithoutAssertion_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test method should contain at least one assertion.
        /// </summary>
        internal static string TestMethodWithoutAssertion_Title {
            get {
                return ResourceManager.GetString("TestMethodWithoutAssertion_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detects whether an unnecessary typecast has been made to access a member (property, method, etc.). The type cast can be removed without any repercussions, and should be removed for maintainability sake..
        /// </summary>
        internal static string UnnecessaryTypeCastDescription {
            get {
                return ResourceManager.GetString("UnnecessaryTypeCastDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary typecast.
        /// </summary>
        internal static string UnnecessaryTypeCastMessageFormat {
            get {
                return ResourceManager.GetString("UnnecessaryTypeCastMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary typecast.
        /// </summary>
        internal static string UnnecessaryTypeCastTitle {
            get {
                return ResourceManager.GetString("UnnecessaryTypeCastTitle", resourceCulture);
            }
        }
    }
}
