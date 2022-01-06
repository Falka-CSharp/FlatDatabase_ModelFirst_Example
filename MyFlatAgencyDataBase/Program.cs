using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFlatAgencyDataBase.Data;
namespace MyFlatAgencyDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1Container m = new Model1Container();
            Flat f = new Flat();
            Client c = new Client();
            c.Flats.Add(f);
            m.ClientSet.Add(c);
            m.FlatSet.Add(f);
            m.SaveChanges();
        }
    }
}
