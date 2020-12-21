/*
 * Interface v = ImplementationClassVariable
 *
 * in the implementation
 *  (1) R can be the same or inherit from the inteface R because of the out keyword
 *  (2) P can be the same or a base class of the inteface P because of the in keyword
 *  (3) P must be of the same type as R or inherit from R because of the where clause
 */
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
      { IMyInterface<Dog, Animal> v = new MyAnimalClass(); } // -(3) -(1)
      { IMyInterface<Dog, Dog> v = new MyAnimalClass(); } // (-1)

      { IMyInterface<Animal, Animal> v = new MyDogClass(); } // (-2)
      { IMyInterface<Animal, Dog> v = new MyDogClass(); }
      { IMyInterface<Dog, Animal> v = new MyDogClass(); } // (-3) (-2)
      { IMyInterface<Dog, Dog> v = new MyDogClass(); }
    }
  }
}