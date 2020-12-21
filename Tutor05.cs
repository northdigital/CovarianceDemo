namespace Tutor05
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R> where R : Animal
  {
    R Test(R p);
  }
}