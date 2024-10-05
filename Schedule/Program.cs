using Schedule;

ScheduleForClass mathClass = new ScheduleForClass();
mathClass.StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 30, 0);
mathClass.EndTime = mathClass.StartTime.AddMinutes(80);
mathClass.Subject = "Mathematics";
mathClass.Teacher = "Mr. Johnson";
mathClass.Classroom = "Room 101";

ScheduleForClass physicsClass = new ScheduleForClass();
physicsClass.StartTime = mathClass.EndTime.AddMinutes(10);
physicsClass.EndTime = physicsClass.StartTime.AddMinutes(80);
physicsClass.Subject = "Physics";
physicsClass.Teacher = "Dr. Smith";
physicsClass.Classroom = "Room 102";

Console.WriteLine("Schedule:");

Console.WriteLine("** Math Class **");
Console.WriteLine($"Start Time: {mathClass.StartTime}");
Console.WriteLine($"End Time: {mathClass.EndTime}");
Console.WriteLine($"Subject: {mathClass.Subject}");
Console.WriteLine($"Teacher: {mathClass.Teacher}");
Console.WriteLine($"Classroom: {mathClass.Classroom}");
Console.WriteLine();
Console.WriteLine("---------- Break (10 minutes) ----------");

Console.WriteLine("** Physics Class **");
Console.WriteLine($"Start Time: {physicsClass.StartTime}");
Console.WriteLine($"End Time: {physicsClass.EndTime}");
Console.WriteLine($"Subject: {physicsClass.Subject}");
Console.WriteLine($"Teacher: {physicsClass.Teacher}");
Console.WriteLine($"Classroom: {physicsClass.Classroom}");

bool isLateForMath = ScheduleForClass.IsLate(mathClass.StartTime);

if (isLateForMath)
{
    Console.WriteLine("You are late for the Math class.");
}
else
{
    Console.WriteLine("You aren't late for the Math class.");
}

mathClass.ChangeDuration(90);

ScheduleForClass.SwapClasses(mathClass, physicsClass);

physicsClass.CancelClass();