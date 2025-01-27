using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class CreatePlayerHealthSystem : IInitializeSystem
{
    private Contexts _contexts;
    private PlayerHealthComponent _playerHealthComponent;

    public CreatePlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        GameEntity entity = _contexts.game.CreateEntity();
        entity.AddPlayerHealth(100);
    }
}
