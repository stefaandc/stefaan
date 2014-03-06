using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MySql.Data.Entity;
using STEFAAN.Models.DAL.Mapper;
using STEFAAN.Models.Domain;


namespace STEFAAN.Models.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))] 
    public class StefaanContext : DbContext
    {
        public StefaanContext():base("Stefaan")
        {
        }

        public DbSet<StageBedrijf> StageBedrijven { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new StageBedrijfMapper());
            

        }
    }
}