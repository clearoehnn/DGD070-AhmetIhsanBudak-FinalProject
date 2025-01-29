using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class PadCountingSystem : IExecuteSystem
{
    private GameContext _context;

    public PadCountingSystem(Contexts contexts)
    {
        _context = contexts.game;
    }
    
    public void Execute()
    {
        
    }
}
