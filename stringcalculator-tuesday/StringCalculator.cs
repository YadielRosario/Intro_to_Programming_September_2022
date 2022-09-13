
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers != "")
        {
            List<string> numberList = new List<string>();
            if (numbers[0] == '/' && numbers[1] == '/')
            {
                var list = numbers.Split(numbers[2], '\n');
                numberList.AddRange(list);
                numberList.RemoveRange(0, 2);
            }
            else
            {
                var list = numbers.Split(',', '\n'); //need to figure out how to conver /n to Environment.NewLine
                numberList.AddRange(list);
               
            }
           
            var lengthOfList = numberList.Count;

            int totalNumber = 0;

            foreach ( var number in numberList)
            {
                
                totalNumber = Int32.Parse(number) + totalNumber;
            }
 
            
            return totalNumber;
        }
        else
        {
            return 0;   
        }

        
    }
}
