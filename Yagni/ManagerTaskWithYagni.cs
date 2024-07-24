namespace Yagni;
// El objetivo es gestionar una lista de tareas. Solo necesitamos una funcionalidad básica para agregar y mostrar tareas.
public class ManagerTaskWithYagni
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
    }

    public void ShowTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}

