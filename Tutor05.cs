/*
 * When we try to use the T generic type as a parameter we get an error.
 * Generic types defined with the out keyword can be used only as return values and not as parameters.
 */
namespace Tutor05
{
  public class Animal { }
  public class Dog : Animal { }

  interface IMyInterface<out T> where T : class { T Test(T p); } // T cannot be used as a parameter.
}