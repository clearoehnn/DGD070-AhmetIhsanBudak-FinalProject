using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ListenForInputSystem : IExecuteSystem
{
    private InputContext _context;
    private float _horizontalInput;
    private float _verticalInput;
    
    
    public ListenForInputSystem(Contexts contexts)
    {
        _context = contexts.input ;
    }
    public void Execute()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        
        _context.ReplaceHorizontalInput(_horizontalInput);
        _context.ReplaceVerticalInput(_verticalInput);
        if (Input.GetMouseButtonDown(0))
        {
            InputEntity mouseClick = _context.CreateEntity();
            mouseClick.AddMouseClicked(0);
        }
        if (Input.GetMouseButtonUp(1))
        {
            InputEntity mouseClick = _context.CreateEntity();
            mouseClick.AddMouseClicked(1);
        }
    }
}
