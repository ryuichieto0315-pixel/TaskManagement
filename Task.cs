using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement
{
    internal class TodoTask
    {
        public int taskId { get; private set; }
        //taskIdの重複を防ぐため別でカウント
        public static int countId { get; private set; } = 1;

        public string? taskName { get; private set; }
        public bool IsCompleted { get; private set; } = false;

        //タスクのリスト
        public static Dictionary<int, TodoTask> AllTask = new Dictionary<int, TodoTask>();
        //var AllTask =new List<int, Task>[] ;
        public TodoTask(string name)
        {
            taskName = name;
            taskId = countId;
            AllTask?.Add(taskId, this);
            countId++;
        }
        public static void CompletedTask(int id)
        {
            if (AllTask.TryGetValue(id, out TodoTask? task))
            {
                task.IsCompleted = true;
                Console.WriteLine("タスクを完了しました。\r\n");
            }
            else
            {
                Console.WriteLine("指定されたIDのタスクは存在しません。\r\n");
            }
        }
    }
}
