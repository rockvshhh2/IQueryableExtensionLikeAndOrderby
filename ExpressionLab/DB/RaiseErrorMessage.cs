// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace ExpressionLab.DB
{

    // RaiseErrorMessage
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RaiseErrorMessage
    {

        ///<summary>
        /// 錯誤代碼
        ///</summary>
        public int ErrorId { get; set; } // ErrorId (Primary key)

        ///<summary>
        /// 主機名稱
        ///</summary>
        public string HostName { get; set; } // HostName (length: 100)

        ///<summary>
        /// 程式名稱
        ///</summary>
        public string ProgramName { get; set; } // ProgramName (length: 200)

        ///<summary>
        /// 使用者名稱
        ///</summary>
        public string UserName { get; set; } // UserName (length: 100)

        ///<summary>
        /// 錯誤代碼
        ///</summary>
        public int? ErrorNumber { get; set; } // ErrorNumber

        ///<summary>
        /// 錯誤安全等級
        ///</summary>
        public int? ErrorSeverity { get; set; } // ErrorSeverity

        ///<summary>
        /// 錯誤狀態
        ///</summary>
        public int? ErrorState { get; set; } // ErrorState

        ///<summary>
        /// 錯誤行數
        ///</summary>
        public int? ErrorLine { get; set; } // ErrorLine

        ///<summary>
        /// 錯誤過程
        ///</summary>
        public string ErrorProcedure { get; set; } // ErrorProcedure (length: 200)

        ///<summary>
        /// 錯誤訊息
        ///</summary>
        public string ErrorMessage { get; set; } // ErrorMessage (length: 4000)

        ///<summary>
        /// 錯誤時間
        ///</summary>
        public System.DateTime? OccurTime { get; set; } // OccurTime
    }

}
// </auto-generated>
