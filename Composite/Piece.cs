namespace Composite;

public class Piece: Component
{
    public override string Operation()
    {
        return "Piece";
    }
    

    public override bool IsComposite()
    {
        return false;
    }
}