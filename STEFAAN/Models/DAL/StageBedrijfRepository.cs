using System.Data.Entity;
using System.Linq;
using STEFAAN.Models.Domain;

namespace STEFAAN.Models.DAL
{
    public class StageBedrijfRepository : IStageBedrijfRepository
    {
        private StefaanContext context;
        private DbSet<StageBedrijf> stagebedrijven;

        public StageBedrijfRepository(StefaanContext context)
        {
            this.context = context;
            stagebedrijven = context.StageBedrijven;
        }
        public IQueryable<StageBedrijf> FindAll()
        {
            return stagebedrijven;
        }
        public StageBedrijf FindBy(string stagebedrijfName)
        {
            return stagebedrijven.SingleOrDefault(c => c.StageBedrijfName.Equals(stagebedrijfName));
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Add(StageBedrijf stagebedrijf)
        {
            stagebedrijven.Add(stagebedrijf);
        }
    }
}