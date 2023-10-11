using System;
using System.Collections.Generic;

class Piano
{
    private int currentOctaveIndex = 0;
    private List<int[]> octaves;

    public Piano()
    {
        octaves = new List<int[]>
        {
            new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987}, // Октава 5
            new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951}// Октава 7
           
        };
    }
    public void PlayNote(int noteIndex)
    {
        if (noteIndex >= 0 && noteIndex < octaves[currentOctaveIndex].Length)
        {
            int frequency = octaves[currentOctaveIndex][noteIndex];
            Console.Beep(frequency, 300); // Воспроизведение звука
        }
    }

    public void ChangeOctave(int octaveOffset)
    {
        int newOctaveIndex = currentOctaveIndex + octaveOffset;
        if (newOctaveIndex >= 0 && newOctaveIndex < octaves.Count)
        {
            currentOctaveIndex = newOctaveIndex;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Piano piano = new Piano();

        Console.WriteLine("Для выхода нажмите Esc.");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Escape)
                break;

            if (keyInfo.Key == ConsoleKey.F1)
            {
                piano.ChangeOctave(-1); // Переключение на предыдущую октаву
            }
            else if (keyInfo.Key == ConsoleKey.F2)
            {
                piano.ChangeOctave(1); // Переключение на следующую октаву
            }
            else if (keyInfo.Key == ConsoleKey.Q)
            {
                piano.PlayNote(1);
            }
            else if (keyInfo.Key == ConsoleKey.W)
            {
                piano.PlayNote(3);
            }
            else if (keyInfo.Key == ConsoleKey.E)
            {
                piano.PlayNote(6);
            }
            else if (keyInfo.Key == ConsoleKey.R)
            {
                piano.PlayNote(8);
            }
            else if (keyInfo.Key == ConsoleKey.T)
            {
                piano.PlayNote(10);
            }

            else if (keyInfo.Key == ConsoleKey.A)
            {
                piano.PlayNote(0);
            }
            else if (keyInfo.Key == ConsoleKey.S)
            {
                piano.PlayNote(2);
            }
            else if (keyInfo.Key == ConsoleKey.D)
            {
                piano.PlayNote(4);
            }
            else if (keyInfo.Key == ConsoleKey.F)
            {
                piano.PlayNote(5);
            }
            else if (keyInfo.Key == ConsoleKey.F)
            {
                piano.PlayNote(14);
            }
            else if (keyInfo.Key == ConsoleKey.G)
            {
                piano.PlayNote(7);
            }
            else if (keyInfo.Key == ConsoleKey.H)
            {
                piano.PlayNote(9);
            }
            else if (keyInfo.Key == ConsoleKey.J)
            {
                piano.PlayNote(11);

            }
            Console.Clear();

        }
    }
}
