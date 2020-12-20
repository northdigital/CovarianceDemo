/*
 * the variable is of the exact type
 */
namespace Tutor01
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<T> where T : Animal {}

  class MyAnimalClass : IMyInterface<Animal> {}
  class MyDogClass : IMyInterface<Dog> {}

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyAnimalClass(); }
      { IMyInterface<Dog> v = new MyDogClass(); }
    }
  }
}