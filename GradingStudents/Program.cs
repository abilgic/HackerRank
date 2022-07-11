// 4 73 67 38 33
var grades = new List<int> { 73, 67, 38, 33 };
var roundedList = new List<int>();

//85-83 < 2 round up to 85

//x%5=0
foreach (var grade in grades)
{

    var fivedif = 5-(int)Math.Round(Convert.ToDecimal(grade) % 5);

    if (grade >= 38)
    {
        if (fivedif < 3)
        {
            var gradetemp = (int)Math.Round(Convert.ToDecimal(grade) / 5) * 5;
            
            roundedList.Add(gradetemp);
        }
        else
        {
            roundedList.Add(grade);
        }

    }
    else
    {
        roundedList.Add(grade);
    }
}
foreach (var rounded in roundedList)
{
    Console.WriteLine(rounded);
}

