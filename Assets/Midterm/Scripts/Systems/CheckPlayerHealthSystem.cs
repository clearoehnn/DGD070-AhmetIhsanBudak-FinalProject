using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private Contexts _contexts;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        GameEntity[] spawned = _contexts.game.GetEntities();

        foreach (GameEntity entity in spawned)
        {
            if (entity.hasPlayerHealth)
            {
                if (entity.isPlayerDamaged)
                {
                    float entityHealth = entity.playerHealth.Value - 10;

                    if (entityHealth < 0)
                    {
                        entityHealth = 0;
                    }
                
                    entity.ReplacePlayerHealth(entityHealth);
                    entity.isPlayerDamaged = false;
                }

                if (entity.isPlayerHealed)
                {
                    float entityHealth = entity.playerHealth.Value + 10;

                    if (entityHealth > 100)
                    {
                        entityHealth = 100;
                    }
                
                    entity.ReplacePlayerHealth(entityHealth);
                    entity.isPlayerHealed = false;
                }
            }
        }
    }
}
