namespace Tutor05
{
  public class Animal { }
  public class Dog : Animal { }

  // The generic parameter defined with the out keyword cannot be used as a parameter but only as return value.
  interface IMyInterface<out R> where R : Animal { R Test(R p); }
}