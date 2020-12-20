/*
 * MyDogClass class implements IMyInterface of type Dog
 * Although Dog inherits from Animal MyDogClass cannot be assigned to IMyInterface<Animal>
 * because MyDogClass implements IMyInterface for Dog and not for required Animal.
 */
namespace Tutor02
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
      { IMyInterface<Animal> v = new MyDogClass(); }
    }
  }
}