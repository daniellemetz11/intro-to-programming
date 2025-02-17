
using Castle.Core.Logging;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using StringCalculator;


public class Calculator(){
    public int Add(string numbers){


    var result = numbers.Split(',', '\n').Select(int.Parse).Sum();



    if (numbers == "")
    {
      return 0;
    }
    else if (numbers.Length == 1)
    {
      int character = int.Parse(numbers);

      return character;

    }
    else if (numbers.Contains(','))
    {
      char first_number = numbers[numbers.IndexOf(",") - 1];

      char second_number = numbers[numbers.IndexOf(",") + 1];


      return (int)char.GetNumericValue(first_number) + (int)char.GetNumericValue(second_number);
    }
    else if(numbers.Length > 3)
    {

      return result;
    }

   
    else { return 0; }

    }
}
