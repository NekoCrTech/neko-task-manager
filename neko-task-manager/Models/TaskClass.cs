using neko;
namespace neko_task_manager.Models;

public class TaskClass
{
    public TaskClass()
    {
        Id =  Guid.NewGuid();
        DateCreated = DateTime.UtcNow;
        LastModified = DateCreated;
    }
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public DateTime DateCreated { get; set; }
    public DateTime? TargetDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime LastModified { get; set; }
    
    public Priority Priority { get; set; } = Priority.Medium;
    public Status Status { get; set; } = Status.NotStarted;
    
    public List<string>? Tags { get; set; } 
    public List<TaskClass>? SubTasks { get; set; }
    public bool IsCompleted { get; set; }
}