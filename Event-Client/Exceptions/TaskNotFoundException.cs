namespace Event_Client.Exceptions;

public class TaskNotFoundException: Exception
{
    public TaskNotFoundException() : base("Task not found.") { }
}