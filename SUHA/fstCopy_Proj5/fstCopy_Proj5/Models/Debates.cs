//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fstCopy_Proj5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Debates
    {
        public int DebateID { get; set; }
        public string DebateTitle { get; set; }
        public System.DateTime DebateDate { get; set; }
        public string Location { get; set; }
        public int Candidate1ID { get; set; }
        public int Candidate2ID { get; set; }
        public string Description { get; set; }
    
        public virtual LocalListCandidates LocalListCandidates { get; set; }
        public virtual LocalListCandidates LocalListCandidates1 { get; set; }
    }
}
