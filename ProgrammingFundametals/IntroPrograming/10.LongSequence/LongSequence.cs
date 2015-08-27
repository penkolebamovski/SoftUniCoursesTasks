using System;

class LongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 0; i < 1001; i++)
        {
            if(i%2 == 0) {
                Console.WriteLine(+i);
            }
            else{
                Console.WriteLine(-i);
            }
        }
    }
}

