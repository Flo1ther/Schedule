using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    internal class ScheduleForClass
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string Classroom { get; set; }

        public static bool IsLate(DateTime startTime)
        {
            Console.WriteLine("What time did you arrive? (Format: HH:MM)");
            var arrivalTime = DateTime.Parse(Console.ReadLine());

            return arrivalTime > startTime;
        }

        public void ChangeDuration(int newDuration)
        {
            this.EndTime = this.StartTime.AddMinutes(newDuration);
            Console.WriteLine($"The duration of '{this.Subject}' has been changed to {newDuration} minutes.");
        }

        public void CancelClass()
        {
            this.StartTime = DateTime.MinValue;
            this.EndTime = DateTime.MinValue;
            Console.WriteLine($"The class '{this.Subject}' has been canceled.");
        }

        public static void SwapClasses(ScheduleForClass firstClass, ScheduleForClass secondClass)
        {
            var tempStartTime = firstClass.StartTime;
            var tempEndTime = firstClass.EndTime;
            var tempSubject = firstClass.Subject;
            var tempTeacher = firstClass.Teacher;
            var tempClassroom = firstClass.Classroom;

            firstClass.StartTime = secondClass.StartTime;
            firstClass.EndTime = secondClass.EndTime;
            firstClass.Subject = secondClass.Subject;
            firstClass.Teacher = secondClass.Teacher;
            firstClass.Classroom = secondClass.Classroom;

            secondClass.StartTime = tempStartTime;
            secondClass.EndTime = tempEndTime;
            secondClass.Subject = tempSubject;
            secondClass.Teacher = tempTeacher;
            secondClass.Classroom = tempClassroom;

            Console.WriteLine("The classes have been swapped.");
        }
    }
}
