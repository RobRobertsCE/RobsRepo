//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageLog.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MessageLog
    {
        public System.Guid MsgID { get; set; }
        public Nullable<System.DateTime> MsgDateTime { get; set; }
        public Nullable<int> StationNo { get; set; }
        public string ProgramName { get; set; }
        public Nullable<int> EmpNo { get; set; }
        public string MessageText { get; set; }
        public string StackTrace { get; set; }
        public bool Error { get; set; }
    }
}