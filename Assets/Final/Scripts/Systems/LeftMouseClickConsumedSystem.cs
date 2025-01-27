using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class LeftMouseClickConsumedSystem : ReactiveSystem<InputEntity>
{
    private InputContext _inputContext;
    public LeftMouseClickConsumedSystem(Contexts contexts) : base(contexts.input)
    {
        _inputContext = contexts.input;
    }
    
    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.MouseClicked.Removed());
    }
    protected override bool Filter(InputEntity entity)
    {
        return true;
    }
    protected override void Execute(List<InputEntity> entities)
    {
        Debug.Log("MouseClicked component consumed");
    }
}
