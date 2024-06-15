namespace Composite;

public class Cardboard : Component
{

    protected List<Component> _children = new List<Component>();
    public Cardboard()
    {
    }

    public override string Operation()
    {
        int i = 0;
        string result = "Branch(";

        foreach (Component component in this._children)
        {
            result += component.Operation();
            if (i != this._children.Count - 1)
            {
                result += "+";
            }
            i++;
        }
            
        return result + ")";
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override bool IsComposite()
    {
        return true;
    }
}