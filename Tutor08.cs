namespace Tutor08
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R, in P> where R : Animal
                                      where P : R
  {
    R Test(P t);
  }

  class MyAnimal : IMyInterface<Animal, Animal> { public Animal Test(Animal p) { return p; } }
  class MyDog : IMyInterface<Dog, Dog> { public Dog Test(Dog p) { return p; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal, Animal> v = new MyAnimal(); }
      { IMyInterface<Animal, Dog> v = new MyAnimal(); }
      { IMyInterface<Dog, Animal> v = new MyAnimal(); }
      { IMyInterface<Dog, Dog> v = new MyAnimal(); }

      { IMyInterface<Animal, Animal> v = new MyDog(); }
      { IMyInterface<Animal, Dog> v = new MyDog(); }
      { IMyInterface<Dog, Animal> v = new MyDog(); }
      { IMyInterface<Dog, Dog> v = new MyDog(); }
    }
  }
}