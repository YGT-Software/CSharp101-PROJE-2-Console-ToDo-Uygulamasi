public class Directories
{
    public static List<Person> directory = new List<Person>();
    public static List<Kart> toDo = new List<Kart>();
    public static List<Kart> inProgress = new List<Kart>();
    public static List<Kart> done = new List<Kart>();
    public void Directory()
    {
        Menu actions = new Menu();
        directory.Add(new Person(0, "Mahmut Tuncer"));
        directory.Add(new Person(1, "İbrahim Tatlıses"));
        directory.Add(new Person(2, "Seda Sayan"));
        toDo.Add(new Kart("Halay", "Create Team", 0, Buyukluk.XS));
        toDo.Add(new Kart("Mermi", "Create Team", 1, Buyukluk.S));
        toDo.Add(new Kart("Evlilik", "Create Team", 2, Buyukluk.L));
        actions.Menu1(ref toDo, ref inProgress, ref done, directory);

    }
}