namespace Event_Client.Core.Events;

public class CompletedTask
{
    public Guid TaskId { get; set; }
    public string CompletedBy { get; set; }
}