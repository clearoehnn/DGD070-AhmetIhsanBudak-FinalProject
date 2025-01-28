using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Entitas;

public class FindEntitySystem : IExecuteSystem
{
    private GameContext _gameContext; 
    
    public FindEntitySystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }
    
    
    public void Execute()
    {
        for (KeyCode key = KeyCode.Alpha0; key <= KeyCode.Alpha9; key++)
        {
            if (Input.GetKeyDown(key))
            {
                int numericValue = key - KeyCode.Alpha0;
                GameEntity[] entities = _gameContext.GetEntitiesWithEnemyId(numericValue).ToArray();
                
                Debug.Log($"Found {entities.Length} entities with numeric value {numericValue}");
            }
        }
    }
}
