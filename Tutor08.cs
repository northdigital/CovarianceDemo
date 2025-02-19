namespace Tutor08
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R, in P> where R : Animal
                                      where P : R
  {
    R Test(P p);
  }

  class MyAnimal : IMyInterface<Animal, Animal> { public Animal Test(Animal p) { return p; } }
  class MyDog : IMyInterface<Dog, Dog> { public Dog Test(Dog p) { return p; } }

  class Tutor
  {
    static void Main(string[] args)
    {
      // 1. Validate the where constraint
      // 2. out generic type -> right inherits left
      // 3. in generic type -> left inherits right
      // 4. any other generic type -> left = right
      { IMyInterface<Animal, Animal> v = new MyAnimal(); } // <Animal, Animal> +1 +2 +3
      { IMyInterface<Animal, Dog> v = new MyAnimal(); }    // <Animal, Animal> +1 +2 +3 NOW SUCCEEDS!
      { IMyInterface<Dog, Animal> v = new MyAnimal(); }    // <Animal, Animal> -1 -2 +3
      { IMyInterface<Dog, Dog> v = new MyAnimal(); }       // <Animal, Animal> +1 -2 -3

      { IMyInterface<Animal, Animal> v = new MyDog(); }    // <Dog, Dog> +1 +2 -3
      { IMyInterface<Animal, Dog> v = new MyDog(); }       // <Dog, Dog> +1 +2 +3
      { IMyInterface<Dog, Animal> v = new MyDog(); }       // <Dog, Dog> -1 +2 -3
      { IMyInterface<Dog, Dog> v = new MyDog(); }          // <Dog, Dog> +1 +2 +3
    }
  }
}