using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l8z1
{
    public class Program
    {
        static public double[] trinomialFormula(double a, double b, double c)
        {

            double delta = b * b - 4 * a * c;
            double[] wyj;
            if (a == 0 && b == 0 && c == 0)
            {
                wyj = null;
            }
            else if (a == 0.0 && b == 0.0)
            {
                wyj = new double[0];
            }
            else if (b == 0.0 && a != 0 && c != 0)
            {
                wyj = new double[2];
                wyj[0] = Math.Sqrt(c);
                wyj[1] = -Math.Sqrt(c);

            }
            else if (a == 0.0)
            {
                wyj = new double[1];
                wyj[0] = -c / b;
            }
            else if (delta > 0)
            {
                wyj = new double[2];
                wyj[0] = (-b + Math.Sqrt(delta)) / (2 * a);
                wyj[1] = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                wyj = new double[1];
                wyj[0] = (-b) / (2 * a);
            }
            else if (delta < 0)
            {
                wyj = new double[0];
            }
            else
            {
                wyj = new double[0];
            }
            return wyj;
        }
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
