using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ProcessLeftMouseClickSystem : ReactiveSystem<InputEntity>
{
    private InputContext _inputContext;
    public ProcessLeftMouseClickSystem(Contexts contexts) : base(contexts.input)
    {
        _inputContext = contexts.input;
    }
    
    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.MouseClicked.Added());
    }
    protected override bool Filter(InputEntity entity)
    {
        return (entity.hasMouseClicked && entity.mouseClicked.Value == 0);
    }
    protected override void Execute(List<InputEntity> entities)
    {
        Debug.Log($"Left mouse clicked!");
        foreach (InputEntity entity in entities)
        {
            entity.Destroy();
        }
    }
}
