namespace Tutor04
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R> where R : Animal
  {
    R Test(); // Function Test is added to the interface and implemented accordingly in respected classes. Test return a R.
  }

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