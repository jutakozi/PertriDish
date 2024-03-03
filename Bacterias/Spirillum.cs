class LifeFormSpirillum : LifeForm
{
    public LifeFormSpirillum(int x, int y) : base(x, y, 40, 2) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Type: Spirillum, Position: ({X},{Y}), Lifespan: {LifeSpan}");
    }
    //Spirilla die if there is a Bacillus nearby.
    public override bool CanSurvive(List<LifeForm> lifeForms)
    {
        return !lifeForms.Any(lf => lf is LifeFormBacillus && Distance(lf.X, lf.Y, X, Y) <= NearbyRequirement);
    }


}