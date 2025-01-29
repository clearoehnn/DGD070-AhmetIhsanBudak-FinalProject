using System;
using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;
using UnityEngine.XR;

public class PadDetector : MonoBehaviour
{
    private EntityLink link;

    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Material _triggeredMaterial;

    private bool _isTriggered;
    
    private void OnTriggerEnter(Collider other)
    {
        if(_isTriggered)
            return;

        _isTriggered = true;
        HandleEntity();
        HandleColour();
    }

    private void HandleEntity()
    {
        link = GetComponent<EntityLink>();
        GameEntity padEntity = link.entity as GameEntity;
        padEntity.isPadTriggered = true;
    }

    private void HandleColour()
    {
        _renderer.material = _triggeredMaterial;
    }
}
