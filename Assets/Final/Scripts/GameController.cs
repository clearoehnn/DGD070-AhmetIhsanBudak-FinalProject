using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private InputFeature _inputFeature;
    private PlayerControlFeature _controlFeature;
    private ViewFeature _viewFeature;
    
    void Start()
    {
        _contexts = Contexts.sharedInstance;

        _inputFeature = new InputFeature(_contexts);
        _controlFeature = new PlayerControlFeature(_contexts);
        _viewFeature = new ViewFeature(_contexts);

        _inputFeature.Initialize();
        _controlFeature.Initialize();
        _viewFeature.Initialize();
    }

    private void Update()
    {
        _inputFeature.Execute();
        _controlFeature.Execute();
        _viewFeature.Execute();
    }

    private void LateUpdate()
    {
        _inputFeature.Cleanup();
        _controlFeature.Cleanup();
        _viewFeature.Cleanup();
    }
}
