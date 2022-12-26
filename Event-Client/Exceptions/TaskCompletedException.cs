namespace Event_Client.Exceptions;

public class TaskCompletedException: Exception
{
    public TaskCompletedException() : base("Task Completed.") { }
}