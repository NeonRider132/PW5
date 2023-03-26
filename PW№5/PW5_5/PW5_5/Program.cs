List<Wizs> Wizardry = new List<Wizs>();
Wizardry.Add(new Magician(100, "Drow Ranger","Густ"));
Wizardry.Add(new Magician(150, "Lion","Палец"));
Wizardry.Add(new Magician(20, "Arc Warden","Клон"));
foreach (Wizs cast in Wizardry)
{
    cast.spell();
}

Console.ReadKey(true);

interface Wizs
{
    void spell();
}
class Magician : Wizs
{
    public string Effect { get; set; }
    public int Mana { get; set; }
    public string Name { get; set; }
    public Magician(int mana, string name, string effect)
    {
        Effect = effect;
        Mana = mana;
        Name = name;
    }
    public void spell()
    {
        int mana = 100;
        if (Mana >= mana)
        {
            Console.WriteLine(Name + " кастует " + Effect);
            Mana -= mana;
        }
        else
        {
            Console.WriteLine("Для испольования заклинания не хватает " + (Math.Abs(mana - Mana)) + " единиц маны. " + Name + " бездействует!");
        }
    }
}
