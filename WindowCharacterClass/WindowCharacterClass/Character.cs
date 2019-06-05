class Character
{
    //Properties
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string Race { get; set; }
    public string Gender { get; set; }
    public int health { get; set; }
    public int strength { get; set; }
    public int endurance { get; set; }
    public int luck { get; set; }
    public int awareness { get; set; }
    public int charisma { get; set; }
    public int intelligence { get; set; }
    public int wisdom { get; set; }
    public int willpower { get; set; }
    public string helmet { get; set; }
    public string chestPlate { get; set; }
    public string leggings { get; set; }

    //Constructors
    public Character() { } //Default Constructor

    public Character(string fname, string lname, string race, string gender, int hp, int lck, int aware, int charis, int strgth, int endure, string helm, string chestplt, string pants, int intel, int wis, int will)
    {
        firstName = fname;
        lastName = lname;
        Race = race;
        Gender = gender;
        health = hp;
        strength = strgth;
        endurance = endure;
        helmet = helm;
        chestPlate = chestplt;
        leggings = pants;
        luck = lck;
        awareness = aware;
        charisma = charis;
        intelligence = intel;
        wisdom = wis;
        willpower = will;
    }

    //Methods
    public string fullName()
    {
        return firstName + " " + lastName + "\nof the Race: " + Race ;
    }
    public string attributes()
    {
        return "\nHealth Level: " + health + "\nStrength Level: " + strength + "\nEndurance Level: " + endurance + "\nLuck: " + luck + "\nAwareness: " + awareness + "\nCharisma: " + charisma;
    }
    public string armor()
    {
        return "\nHelmet: " + helmet + "\nChest Plate: " + chestPlate + "\nLeggings: " + leggings;
    }
}