using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace RestApiAspNetCore.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public long LastName { get; set; }
        public long Adress { get; set; }
        public long Gender { get; set; }
    }
}
