using FluentNHibernate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var session = NHibernateHelper.GetSession())
            {
                // Inserting product to the DB
                /*      var product = new Product
                      {
                          Name = "TVS Star City+",
                          Price = 40000,
                          Units = 1000
                      };
                      session.Save(product);
                      Console.WriteLine("Data inserted Successfully");*/

                // Get all products
           /*  // this is using Linq query
                var products = session.Query<Product>().ToList();*/

                //this is using CreateCriteria in FluentNHibernate
                var products = session.CreateCriteria<Product>().List<Product>();
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Units: {product.Units}");
                }


                // Get by Id
                /*var product = session.Get<Product>(1);
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Units: {product.Units}");*/

                //Update existing Product have to use transaction

                /*    using (var transaction = session.BeginTransaction())
                    {
                        //get a product to update
                        var product = session.Get<Product>(1);
                        product.Units = 8333;
                        session.Update(product);
                        transaction.Commit();
                    }*/

                // Delete the record in Db
                /*      using (var transaction = session.BeginTransaction())
                      {
                          //get a product to update
                          var product = session.Get<Product>(4);
                          if(product != null)
                          {
                              session.Delete(product);
                              Console.WriteLine("Delted successfully");
                          }
                          else
                          {
                              Console.WriteLine("Product is not there please check the ID");
                          }
                          transaction.Commit();
                      }*/
                Console.WriteLine("Please press any key to continue.");
                Console.ReadLine();
            }
        }
    }
}
