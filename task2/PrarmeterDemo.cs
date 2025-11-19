namespace task2;

class ParameterDemo
{
  public int Increase(ref int number)
  {
    return number += 10;
  }

  public void GetFullName(out string fullName)
  {
    fullName = "ram";
  }

  public int SumAll(params int[] numbers)
  {
    return numbers.Sum();
  }
}
