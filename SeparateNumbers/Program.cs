
//string s = "7";
//string str ="1234";
//string str = "91011";
//string str = "99100";
string str = "9991000";
//string str = "101103";
//string s ="010203";
//string s = "13";
//string s ="1";

var beautiful = false;
var length = str.Length;
var firstsmall = 0;
//Substring(0, 1)
//Substring(1, 2)
//Substring(3, 2)

for (var i = 1; i + 1 < length; i++)
{
    var num = Convert.ToInt64(str.Substring(0, 1));

    if (num == 9)
    {
        var num2digits = Convert.ToInt64(str.Substring(0, 2));
        if (num2digits==99)
        {
            var num3digits = Convert.ToInt64(str.Substring(0, 3));
            if (num3digits==999)
            {
                if ((4 * i - 1) < length)
                {
                    var num2digits2 = Convert.ToInt64(str.Substring((4 * i) - 1, 4));
                    Console.Write(num2digits2 + ",");
                }

            }
            else
            {
                if ((3 * i - 1) < length)
                {
                    var num2digits2 = Convert.ToInt64(str.Substring((3 * i) - 1, 3));
                    Console.Write(num2digits2 + ",");
                }
            }
            
        }
        else
        {
            if ((2 * i - 1) < length)
            {
                var num2 = Convert.ToInt64(str.Substring(2 * i - 1, 2));
                Console.Write(num2 + "*");
            }
        }        
        
    }
    
    else
    {
        var num1 = Convert.ToInt64(str.Substring(i, 1));
        var num2 = Convert.ToInt64(str.Substring(i + 1, 1));
        if (num2 - num1 == 1)
        {
            beautiful = true;
        }
        else
        {
            beautiful = false;
            break;
        }
    }
}

//if (num1 == 9)
//{       

//}
Console.WriteLine();
if (beautiful)
{
    Console.WriteLine($"YES {firstsmall}");
}
else
{
    Console.WriteLine($"NO");
}



