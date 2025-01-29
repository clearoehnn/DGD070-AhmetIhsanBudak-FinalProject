using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

public class PadInitializationSystem : IInitializeSystem
{
    private GameContext _context;
    
    public PadInitializationSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        PrefabReference referenceCatalog = PrefabReference.Instance;
        int numberOfPads = referenceCatalog.padReferences.Length;

        for (int i = 0; i < numberOfPads; i++)
        {
            GameEntity pad = _context.CreateEntity();
            pad.isPad = true;
            pad.AddView(referenceCatalog.padReferences[i]);
            referenceCatalog.padReferences[i].Link(pad);
        }
    }
}
