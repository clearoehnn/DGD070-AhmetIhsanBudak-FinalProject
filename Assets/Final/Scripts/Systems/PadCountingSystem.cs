using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class PadCountingSystem : IExecuteSystem
{
    private GameContext _context;
    private int _numberOfPads;
    private bool _hasWon;

    public PadCountingSystem(Contexts contexts)
    {
        _context = contexts.game;
        _numberOfPads = PrefabReference.Instance.padReferences.Length;
    }
    
    public void Execute()
    {
        GameEntity[] triggeredPads = _context.GetEntities(GameMatcher.PadTriggered);
        if (triggeredPads.Length >= _numberOfPads && !_hasWon)
        {
            _hasWon = true;
            _context.isAllPadsTriggered = true;
        }
    }
}
