using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private InputFeature _inputFeature;
    
    void Start()
    {
        _contexts = Contexts.sharedInstance;

        _inputFeature = new InputFeature(_contexts);

        _inputFeature.Initialize();
    }

    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        
    }
}
