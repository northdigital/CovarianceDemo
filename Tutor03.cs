namespace Tutor03
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R> where R : Animal {}

  class MyAnimal : IMyInterface<Animal> {}
  class MyDog : IMyInterface<Dog> {}

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyDog(); }
    }
  }
}