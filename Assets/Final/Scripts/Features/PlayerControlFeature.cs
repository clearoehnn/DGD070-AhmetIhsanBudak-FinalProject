using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Unity.VisualScripting;

public class PlayerControlFeature : Feature
{
    private Contexts _contexts;

    public PlayerControlFeature(Contexts contexts)
    {
        //Add(new EntityCreatorSystem(contexts));
        Add(new MovePlayerSystem(contexts));
        //Add(new DestroyPlayerSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
