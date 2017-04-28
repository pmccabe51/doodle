using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doodle
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new WPAnalyticsEntities())
            {
                context.Database.Log = Console.Write;

                var test = (from p in context.SubDivisons
                            select new { ID = p.ID, Name = p.SubDivisionName }).ToList();
                context.SaveChangesAsync().Wait();
                Console.ReadLine()
            }

        }
    }
}
