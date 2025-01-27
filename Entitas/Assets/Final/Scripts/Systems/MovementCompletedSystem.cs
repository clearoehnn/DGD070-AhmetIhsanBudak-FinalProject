using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class MovementCompletedSystem : ICleanupSystem
{
    private Contexts _contexts;
    public MovementCompletedSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    
    public void Cleanup()
    {
        GameEntity[] destroyedEntities = _contexts.game.GetEntities(GameMatcher.Destroyed);
        foreach (GameEntity entity in destroyedEntities)
        {
            entity.Destroy();
        }
    }
}
