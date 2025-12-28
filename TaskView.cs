using System.Threading.Tasks;

namespace TaskManagement
{
    internal class TaskView
    {
        public TaskView()
        {
            //View();
        }
        public void View()
        {
            //タスクをすべて抽出
            foreach (var task in TodoTask.AllTask.Values)
            {
                //TodoTask task = TodoTask.AllTask[id];
                //タスクが完了か否かで分岐
                if (task.IsCompleted)
                {
                    Console.WriteLine($"[{task.taskId}] {task.taskName} - 完了");
                }
                else
                {
                    Console.WriteLine($"[{task.taskId}] {task.taskName} - 未完了");
                }
            }
            Console.WriteLine("");
        }
    }
}
