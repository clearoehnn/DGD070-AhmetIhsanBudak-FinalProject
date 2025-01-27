using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Unity.VisualScripting;

public class InputFeature : Feature
{
    private Contexts _contexts;
    
    public InputFeature(Contexts contexts)
    {
        _contexts = contexts;

        Add(new ListenForInputSystem(contexts));
        Add(new ProcessInputSystem(contexts));
        Add(new ProcessLeftMouseClickSystem(contexts));
        Add(new LeftMouseClickConsumedSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
