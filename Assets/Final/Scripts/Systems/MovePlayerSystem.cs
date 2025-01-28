using System.Collections;
using System.Collections.Generic;
using Entitas;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayerSystem : IExecuteSystem
{
    private GameContext _context;

    public MovePlayerSystem(Contexts contexts)
    {
        _context = contexts.game;
        
    }

    public void Execute()
    {
        GameEntity entity = _context.playerEntity;
    }
}
