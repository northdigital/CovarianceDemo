/*
 * function Test is added to the interface and implemented accordingly in respected classes.
 * Test returns T.
 */
namespace Tutor04
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out T> where T : Animal { T Test(); }

  class MyAnimalClass : IMyInterface<Animal> { public Animal Test() { return null; } }
  class MyDogClass : IMyInterface<Dog> { public Dog Test() { return null; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyDogClass(); }
    }
  }
}