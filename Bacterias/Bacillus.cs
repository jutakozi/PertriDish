class LifeFormBacillus : LifeForm
{
    public LifeFormBacillus(int x, int y) : base(x, y, 10, 3) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Type: Bacillus, Position: ({X},{Y}), Lifespan: {LifeSpan}");
    }

    // Bacilla need at least one coccus nearby
    public override bool CanSurvive(List<LifeForm> lifeForms)
    {
        return lifeForms.Count(lf => lf is LifeFormCoccus && Distance(lf.X, lf.Y, X, Y) <= NearbyRequirement) >= 1;
    }


}
