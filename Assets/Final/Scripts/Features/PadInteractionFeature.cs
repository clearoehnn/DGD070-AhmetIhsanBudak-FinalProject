using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class PadInteractionFeature : Feature
{
    private GameContext _context;

    private PadInitializationSystem _padInitializationSystem;
    public PadInteractionFeature(Contexts contexts)
    {
        _context = contexts.game;

        Add(new PadInitializationSystem(contexts));
        Add(new PadCountingSystem(contexts));
        Add(new WinDetectionSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
