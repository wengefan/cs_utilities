﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utilities.Core.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Utilities.Core.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The minimumLength parameter ({0}) cannot be greater than the maximumLength parameter ({1})..
        /// </summary>
        internal static string Assert_StringInconsistentLengthParameters {
            get {
                return ResourceManager.GetString("Assert_StringInconsistentLengthParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of string parameter &apos;{0}&apos; ({1}) is greater than {2}..
        /// </summary>
        internal static string Assert_StringLengthGreaterThanMaximum {
            get {
                return ResourceManager.GetString("Assert_StringLengthGreaterThanMaximum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of string parameter &apos;{0}&apos; ({1}) is less than {2}..
        /// </summary>
        internal static string Assert_StringLengthLessThanMinimum {
            get {
                return ResourceManager.GetString("Assert_StringLengthLessThanMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of string parameter &apos;{0}&apos; ({1}) does not equal {2}..
        /// </summary>
        internal static string Assert_StringLengthsNotEqual {
            get {
                return ResourceManager.GetString("Assert_StringLengthsNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string parameter &apos;{0}&apos; cannot consist only of whitespace..
        /// </summary>
        internal static string Assert_StringNotWhitespace {
            get {
                return ResourceManager.GetString("Assert_StringNotWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string parameter &apos;{0}&apos; cannot have a length of zero..
        /// </summary>
        internal static string Assert_StringNotZeroLength {
            get {
                return ResourceManager.GetString("Assert_StringNotZeroLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; has a value of &apos;{1}&apos;.  That value cannot be converted to a System.DateTime.  The current thread&apos;s culture is &apos;{2}&apos;..
        /// </summary>
        internal static string CommandLine_BadDateTime {
            get {
                return ResourceManager.GetString("CommandLine_BadDateTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; has a value of &apos;{1}&apos;.  That value cannot be converted to a System.Double.  The current thread&apos;s culture is &apos;{2}&apos;..
        /// </summary>
        internal static string CommandLine_BadDouble {
            get {
                return ResourceManager.GetString("CommandLine_BadDouble", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to T has type &apos;{0}&apos;.  This method requires T to be an enumerated type..
        /// </summary>
        internal static string CommandLine_BadEnumType {
            get {
                return ResourceManager.GetString("CommandLine_BadEnumType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter value &apos;{0}&apos; is not a valid value for the &apos;{1}&apos; enumerated type..
        /// </summary>
        internal static string CommandLine_BadEnumValue {
            get {
                return ResourceManager.GetString("CommandLine_BadEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; has a value of &apos;{1}&apos;.  That value cannot be converted to a System.Int32..
        /// </summary>
        internal static string CommandLine_BadInt32 {
            get {
                return ResourceManager.GetString("CommandLine_BadInt32", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; could not be found..
        /// </summary>
        internal static string CommandLine_ParameterNotFound {
            get {
                return ResourceManager.GetString("CommandLine_ParameterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response file &apos;{0}&apos; could not be processed.  See the InnerException property for details..
        /// </summary>
        internal static string CommandLine_ResponseFileCouldNotBeProcessed {
            get {
                return ResourceManager.GetString("CommandLine_ResponseFileCouldNotBeProcessed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response file &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string CommandLine_ResponseFileDoesNotExist {
            get {
                return ResourceManager.GetString("CommandLine_ResponseFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In response file &apos;{0}&apos;, at line number {1}, the line of command line parameters &apos;{2}&apos; could not be parsed.  Error {3}: {4}.
        /// </summary>
        internal static string CommandLine_ResponseFileLineError {
            get {
                return ResourceManager.GetString("CommandLine_ResponseFileLineError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A quarter of {0} is not valid. quarter must be between 1 and 4 inclusive..
        /// </summary>
        internal static string DateTimeUtils_QuarterNotInRange {
            get {
                return ResourceManager.GetString("DateTimeUtils_QuarterNotInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File does not exist.
        /// </summary>
        internal static string Exceptions_File_Does_Not_Exist {
            get {
                return ResourceManager.GetString("Exceptions_File_Does_Not_Exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Missing file is &apos;{1}&apos;..
        /// </summary>
        internal static string Exceptions_MissingFile {
            get {
                return ResourceManager.GetString("Exceptions_MissingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Stack Trace:{0}{1}.
        /// </summary>
        internal static string Exceptions_StackTrace {
            get {
                return ResourceManager.GetString("Exceptions_StackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file extension &apos;{0}&apos; cannot be converted into an ImageFormat..
        /// </summary>
        internal static string Graphics_BadFileExtension {
            get {
                return ResourceManager.GetString("Graphics_BadFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file name &apos;{0}&apos; has no file extension..
        /// </summary>
        internal static string Graphics_EmptyFileExtension {
            get {
                return ResourceManager.GetString("Graphics_EmptyFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;otherBaseNumber&apos; ({0}) contains digits that are not valid for the parameter &apos;fromBase&apos; {1}..
        /// </summary>
        internal static string MathUtils_BadDigit {
            get {
                return ResourceManager.GetString("MathUtils_BadDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown RangeCheck value ({0})..
        /// </summary>
        internal static string MathUtils_BadRangeCheckValue {
            get {
                return ResourceManager.GetString("MathUtils_BadRangeCheckValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;toBase&apos; has an illegal value of {0}.  toBase must be between 2 and 36, inclusive..
        /// </summary>
        internal static string MathUtils_BaseOutOfRange {
            get {
                return ResourceManager.GetString("MathUtils_BaseOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;min&apos; ({0}) is greater than the parameter &apos;max&apos; ({1})..
        /// </summary>
        internal static string MathUtils_MinGreaterThanMax {
            get {
                return ResourceManager.GetString("MathUtils_MinGreaterThanMax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;count&apos; ({0}) must be greater than zero..
        /// </summary>
        internal static string Random_CountOutOfRange {
            get {
                return ResourceManager.GetString("Random_CountOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;lowChar&apos; ({0}) must be less than &apos;highChar&apos; ({1})..
        /// </summary>
        internal static string Random_LowCharGreaterThanHighChar {
            get {
                return ResourceManager.GetString("Random_LowCharGreaterThanHighChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;lowDate&apos; ({0}) must be less than or equal to &apos;highDate&apos; ({1})..
        /// </summary>
        internal static string Random_LowDateGreaterThanHighDate {
            get {
                return ResourceManager.GetString("Random_LowDateGreaterThanHighDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;low&apos; ({0}) must be less than &apos;high&apos; ({1})..
        /// </summary>
        internal static string Random_LowGreaterThanHigh {
            get {
                return ResourceManager.GetString("Random_LowGreaterThanHigh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;probability&apos; ({0}) must be between 0.0 and 1.0, exclusive..
        /// </summary>
        internal static string Random_ProbabilityNotInRange {
            get {
                return ResourceManager.GetString("Random_ProbabilityNotInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown value of LetterCaseMix enumeration ({0})..
        /// </summary>
        internal static string Random_UnknownLetterCaseMixValue {
            get {
                return ResourceManager.GetString("Random_UnknownLetterCaseMixValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1,Y,T,TRUE,YES.
        /// </summary>
        internal static string StringUtils_BooleanTruthLiterals {
            get {
                return ResourceManager.GetString("StringUtils_BooleanTruthLiterals", resourceCulture);
            }
        }
    }
}
