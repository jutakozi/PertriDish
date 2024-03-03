class LifeFormCoccus : LifeForm
{
    public LifeFormCoccus(int x, int y) : base(x, y, 100, 1) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Type: Coccus, Position: ({X},{Y}), Lifespan: {LifeSpan}");
    }

    // Coccus needs at least one Bacillus or Spirillum nearby to survive
    public override bool CanSurvive(List<LifeForm> lifeForms)
    {
        int otherBacteriaCount = lifeForms.Count(lf => (lf is LifeFormBacillus || lf is LifeFormSpirillum) && Distance(lf.X, lf.Y, X, Y) <= NearbyRequirement);
        return otherBacteriaCount >= 2;
    }

}


