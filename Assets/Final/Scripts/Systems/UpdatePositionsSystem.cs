using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class UpdatePositionsSystem : ReactiveSystem<GameEntity>
{
    private GameContext _context;

    public UpdatePositionsSystem(Contexts contexts) : base(contexts.game)
    {
        _context = contexts.game;
    }
    
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Position.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            entity.view.Value.transform.position = entity.position.Value;
        }
    }
}
