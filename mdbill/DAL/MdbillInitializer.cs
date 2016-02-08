using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using mdbill.Models;

namespace mdbill.DAL
{
    public class MdbillInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MdbillContext>
    {
        protected override void Seed(MdbillContext context)
        {
            var informations = new List<Information>
            {
            new Information{AccountNo ="loCarson",SiteName ="sAlexander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            new Information{AccountNo ="xCarson",SiteName ="1Alexander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            new Information{AccountNo ="swCarson",SiteName ="2Alexander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            new Information{AccountNo ="sCarson",SiteName ="3Al3exander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            new Information{AccountNo ="Cxarson",SiteName ="4Alexander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            new Information{AccountNo ="xCarson",SiteName ="5Alexander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            new Information{AccountNo ="ssdCarson",SiteName ="6Alexander",Address ="Alexander", DateCreated =DateTime.Parse("2005-09-01"), DateModified =DateTime.Parse("2005-09-01")},
            };
            informations.ForEach(s => context.Informations.Add(s));
            context.SaveChanges();
        }
    }
}