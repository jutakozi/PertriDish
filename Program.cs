class Program
{
    static void Main(string[] args)
    {
        PetriDish petriDish = new PetriDish();
        petriDish.AddBacillus(3, 5);
        petriDish.AddCoccus(2, 4);
        petriDish.AddSpirillum(1,3);  //Spirillum with random coordinates

        // Display initial contents before interaction
        petriDish.DisplayInitialContents();

        for (int timeUnit = 1; ; timeUnit++)
        {
            Console.WriteLine($"Time Unit: {timeUnit}");
            petriDish.Update();
            petriDish.DisplayInfo();
            Console.ReadLine();
        }
    }

}