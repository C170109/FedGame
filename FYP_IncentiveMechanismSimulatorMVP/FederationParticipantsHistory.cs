//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYP_IncentiveMechanismSimulatorMVP
{
    using System;
    using System.Collections.Generic;
    
    public partial class FederationParticipantsHistory
    {
        public int Id { get; set; }
        public double Progression { get; set; }
        public double Turn { get; set; }
        public int Pid { get; set; }
        public int ResourceCommitted { get; set; }
        public double DataQuantityCommitted { get; set; }
        public double DataQualityCommitted { get; set; }
        public double BidAmount { get; set; }
        public int Fid { get; set; }
        public int Gid { get; set; }
    
        public virtual Federations Federations { get; set; }
        public virtual Participants Participants { get; set; }
    }
}