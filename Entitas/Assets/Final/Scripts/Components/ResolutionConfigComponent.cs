using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;


[Unique, Config]
public class ResolutionConfigComponent : IComponent
{
    public Vector2Int Value;
}
