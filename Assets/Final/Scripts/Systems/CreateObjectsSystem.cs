using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using TMPro.EditorUtilities;

public class CreateObjectsSystem : IInitializeSystem
{
    
    GameContext _context;
    
    public CreateObjectsSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        
    }
}
