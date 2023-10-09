class Piano
{
    static void Main(string[] args)
    {
        Console.WriteLine("Переключение между октавами F2 и F3");
        int[] oneOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        int[] twoOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        int[] threeOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        int[] fourOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
        int[][] listOctave = new int[][] {oneOctave, twoOctave,threeOctave,fourOctave};
        int[] curOctave = listOctave[0];
        int cur = 0;
        ConsoleKeyInfo key = Console.ReadKey();
        while (true)
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Q)
                Sound(curOctave[0]);
            else if (key.Key == ConsoleKey.D1)
                Sound(curOctave[1]);
            else if (key.Key == ConsoleKey.W)
                Sound(curOctave[2]);
            else if (key.Key == ConsoleKey.D3)
                Sound(curOctave[3]);
            else if (key.Key == ConsoleKey.E)
                Sound(curOctave[4]);
            else if (key.Key == ConsoleKey.R)
                Sound(curOctave[5]);
            else if (key.Key == ConsoleKey.D4)
                Sound(curOctave[6]);
            else if (key.Key == ConsoleKey.T)
                Sound(curOctave[7]);
            else if (key.Key == ConsoleKey.D6)
                Sound(curOctave[8]);
            else if (key.Key == ConsoleKey.Y)
                Sound(curOctave[9]);
            else if (key.Key == ConsoleKey.D7)
                Sound(curOctave[10]);
            else if (key.Key == ConsoleKey.U)
                Sound(curOctave[11]);
            else if (key.Key == ConsoleKey.F2 | key.Key == ConsoleKey.F3)
                cur = Octave(key, cur);
                curOctave = listOctave[cur];
        }
    }
    static void Sound(int note)
    {
        Console.Beep(note, 400);
    }
    static int Octave(ConsoleKeyInfo key, int cur)
    {
        if (key.Key == ConsoleKey.F2)
        {
            cur--;
            if (cur == -1)
                return 3;
            else
                return cur;
        }
        else if (key.Key == ConsoleKey.F3)
        {
            cur++;
            if (cur == 4)
                return 0;
            else
                return cur;
        }
        else { return 0; }
    }
}