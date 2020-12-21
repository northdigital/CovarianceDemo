namespace Tutor02
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<R> where R : Animal {}

  class MyAnimal : IMyInterface<Animal> {}
  class MyDog : IMyInterface<Dog> {}

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyDog(); } // MyDog implements IMyInterface for Dog and not for required Animal
    }
  }
}