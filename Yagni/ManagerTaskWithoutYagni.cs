namespace Yagni;
// El objetivo es gestionar una lista de tareas. Solo necesitamos una funcionalidad básica para agregar y mostrar tareas.
public class Task
{
    public string Name { get; set; }
    public int Priority { get; set; } // funcionalidad innecesaria
    public DateTime DueDate { get; set; } // Funcionalidad innecesaria
}

public class ManagerTaskWithoutYagni
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(string name, int priority, DateTime dueDate)
    {
        tasks.Add(new Task { Name = name, Priority = priority, DueDate = dueDate });
    }

    public void ShowTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Task: {task.Name}, Priority: {task.Priority}, Due Date: {task.DueDate}");
        }
    }
}
