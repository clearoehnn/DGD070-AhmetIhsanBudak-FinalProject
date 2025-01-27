using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private Contexts _contexts;
    private MovementFeature _movementFeature;
    private InputFeature _playerInputFeature;
    private ConfigurationFeature _configurationFeature;

    

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        
        _configurationFeature = new ConfigurationFeature(_contexts);
        _movementFeature = new MovementFeature(_contexts);
        _playerInputFeature = new InputFeature(_contexts);
        
        _configurationFeature.Initialize();
        _playerInputFeature.Initialize();
        _movementFeature.Initialize();
    }

    private void Update()
    {
        _configurationFeature.Execute();
        _playerInputFeature.Execute();
        _movementFeature.Execute();
    }

    private void LateUpdate()
    {
        _configurationFeature.Cleanup();
        _playerInputFeature.Cleanup();
        _movementFeature.Cleanup();
    }
}
