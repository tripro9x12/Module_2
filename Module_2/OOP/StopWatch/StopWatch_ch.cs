using System;
namespace StopWatch
{
    public class StopWatch_ch
    {
        private DateTimeOffset startTime;
        private DateTimeOffset endTime;
        public StopWatch_ch()
        {
            startTime = DateTime.Now;
        }
        public DateTimeOffset getterStartTime() => this.startTime;
        public DateTimeOffset getterEndTime() => this.endTime;

        public DateTimeOffset Start()
        {
            startTime = DateTimeOffset.Now;
            return startTime;
        }
        public DateTimeOffset End()
        {
            startTime = DateTimeOffset.Now;
            return startTime;
        }
        public int GetElapsedTime()
        {

            DateTimeOffset start = startTime;
            DateTimeOffset end = endTime;

            int result = -(end.Millisecond - start.Millisecond);

            return result;
        }
        public void InputArr(ref int[] arr)
        {
            var random = new Random();
            // arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 1000);
            }
            Console.WriteLine(arr);
        }
        public void SortArr(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}