namespace Leetcode.Algorithm;

public class IntegerToRomanProblem
{
    private readonly Dictionary<char, int> _map = new Dictionary<char, int>()
    {
        ['M']=  1000,
        ['D']=  500,
        ['C']=  100,
        ['L']=  50,
        ['X']=  10,
        ['V']= 5,
        ['I']= 1
    };
    
    public string IntToRoman(int num) 
    {
        var result = "";

        while (num > 0)
        {
            var multiply = 0;

            if (num >= 1000)
            {
                multiply = num / 1000;
                result += new string('M', multiply);
                num = num - (multiply * 1000);
            }
            else if (num >= 900)
            {
                result += "CM";
                num -= 900;
            }
            else if (num >= 500)
            {
                result += "D";
                num -= 500;
            }
            else if (num >= 400)
            {
                result += "CD";
                num -= 400;
            }
            else if (num >= 100)
            {
                multiply = num / 100;
                result += new string('C', multiply);
                num = num - (multiply * 100);
            }
            else if (num >= 90)
            {
                result += "XC";
                num -= 90;
            }
            else if (num >= 50)
            {
                result += "L";
                num -= 50;
            }
            else if (num >= 40)
            {
                result += "XL";
                num -= 40;
            }
            else if (num >= 10)
            {
                multiply = num / 10;
                result += new string('X', multiply);
                num = num - (multiply * 10);
            }
            else if (num >= 9)
            {
                result += "IX";
                num -= 9;
            }
            else if (num >= 5)
            {
                result += "V";
                num -= 5;
            }
            else if (num >= 4)
            {
                result += "IV";
                num -= 4;
            }
            else
            {
                result += new string('I', num);
                num = 0;
            }
        }
        
        return result;
    }
}