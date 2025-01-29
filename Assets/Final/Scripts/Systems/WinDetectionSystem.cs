using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Unity.VisualScripting;

public class WinDetectionSystem : ReactiveSystem<GameEntity>
{
    private GameContext _context;
    public MovementSystem MovementSystem;
    
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
        GameEntity player = _context.playerEntity;
        PrefabReference.Instance.wonText.SetActive(true);
        GameObject.Destroy(PrefabReference.Instance.player);
        player.Destroy();
    }
}
