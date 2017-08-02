using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introspeccion
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new Person(){ Id = 1, Name = "Pedro"},
                new Person(){ Id = 2 }
            };

            //validate persons
            foreach (var person in persons)
            {
                var type = person.GetType();
                var properties = type.GetProperties();
            }
            //convierte a object y muestra su metainformacion
        }
    }

    public class Generic
    {
        public     
    }

    public class Person {

        public int Id { get; set; }
        [StringDatabase(Length = 50)]
        public string Name { get; set; }

        public void Save()
        {

        }
    }
    public interface IValid{
        bool isValid(String value);
     }

    public class StringDatabaseAttribute : Attribute {

        public int Length { get; set; }
        public bool Required { get; set; }

        public bool isValid(String value)
        {
            return true;
        }

        public static List<Generic> ToGeneric(IEnumerable<Object> list) {

            return list.Select(c => new Generic { Obj = c, Type = c.GetType() }).toList();

            var generics = new List<Generic>();
            foreach (var obj in list) {
                generics.Add(new Generic() { Obj = obj, Type = obj.GetType });
            }
            return generics;
        }

    }
}
