using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement
{
    internal class Menu
    {
        int num;
        string? text;
        public Menu()
        {
            //selectMenu();
        }

        public void selectMenu()
        {
            //if (TodoTask.AllTask.Count == 0)
            //{
            //    registerTask();
            //}
                TaskView tb = new TaskView();

            while (true)
            {
                Console.Write("次の操作を該当する数字で入力してください(1.タスクの追加 /2.タスク完了登録 3.タスク一覧の表示 /4.アプリの終了 )：");
                //数字以外が入力されるまで以下の処理
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("数字で入力してください\r\n");
                    Console.Write("次の操作を該当する数字で入力してください(1.タスクの追加 /2.タスク完了登録 3.タスク一覧の表示 /4.アプリの終了 )：");
                }
                switch (num)
                {
                    case 1:
                        registerTask();
                        break;

                    case 2:
                        if (TodoTask.AllTask.Count == 0)
                        {
                            Console.WriteLine("まだタスクが登録されていません\r\n");
                            break;
                        }

                        tb.View();
                        finishedTask();
                        break;

                    case 3:
                        if (TodoTask.AllTask.Count == 0)
                        {
                            Console.WriteLine("まだタスクが登録されていません\r\n");
                            break;
                        }

                        tb.View();
                        break;

                    case 4:
                        Console.WriteLine("アプリを終了します。");
                        return;
                }
            }

        }
        private void registerTask()
        {

            Console.Write("登録するタスク名を入力してください：");
            text = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(text))
            {
                Console.Write("1文字以上で管理するタスク名を入力してください：");
                text = Console.ReadLine();
            }
            TodoTask task = new TodoTask(text);
            Console.WriteLine($"タスク名「{text}」が登録されました！\r\n");
        }

        private void finishedTask()
        {
            //if (TodoTask.AllTask.Count == 0)
            //{
            //    Console.WriteLine("まだタスクが登録されていません");
            //    return;
            //}

            Console.Write("完了したタスクのIDを入力してください：");
            //数字以外が入力されるまで以下の処理
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("数字で入力してください\r\n");
                Console.Write("完了したタスクのIDを入力してください：");
            }
            TodoTask.CompletedTask(num); 
        }

    }
}
