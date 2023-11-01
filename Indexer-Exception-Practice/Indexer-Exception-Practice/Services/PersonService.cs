using Indexer_Exception_Practice.Data;
using Indexer_Exception_Practice.Models;
using Indexer_Exception_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exception_Practice.Services
{
    internal class PersonService : IPersonService
    {
     private readonly AppDbContext _context;
        public PersonService()
        {
            _context = new AppDbContext();
        }
        Person IPersonService.GetById(int? id)
        {
            if (id == null) throw new ArgumentNullException();

            Person? existPerson=_context.People().FirstOrDefault(x => x.Id == id);
            if (existPerson == null) throw new NullReferenceException("data not found");
            return existPerson;
        }
    }
}