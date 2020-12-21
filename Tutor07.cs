namespace Tutor07
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R, P> where P : Animal
                                   where R : P
  {
    R Test(P p); // the error R cannot be used as a parameter is fixed.
  }

  class MyAnimalClass : IMyInterface<Animal, Animal> { public Animal Test(Animal p) { return p; } }
  class MyDogClass : IMyInterface<Dog, Dog> { public Dog Test(Dog p) { return p; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal, Animal> v = new MyAnimalClass(); }
      { IMyInterface<Animal, Dog> v = new MyAnimalClass(); } // * Animal cannot be converted to Dog (where) & MyAnimalClass accepts an Animal parameter, not a Dog.
      { IMyInterface<Dog, Animal> v = new MyAnimalClass(); } // MyAnimalClass returns Animal not a Dog
      { IMyInterface<Dog, Dog> v = new MyAnimalClass(); } // requires a dog parameter && must return Dog or inherited

      { IMyInterface<Animal, Animal> v = new MyDogClass(); } // MyDog requires a Dog parameter
      { IMyInterface<Animal, Dog> v = new MyDogClass(); } // <-> Animal cannot be converted to Dog (where)
      { IMyInterface<Dog, Animal> v = new MyDogClass(); } // MyDog requires a Dog parameter and Animal cannot be converted to Dog
      { IMyInterface<Dog, Dog> v = new MyDogClass(); }
    }
  }
}