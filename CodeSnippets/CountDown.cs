int CountDown(int n)
{
    if (n == 0) // Base case
        return 0;

    Console.WriteLine(n);

    return CountDown(n - 1); // Recursive call
}