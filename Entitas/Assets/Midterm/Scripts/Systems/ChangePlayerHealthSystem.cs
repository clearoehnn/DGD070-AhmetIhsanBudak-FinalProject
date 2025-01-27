using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private Contexts _contexts;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        GameEntity[] spawned = _contexts.game.GetEntities();

        foreach (GameEntity entity in spawned)
        {
            if(entity.hasPlayerHealth)
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    entity.isPlayerDamaged = true;
                }

                if (Input.GetKeyDown(KeyCode.H))
                {
                    entity.isPlayerHealed = true;
                }
            }
        }
    }
}
