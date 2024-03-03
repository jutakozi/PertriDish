abstract class LifeForm
{
    public int X { get; set; }
    public int Y { get; set; }
    public int LifeSpan { get; set; }
    public int NearbyRequirement { get; set; }

    protected LifeForm(int x, int y, int lifeSpan, int nearbyRequirement)
    {
        X = x;
        Y = y;
        LifeSpan = lifeSpan;
        NearbyRequirement = nearbyRequirement;
    }

    public abstract void DisplayInfo();

    public abstract bool CanSurvive(List<LifeForm> lifeForms);
    
    protected int Distance(int x1, int y1, int x2, int y2)
    {
        return (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // = (x1−x2) 2 +(y1−y2) 2 
    }

}