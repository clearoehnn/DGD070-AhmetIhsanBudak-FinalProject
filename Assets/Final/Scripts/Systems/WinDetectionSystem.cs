using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class WinDetectionSystem : ReactiveSystem<GameEntity>
{
    private GameContext _context;
    
    public WinDetectionSystem(Contexts contexts) : base(contexts.game)
    {
        _context = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return null;
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        
    }
}
