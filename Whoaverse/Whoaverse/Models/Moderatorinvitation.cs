//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moderatorinvitation
    {
        public int Id { get; set; }
        public string Sent_by { get; set; }
        public System.DateTime Sent_on { get; set; }
        public string Sent_to { get; set; }
        public string Subverse { get; set; }
        public int Power { get; set; }
    }
}
