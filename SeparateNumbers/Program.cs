
//string s = "7";
//string s ="1234";
//string s = "91011";
string s = "99100";
//string s = "101103";
//string s ="010203";
//string s = "13";
//string s ="1";


for (int i = 1; i< s.Length; i++)
{
    for (int j = 1; j < s.Length; j++)
    {
        if (i + j < s.Length)
        {
           // var firstnumber = Convert.ToInt64(s.Substring(0, i));

            var secondnumber = Convert.ToInt64(s.Substring(i, j));

            Console.WriteLine($" {i} {i+j}");
            
            //Console.WriteLine($"{secondnumber}-{firstnumber}  => {secondnumber - firstnumber} ");
        }



    }
    
}



