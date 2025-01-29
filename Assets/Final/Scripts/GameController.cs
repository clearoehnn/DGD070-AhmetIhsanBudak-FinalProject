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
    private PadInteractionFeature _padInteractionFeature;
    
    void Start()
    {
        _contexts = Contexts.sharedInstance;

        _inputFeature = new InputFeature(_contexts);
        _controlFeature = new PlayerControlFeature(_contexts);
        _viewFeature = new ViewFeature(_contexts);
        _padInteractionFeature = new PadInteractionFeature(_contexts);

        _inputFeature.Initialize();
        _controlFeature.Initialize();
        _viewFeature.Initialize();
        _padInteractionFeature.Initialize();
    }

    private void Update()
    {
        _inputFeature.Execute();
        _controlFeature.Execute();
        _viewFeature.Execute();
        _padInteractionFeature.Execute();
    }

    private void LateUpdate()
    {
        _inputFeature.Cleanup();
        _controlFeature.Cleanup();
        _viewFeature.Cleanup();
        _padInteractionFeature.Cleanup();
    }
}
