using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class EntityCreatorSystem : IInitializeSystem
{
    private GameContext _context;
    private const float _speed = 10f;
    public EntityCreatorSystem(Contexts contexts)
    {
        _context = contexts.game;
    }
    
    public void Initialize()
    {
        GameEntity player = _context.CreateEntity();
        player.isPlayer = true;
        player.AddPosition(Vector3.zero);
        player.AddSpeed(_speed);
    }
}
