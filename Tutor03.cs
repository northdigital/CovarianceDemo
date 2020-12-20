/*
 * The generic type T is defined as out.
 * Now T can be either the exact type or a concrete type.
 * Since v is IMyInterface<Animal> T can be an Animal or a Dog.
 * So the error is fixed.
 */
namespace Tutor03
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out T> where T : class {}

  class MyAnimalClass : IMyInterface<Animal> {}
  class MyDogClass : IMyInterface<Dog> {}

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal> v = new MyAnimalClass(); }
      { IMyInterface<Animal> v = new MyDogClass(); }
    }
  }
}