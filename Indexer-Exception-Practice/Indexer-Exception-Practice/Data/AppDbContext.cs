using Indexer_Exception_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exception_Practice.Data
{
    internal class AppDbContext
    {
       public  Person[] People()
        {
            return new Person[]
            {
                new Person {Id=1,FullName="Meryem Eliyeva",Age=23},
                new Person {Id=2,FullName="Metanet Abbasova",Age=21},
                new Person {Id=10,FullName="Haci Ehmedov",Age=28},

            };
        }
    }
}
