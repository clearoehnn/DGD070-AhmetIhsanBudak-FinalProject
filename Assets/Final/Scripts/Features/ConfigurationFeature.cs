using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class ConfigurationFeature : Feature
{
    private ConfigContext _context;
    
    public ConfigurationFeature(Contexts contexts)
    {
        _context = contexts.config;
        Add(new SetResolutionSystem(contexts));
    }
    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
