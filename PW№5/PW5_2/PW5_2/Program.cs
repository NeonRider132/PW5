List<IHello> Hi = new List<IHello>();
Hi.Add(new Rus());
Hi.Add(new Chin());
Hi.Add(new Kirgiz());
Hi.Add(new UA());
Hi.Add(new Belorus());
foreach (IHello lang in Hi)
{
    lang.SayHello();
}
Console.ReadKey(true);
interface IHello
{
    void SayHello();
}
class Rus : IHello { public void SayHello() { Console.WriteLine("Привет!"); } }
class Chin : IHello { public void SayHello() { Console.WriteLine("Hai!"); } }
class Kirgiz : IHello { public void SayHello() { Console.WriteLine("Саламатсызбы!"); } }
class UA : IHello { public void SayHello() { Console.WriteLine("Привiт!"); } }
class Belorus : IHello { public void SayHello() { Console.WriteLine("Прывiтанне!"); } }