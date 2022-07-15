
using DiagonalDifference;

var arr = new List<List<int>> {
                                new List<int>(){11, 2, 4},
                                new List<int>(){4, 5, 6},
                                new List<int>(){10, 8, -12}
                            };
int result = Result.diagonalDifference(arr);
Console.WriteLine($"{result}");
