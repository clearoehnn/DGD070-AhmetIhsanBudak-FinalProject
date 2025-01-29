using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class MovementSystem : IExecuteSystem
{
    GameContext _gameContext;
    private InputContext _inputContext;

    public MovementSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
        _inputContext = contexts.input;
    }
    
    public void Execute()
    {

        if (_gameContext.playerEntity == null) return;
        GameEntity player = _gameContext.playerEntity;
        
        if(!player.hasPosition) return;
        
        Vector2 input = _inputContext.playerInput.Value;
        Vector3 displacement = new Vector3(input.x, 0, input.y) * (player.speed.Value * Time.deltaTime);
        Vector3 newPosition = player.position.Value + displacement;

        newPosition = new Vector3(Mathf.Clamp(newPosition.x, -10, 10), 0, Mathf.Clamp(newPosition.z, -5, 5));

        player.ReplacePosition(newPosition);
    }
}
