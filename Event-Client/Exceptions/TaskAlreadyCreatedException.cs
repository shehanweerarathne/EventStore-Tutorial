namespace Event_Client.Exceptions;

public class TaskAlreadyCreatedException: Exception
{
    public TaskAlreadyCreatedException() : base("Task already created.")
    {
        
    }
}