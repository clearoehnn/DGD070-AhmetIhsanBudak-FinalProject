using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;
using static UnityEngine.Object;

public class SpawnPlayerSystem : ReactiveSystem<GameEntity>
{
    private GameContext _context;
    
    public SpawnPlayerSystem(Contexts contexts) : base(contexts.game)
    {
        _context = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.SpawnPlayer.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            GameObject playerObject = Instantiate(PrefabReference.Instance.cubePrefab);
            playerObject.transform.position = entity.position.Value;
            
            entity.AddView(playerObject);
            playerObject.Link(entity);
            
            entity.isSpawnPlayer = false;
        }
    }
}
