public class ReverseInteger
{
    public int Reverse(int n)
    {
        long rev = 0;

        while (n != 0)
        {
            int digit = n % 10;
            rev = rev * 10 + digit;
            n /= 10;
        }

        if (rev > int.MaxValue || rev < int.MinValue)
            return 0;

        return (int)rev;
    }
}
