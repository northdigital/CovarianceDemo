namespace Tutor09
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
      { IMyInterface<Animal, Animal> v = new MyAnimalClass(); v.Test(new Dog()); }
      { IMyInterface<Animal, Dog> v = new MyAnimalClass(); v.Test(new Dog()); }
      { IMyInterface<Animal, Dog> v = new MyDogClass(); v.Test(new Dog()); }
      { IMyInterface<Dog, Dog> v = new MyDogClass(); v.Test(new Dog()); }
    }
  }
}