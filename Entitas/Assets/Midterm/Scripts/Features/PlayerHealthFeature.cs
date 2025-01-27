using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class PlayerHealthFeature : Feature
{
    private Contexts _contexts;
    public PlayerHealthFeature(Contexts contexts)
    {
        _contexts = contexts;
        Add(new CreatePlayerHealthSystem(contexts));
        Add(new CheckPlayerHealthSystem(contexts));
        Add(new ChangePlayerHealthSystem(contexts));
    }
}
