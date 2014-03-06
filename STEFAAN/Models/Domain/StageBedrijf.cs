using System;
using System.Collections.Generic;


namespace STEFAAN.Models.Domain
{
    public class StageBedrijf
    {
        #region Properties
        public int StageBedrijfId { get; set; }
        public string StageBedrijfName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string PC { get; set; }
        public string Gemeente { get; set; }
        public string Wachtwoord { get; set; }
        //public virtual City City { get; set; }
        //public virtual ICollection<Order> Orders { get; private set; }
        #endregion

        #region Methods

        
        #endregion
    }
}