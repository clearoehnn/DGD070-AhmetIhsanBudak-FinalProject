using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Entitas;

public class MovementFeature : Feature
{
    Contexts _contexts;

    public MovementFeature(Contexts contexts)
    {
        _contexts = contexts;
        
        Add(new EntityCreatorSystem(contexts));
        
        Add(new FindEntitySystem(contexts));
        Add(new MovementSystem(contexts));
        Add(new BoosterSystem(contexts));
        
        Add(new MovementCompletedSystem(contexts));
    }
    
    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
