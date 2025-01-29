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
        return context.CreateCollector(GameMatcher.AllPadsTriggered.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        PrefabReference.Instance.wonText.SetActive(true);
    }
}
