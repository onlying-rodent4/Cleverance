var tasks = new List<Task>();

// Создаем 5 читателей
for (int i = 0; i < 5; i++)
{
    int ReaderNumber = i;
    tasks.Add(Task.Run(() =>
    {
        for (int j = 0; j < 5; j++)
        {
            int value = Cleverance_2.Server.GetCount();
            Console.WriteLine($"Читатель {ReaderNumber}] Прочитал: {value}");
            Task.Delay(10).Wait();                                     
        }
    }));
}

// Создаем 2 писателя
for (int i = 0; i < 2; i++)
{
    int WriterNumber = i;
    tasks.Add(Task.Run(() =>
    {
        for (int j = 0; j < 2; j++)
        {
            Cleverance_2.Server.AddToCount(10);
            Console.WriteLine($"******** [Писатель {WriterNumber}] Добавил 10");
            Task.Delay(25).Wait();                                       
        }
    }));
}

Task.WaitAll(tasks.ToArray());
Console.WriteLine("Итоговое значение: " + Cleverance_2.Server.GetCount());
Console.ReadKey();