using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Contexts _contexts;
    private PlayerHealthFeature _playerHealthFeature;
    private CreatePlayerHealthSystem _createPlayerHealthSystem;
    private ChangePlayerHealthSystem _changePlayerHealthSystem;
    private CheckPlayerHealthSystem _checkPlayerHealthSystem;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;

        _playerHealthFeature = new PlayerHealthFeature(_contexts);
        _createPlayerHealthSystem = new CreatePlayerHealthSystem(_contexts);
        _changePlayerHealthSystem = new ChangePlayerHealthSystem(_contexts);
        _checkPlayerHealthSystem = new CheckPlayerHealthSystem(_contexts);
        
        _createPlayerHealthSystem.Initialize();
    }

    private void Update()
    {
        _changePlayerHealthSystem.Execute();
        _checkPlayerHealthSystem.Execute();
    }
}
