using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AadharCardNumber
{   public class AadharServiceImpl : IAadharService
    {
        private Aadhar[] aadhars;
        private int size;

        public AadharServiceImpl(int capacity)
        {
            aadhars = new Aadhar[capacity];
            size = 0;
        }

        public void AddAadhar(Aadhar aadhar)
        {
            if (size < aadhars.Length)
            {
                aadhars[size++] = aadhar;
            }
            else
            {
                Console.WriteLine("Storage Full");
            }
        }

        public void DisplayAll()
        {
            if (size == 0)
            {
                Console.WriteLine("No records available");
                return;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(aadhars[i].GetHolderName() + " - " + aadhars[i].GetAadharNumber());
            }
        }

        public void SortAadharNumbers()
        {
            long[] numbers = new long[size];

            for (int i = 0; i < size; i++)
                numbers[i] = aadhars[i].GetAadharNumber();

            RadixSort(numbers);

            Aadhar[] sorted = new Aadhar[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (aadhars[j] != null && aadhars[j].GetAadharNumber() == numbers[i])
                    {
                        sorted[i] = aadhars[j];
                        aadhars[j] = null;
                        break;
                    }
                }
            }
            aadhars = sorted;
        }

        private void RadixSort(long[] arr)
        {
            long max = GetMax(arr);
            for (long exp = 1; max / exp > 0; exp *= 10)
                CountingSort(arr, exp);
        }

        private long GetMax(long[] arr)
        {
            long max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }

        private void CountingSort(long[] arr, long exp)
        {
            int n = arr.Length;
            long[] output = new long[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (int)((arr[i] / exp) % 10);
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)((arr[i] / exp) % 10);
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public int SearchAadhar(long number)
        {
            int low = 0, high = size - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                long midValue = aadhars[mid].GetAadharNumber();

                if (midValue == number)
                    return mid;
                else if (midValue < number)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }

}
