using System;
using System.Linq;

namespace P09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            int bestSequenceSize = 0;
            int bestSequenceStartIndex = 0;
            int bestSequenceSum = 0;
            int[] bestSequence = new int[size];
            int bestSample = 1;

            int sample = 0;

            while (true)
            {
                string line = Console.ReadLine();
                sample += 1;

                if (line == "Clone them!")
                {
                    break;
                }

                int[] sequence = line.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int sequenceSum = 0;
                foreach (var number in sequence)
                {
                    sequenceSum += number;
                }


                for (int i = 0; i < sequence.Length; i++)
                {
                    int currentNumber = sequence[i];
                    if (currentNumber == 0)
                    {
                        continue;
                    }
                    int currentSequenceSize = 1;

                    for (int j = i + 1; j < sequence.Length; j++)
                    {
                        if (currentNumber == sequence[j])
                        {
                            currentSequenceSize += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSequenceSize > bestSequenceSize)
                    {
                        bestSequenceSize = currentSequenceSize;
                        bestSequenceStartIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSequence = sequence;
                        bestSample = sample;
                    }
                    else if (currentSequenceSize == bestSequenceSize)
                    {
                        if (i < bestSequenceStartIndex)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSequence = sequence;
                            bestSample = sample;
                        }
                        else if (i == bestSequenceStartIndex && sequenceSum > bestSequenceSum)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSequence = sequence;
                            bestSample = sample;
                        }

                    }

                }


            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(' ', bestSequence));

        }
    }
}
