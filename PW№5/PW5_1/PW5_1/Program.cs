List<IAnimal> myAnimals = new List<IAnimal>();
myAnimals.Add(new Cat());
myAnimals.Add(new Bear());
myAnimals.Add(new Owl());
myAnimals.Add(new Worm());
myAnimals.Add(new Tinker());
foreach (IAnimal animal in myAnimals)
{
    PetAnimal(animal);
}
Console.ReadKey(true);

static void PetAnimal(IAnimal animal)
{
    Console.WriteLine("Гладим питомца , а он издаёт звук:");
    animal.Voice();
}
interface IAnimal
{
    void Voice();
}
class Cat : IAnimal { public void Voice() { Console.WriteLine("Мяу!"); } }
class Bear : IAnimal { public void Voice() { Console.WriteLine("*рычит*!"); } }
class Owl : IAnimal
{
    private int GetCurrentTime()
    {
        try { return Convert.ToInt32(File.ReadAllText("current_time.txt")); }
        catch { return 0; }
    }
    public void Voice()
    {
        int currentTime = GetCurrentTime();
        if ((currentTime >= 8) && (currentTime <= 21))
        {
            Console.WriteLine("Тисе, я спю");
        }
        else { Console.WriteLine("Ух! Ух! Ух!"); }
    }
}
class Worm : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("...");
    }
}
class Tinker : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("*Rearm*");
    }
}