//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCLScholarWeb.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WebSetting
    {
        public int SettingID { get; set; }
        public int PeriodID { get; set; }
        public bool ValidationOpen { get; set; }
    
        public virtual ValidationPeriod ValidationPeriod { get; set; }
    }
}