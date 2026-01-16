using Cleverence_3;

string log_format_1 = "10.03.2025 15:14:49.523 INFORMATION Версия программы: '3.4.0.48729'";
string log_format_2 = "2025-03-10 15:14:51.5882| INFO|11|MobileComputer.GetDeviceId| Код устройства: '@MINDEO-M40-D-410244015546'";

Console.WriteLine("Входные данные: " + Environment.NewLine);
Console.WriteLine(log_format_1 + Environment.NewLine);
Console.WriteLine(log_format_2 + Environment.NewLine + Environment.NewLine);

Console.WriteLine("Приведение к формату: " + Environment.NewLine);
Console.WriteLine(Message.GetFormatMessage(log_format_1) + Environment.NewLine);
Console.WriteLine(Message.GetFormatMessage(log_format_2) + Environment.NewLine + Environment.NewLine);

Console.ReadLine();
