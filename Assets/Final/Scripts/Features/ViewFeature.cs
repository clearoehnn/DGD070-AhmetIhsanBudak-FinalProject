using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ViewFeature : Feature
{
    private Contexts _contexts;

    public ViewFeature(Contexts contexts)
    {
        _contexts = contexts;

        Add(new SpawnPlayerSystem(contexts));
        Add(new UpdatePositionsSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
