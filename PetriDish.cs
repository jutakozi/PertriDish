class PetriDish
{
    private List<LifeForm> lifeForms = new List<LifeForm>();

    public void AddBacillus(int x, int y)
    {
        lifeForms.Add(new LifeFormBacillus(x, y));
    }

    public void AddCoccus(int x, int y)
    {
        lifeForms.Add(new LifeFormCoccus(x, y));
    }

    public void AddSpirillum(int x, int y)
    {
        lifeForms.Add(new LifeFormSpirillum(x, y));
    }

    /*public void AddSpirillum()
     {
         Random random = new Random();
         int x = random.Next(0, 10);  // Generate random x coordinate (0-9)
         int y = random.Next(0, 10);  // Generate random y coordinate (0-9)

         lifeForms.Add(new LifeFormSpirillum(x, y));
     }*/
    public void DisplayInitialContents()
    {
        Console.WriteLine("Initial life forms in the Petri dish:");
        foreach (LifeForm lifeForm in lifeForms)
        {
            lifeForm.DisplayInfo();
        }
        Console.WriteLine();
    }


    public void DisplayInfo()
    {
        Console.WriteLine("Current life forms in the Petri dish:");
        foreach (LifeForm lifeForm in lifeForms)
        {
            lifeForm.DisplayInfo();
        }
        Console.WriteLine();
    }


    public void Update()
    {
        List<LifeForm> newLifeForms = new List<LifeForm>();

        foreach (LifeForm lifeForm in lifeForms.ToList())
        {
            lifeForm.LifeSpan--;

            if (lifeForm.LifeSpan <= 0)
            {
                // Split into two new instances of the same type
                for (int i = 0; i < 2; i++)
                {
                    int newX = lifeForm.X + new Random().Next(-lifeForm.NearbyRequirement, lifeForm.NearbyRequirement + 1);
                    int newY = lifeForm.Y + new Random().Next(-lifeForm.NearbyRequirement, lifeForm.NearbyRequirement + 1);

                    newX = Math.Max(0, Math.Min(9, newX));
                    newY = Math.Max(0, Math.Min(9, newY));

                    if (lifeForm is LifeFormBacillus)
                        newLifeForms.Add(new LifeFormBacillus(newX, newY));
                    else if (lifeForm is LifeFormCoccus)
                        newLifeForms.Add(new LifeFormCoccus(newX, newY));
                    else if (lifeForm is LifeFormSpirillum)
                        newLifeForms.Add(new LifeFormSpirillum(newX, newY));
                }
                lifeForms.Remove(lifeForm);
            }
        }

        foreach (LifeForm lifeForm in lifeForms.ToList())
        {
            if (!lifeForm.CanSurvive(lifeForms))
            {
                lifeForms.Remove(lifeForm);
            }
        }

        lifeForms.AddRange(newLifeForms);
    }

}