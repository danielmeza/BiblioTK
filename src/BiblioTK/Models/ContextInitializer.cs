using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace BiblioTK.Models
{
    public class ContextInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Paises.Add(new Country()
            {
                Name = "Colombia",
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
