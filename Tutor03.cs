namespace Tutor03
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R> where R : Animal {}

  class MyAnimalClass : IMyInterface<Animal> {}
  class MyDogClass : IMyInterface<Dog> {}

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyAnimalClass(); }
      { IMyInterface<Animal> v = new MyDogClass(); } // since R is defined with out keyword, it can be either the exact type or a concrete type.
    }
  }
}