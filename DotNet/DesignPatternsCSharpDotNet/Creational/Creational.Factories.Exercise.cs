using System.Collections.Generic;
using System.Text;

namespace DotNetDesignPatternDemos.Creational.Factories
{
  namespace Coding.Exercise
  {
    public class Person
    {
      public int Id { get; set; }
      public string Name { get; set; }
    }

    public class PersonFactory
    {
      private int id = 0;

      public Person CreatePerson(string name)
      {
        return new Person {Id = id++, Name = name};
      }
    }
  }
}