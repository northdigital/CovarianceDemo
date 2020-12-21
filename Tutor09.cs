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
      { IMyInterface<Animal, Animal> v = new MyAnimalClass(); }
      { IMyInterface<Animal, Dog> v = new MyAnimalClass(); }
      { IMyInterface<Dog, Animal> v = new MyAnimalClass(); }
      { IMyInterface<Dog, Dog> v = new MyAnimalClass(); }

      { IMyInterface<Animal, Animal> v = new MyDogClass(); }
      { IMyInterface<Animal, Dog> v = new MyDogClass(); }
      { IMyInterface<Dog, Animal> v = new MyDogClass(); }
      { IMyInterface<Dog, Dog> v = new MyDogClass(); }
    }
  }
}