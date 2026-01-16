namespace Cleverance_2_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Server_Test()
        {
            var tasks = new List<Task>();

            // 1. Создаем 5 "читателей"
            for (int i = 0; i < 5; i++)
            {
                int readerId = i;
                tasks.Add(Task.Run(() =>
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int val = Cleverance_2.Server.GetCount();
                        Console.WriteLine($"[Читатель {readerId}] Прочитал: {val}");
                        Task.Delay(10).Wait(); // Небольшая пауза
                    }
                }));
            }

            // 2. Создаем 2 "писателей"
            for (int i = 0; i < 2; i++)
            {
                int writerId = i;
                tasks.Add(Task.Run(() =>
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Cleverance_2.Server.AddToCount(10);
                        Console.WriteLine($"---> [Писатель {writerId}] Добавил 10");
                        Task.Delay(25).Wait(); // Писатели работают медленнее
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("Тест завершен. Итоговое значение: " + Cleverance_2.Server.GetCount());
            Console.ReadKey();
        }
    }
}