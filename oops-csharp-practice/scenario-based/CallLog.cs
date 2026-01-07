using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS
{
    public class CallLog
    {
        public string PhoneNumber;
        public string Message;
        public DateTime Timestamp;

        public CallLog(string phoneNumber, string message, DateTime timestamp)
        {
            PhoneNumber = phoneNumber;
            Message = message;
            Timestamp = timestamp;
        }

        public void Display()
        {
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Time: {Timestamp}");
        }
    }

    // Manager class
    public class CallLogManager
    {
        private CallLog[] logs;
        private int count;

        public CallLogManager(int size)
        {
            logs = new CallLog[size];
            count = 0;
        }

        // Add a call log
        public void AddCallLog(CallLog log)
        {
            if (count < logs.Length)
            {
                logs[count] = log;
                count++;
            }
            else
            {
                Console.WriteLine("Call log storage is full.");
            }
        }

        // Search logs by keyword in message
        public void SearchByKeyword(string keyword)
        {
            Console.WriteLine($"Searching for keyword: {keyword}");
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    logs[i].Display();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No logs found with the given keyword.");
        }

        // Filter logs by time range
        public void FilterByTime(DateTime startTime, DateTime endTime)
        {
            Console.WriteLine($"Logs between {startTime} and {endTime}");
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].Timestamp >= startTime && logs[i].Timestamp <= endTime)
                {
                    logs[i].Display();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No logs found in the given time range.");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            CallLogManager manager = new CallLogManager(5);

            manager.AddCallLog(new CallLog(
                "9876543210",
                "Network issue reported",
                DateTime.Now.AddHours(-2)));

            manager.AddCallLog(new CallLog(
                "9123456780",
                "Billing related query",
                DateTime.Now.AddHours(-1)));

            manager.AddCallLog(new CallLog(
                "9988776655",
                "Internet speed complaint",
                DateTime.Now));

            // Search by keyword
            manager.SearchByKeyword("Billing");

            // Filter by time range
            DateTime start = DateTime.Now.AddHours(-3);
            DateTime end = DateTime.Now.AddMinutes(-30);

            manager.FilterByTime(start, end);
        }
    }
}
