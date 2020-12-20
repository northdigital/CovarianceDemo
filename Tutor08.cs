/*
 * in the implementation
 *  (1) T can be the same or inherit from the inteface T
 *  (2) P can be the same or a base class of the inteface P
 *  (3) P must be of the same type as T or inherit from T
 *
 *  (4) P must be the same type as T or inherit from T
 */
namespace Tutor08
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out T, in P> where T : Animal
                                      where P : T

  {
    T Test(P t);
  }


  class MyAnimalClass : IMyInterface<Animal, Animal> { public Animal Test(Animal p) { return p; } }
  class MyDogClass : IMyInterface<Dog, Dog> { public Dog Test(Dog p) { return p; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      { IMyInterface<Animal, Animal> v = new MyAnimalClass(); }
      { IMyInterface<Animal, Dog> v = new MyAnimalClass(); }
      { IMyInterface<Dog, Animal> v = new MyAnimalClass(); } // -(4) -(1)
      { IMyInterface<Dog, Dog> v = new MyAnimalClass(); } // (-1)

      { IMyInterface<Animal, Animal> v = new MyDogClass(); } // (-2)
      { IMyInterface<Animal, Dog> v = new MyDogClass(); }
      { IMyInterface<Dog, Animal> v = new MyDogClass(); } // (-4) (-2)
      { IMyInterface<Dog, Dog> v = new MyDogClass(); }
    }
  }
}