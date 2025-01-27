using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class BoosterSystem : IExecuteSystem
{
    private Contexts _contexts;
    public BoosterSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        //Execute
    }
}
