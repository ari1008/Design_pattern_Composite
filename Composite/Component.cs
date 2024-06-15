namespace Composite;

public abstract class Component
{
    protected Component()
    {
    }
    
    public abstract string Operation();
    
    
    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    // You can provide a method that lets the client code figure out whether
    // a component can bear children.
    public virtual bool IsComposite()
    {
        return true;
    }
}