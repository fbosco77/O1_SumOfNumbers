//Example of summing numbers from 1 to N, this would tipycally be implemented by looping from
//1..N, thus O(N) complexity. But, there is a better way with O(1) time complexity:


Console.WriteLine(SumNumbers.GetSumFirstNIntegers(5000));

Console.ReadLine();



public class SumNumbers
{
    public static int GetSumFirstNIntegers(int n)
    {
        //Given eg. n = 5, we have 1, 2, 3, 4, 5. If we have have a reverse sequence (5, 4, 3, 2, 1) and
        //align the columns of both, each column sum would total "6". Since here we have 5 columns, we have
        //5 * 6 = 30. Since we have the sequence duplicated (the original and the reversed) we are double
        //counting each element of the original sequence, so divide by 2 to get the final answer:

        return n * (n + 1) / 2;
    }
}



