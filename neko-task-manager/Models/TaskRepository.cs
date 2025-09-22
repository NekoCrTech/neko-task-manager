namespace neko_task_manager.Models;

public static class TaskRepository
{
    static List<TaskClass> tasks = new List<TaskClass>();
    
    public static void AddTask(TaskClass task)
    {
        tasks.Add(task);
    }

    public static List<TaskClass> GetTasks() => tasks;

    public static TaskClass? GetTask(Guid id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            return new TaskClass()
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                DateCreated = task.DateCreated,
                TargetDate = task.TargetDate,
                CompletedDate = task.CompletedDate,
                Tags = task.Tags,
                Priority = task.Priority,
                Status = task.Status,
                SubTasks = task.SubTasks,
                IsCompleted = task.IsCompleted
            };
        }
        return null;
    }

    public static void UpdateTask(Guid id, TaskClass task)
    {
        if (task.Id != id) return;
        
        var taskToUpdate = tasks.FirstOrDefault(t => t.Id == id);
        if (taskToUpdate != null)
        {
            taskToUpdate.Name = task.Name;
            taskToUpdate.Description = task.Description;
            taskToUpdate.DateCreated = task.DateCreated;
            taskToUpdate.TargetDate = task.TargetDate;
            taskToUpdate.CompletedDate = task.CompletedDate;
            taskToUpdate.Tags = task.Tags;
            taskToUpdate.Priority = task.Priority;
            taskToUpdate.Status = task.Status;
            taskToUpdate.SubTasks = task.SubTasks;
            taskToUpdate.IsCompleted = task.IsCompleted;
        }
    }

    public static void DeleteTask(Guid id)
    {
        var taskToDelete = tasks.FirstOrDefault(t => t.Id == id);
        if (taskToDelete != null)
        {
            tasks.Remove(taskToDelete);
        }
    }

    public static List<TaskClass> SearchTasks(string taskFilter)
    {
        return tasks.Where(t => t.Name.Contains(taskFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}