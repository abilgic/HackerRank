
using Flippingbits;

List<long> listOfInts = new List<long>{
    //4,
    //16384,
    //16,
    //262144,
    //268435456,
    //1024,
    //1048576,
    //16,
    //16777216,
    2147483648,
    //1,
    //4194304,
    //16384,
    //128
};


foreach (var number in listOfInts)
{
    var result = Flip.FlipNumber(number);
    Console.WriteLine(result);
}




