using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestApiAspNetCore.Model;
using RestApiAspNetCore.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestApiAspNetCore.Services.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private MySqlContext _context;

        public PersonBusinessImpl(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return person;
        }

        public void Delete(int id)
        {
            try
            {
                var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
                if (result != null)
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public Person Update(Person person)
        {
            try
            {
                if (!Exist(person.Id))
                    new Person();

                var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return person;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(int id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        private bool Exist(long? id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
