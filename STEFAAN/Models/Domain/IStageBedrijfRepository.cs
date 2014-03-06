using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STEFAAN.Models.Domain
{
    public interface IStageBedrijfRepository
    {
        StageBedrijf FindBy(string email);
        IQueryable<StageBedrijf> FindAll(); 
        void SaveChanges();
        void Add(StageBedrijf stagebedrijf);
    }
}