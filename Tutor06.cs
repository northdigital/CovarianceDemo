namespace Tutor06
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out R, P> where P : Animal
                                   where R : P
  {
    R Test(P p); // the error R cannot be used as a parameter is fixed.
  }
}