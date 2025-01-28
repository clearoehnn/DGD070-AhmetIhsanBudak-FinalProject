using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Unique, Input]
public class HorizontalInputComponent : IComponent
{
    public float Value;
}
