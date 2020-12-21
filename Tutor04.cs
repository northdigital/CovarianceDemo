namespace Tutor04
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R> where R : Animal
  {
    R Test();
  }

  class MyAnimal : IMyInterface<Animal> { public Animal Test() { return null; } }
  class MyDog : IMyInterface<Dog> { public Dog Test() { return null; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyDog(); }
    }
  }
}