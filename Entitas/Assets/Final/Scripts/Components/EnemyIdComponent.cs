using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

public class EnemyIdComponent : IComponent
{
    [EntityIndex] public int Value;
}
