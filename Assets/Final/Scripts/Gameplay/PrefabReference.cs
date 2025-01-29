using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabReference : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject[] padReferences;
    public GameObject wonText;
    public static PrefabReference Instance;
    public GameObject player;

    private void Awake()
    {
        Instance = this;
    }
}
