
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

public class Calculator
{
    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        else if(numbers.Length == 1)
        {
            Console.WriteLine(numbers);
            int temp = int.Parse(numbers);
            return temp;
        }
        else if (numbers.Contains(","))
        {
            char first_number = numbers[numbers.IndexOf(",") - 1];

            char second_number = numbers[numbers.IndexOf(",") + 1];


            return (int)char.GetNumericValue(first_number) + (int)char.GetNumericValue(second_number);

        }
        else if(numbers.Length > 3)
        {

            var totalCount = 0;
            for (int i = 0; i < numbers.Length; ++i){
                
                char temp = numbers[i];
                if(temp != ',')
                {
                    totalCount += (int)char.GetNumericValue(temp);
                }
            }

            return totalCount;
        }
        else
        {
            return 0;
        }
    }
}
