using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class MovementSystem : IExecuteSystem
{
    Contexts _contexts;

    public MovementSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        
        GameEntity[] entities = _contexts.game.GetEntities
        (GameMatcher.AllOf(GameMatcher.Position)
            .AnyOf(GameMatcher.Mover, GameMatcher.Speed)
            .NoneOf(GameMatcher.Stopped));
        
        InputEntity[] inputEntitiesHorizontal = _contexts.input.GetEntities(InputMatcher.HorizontalInput);
        InputEntity inputEntityHorizontal = _contexts.input.horizontalInputEntity;
        
        foreach (GameEntity entity in entities)
        {
            Vector3 oldPosition = entity.position.Value;
            Vector3 speed = Vector3.zero;
            
            if (entity.hasSpeed) speed += entity.speed.Value;
            if (entity.hasMover) speed += entity.mover.Value;
            
            if (entity.hasBooster) speed *= (1 + entity.booster.Value);
            if (entity.hasDampener) speed *= (1 - entity.dampener.Value);
            
            Vector3 newPosition = oldPosition + speed * Time.deltaTime;
            entity.ReplacePosition(newPosition);
        }
    }
}
