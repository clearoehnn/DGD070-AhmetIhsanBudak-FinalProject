using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class MoversFeature : Feature
{
    private Contexts _contexts;

    public MoversFeature(Contexts contexts)
    {
        _contexts = contexts;
    }
}
