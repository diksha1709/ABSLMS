//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABS_LMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveDetail
    {
        public int LeaveDetailsId { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<decimal> Earned { get; set; }
        public Nullable<decimal> LeaveTaken { get; set; }
        public Nullable<decimal> Approved { get; set; }
        public Nullable<decimal> CarryForward { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
    
        public virtual LeaveType LeaveType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
