using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Web.Security;
//using STEFAAN.Infrastructure;
using STEFAAN.Infrastructure;
using STEFAAN.Models.Domain;
using WebMatrix.WebData;

namespace STEFAAN.Models.DAL
{
    public class StefaanInitializer :
                     DropCreateDatabaseAlways<StefaanContext>
    {


        protected override void Seed(StefaanContext context)
        {
            try
            {

                StageBedrijf sb = new StageBedrijf
                {
                    StageBedrijfName = "Hogent",
                    Name = "Bekkens",
                    FirstName = "Anneleen",
                    Street = "valentin Vaerewyckweg, 1",
                    Email = "anneleen.bekkens@hogent.be",
                    PC = "9000",
                    Gemeente = "Gent",
                    Land = "Belgium",
                    Actief = true,
                    Wachtwoord = Encrypt.EncryptPassword("hogent")
                };

                context.StageBedrijven.Add(sb);
                context.SaveChanges();

                
                //SeedMembership();
            }

            catch (DbEntityValidationException e)
            {
                string s = "Fout creatie database ";
                foreach (var eve in e.EntityValidationErrors)
                {
                   s+=String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.GetValidationResult());
                    foreach (var ve in eve.ValidationErrors)
                    {
                        s += String.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new Exception(s);
            }
        }

        
    }
    }
