namespace Tutor07
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R, in P> where R : Animal
                                      where P : R
  {
    R Test(P t);
  }

  class MyAnimalClass : IMyInterface<Animal, Animal> { public Animal Test(Animal p) { return p; } }
  class MyDogClass : IMyInterface<Dog, Dog> { public Dog Test(Dog p) { return p; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal, Animal> v = new MyAnimalClass(); }
      { IMyInterface<Animal, Dog> v = new MyAnimalClass(); } // *
      { IMyInterface<Dog, Animal> v = new MyAnimalClass(); } // Animal is not a Dog (where) && MyAnimalClass returns an Animal not a Dog.
      { IMyInterface<Dog, Dog> v = new MyAnimalClass(); } // MyAnimalClass requires an Animal parameter && returns an Animal.

      { IMyInterface<Animal, Animal> v = new MyDogClass(); } // MyDog requires a Dog parameter & returns a Dog.
      { IMyInterface<Animal, Dog> v = new MyDogClass(); } // <->
      { IMyInterface<Dog, Animal> v = new MyDogClass(); } // Animal is not a Dog (where) && MyDogClass requires a Dog parameter.
      { IMyInterface<Dog, Dog> v = new MyDogClass(); }
    }
  }
}