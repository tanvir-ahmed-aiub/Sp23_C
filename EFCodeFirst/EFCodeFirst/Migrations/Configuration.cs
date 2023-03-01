namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirst.EF.Models.PMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirst.EF.Models.PMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*for(int i = 0; i < 10; i++)
            {
                context.Categories.AddOrUpdate(
                    new EF.Models.Category() { 
                        Name=Guid.NewGuid().ToString().Substring(0,5),
                    }
                    );
            }*/
            /*Random random = new Random();
            for (int i = 0; i < 1000; i++) {
                context.Products.AddOrUpdate(
                    
                        new EF.Models.Product() { 
                            Name = Guid.NewGuid().ToString().Substring(0,17),
                            Price = random.Next(100,501),
                            Qty = random.Next(10,51),
                            CId = random.Next(1,21)
                        }
                    );
            }*/
        }
    }
}
