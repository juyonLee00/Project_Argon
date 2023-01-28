using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;

    void OnEnable() 
    {
        movement.Enable();
    }

    void OnDisable() 
    {
        movement.Disable();
    }
    
    void Update()
    {
        float horizontalThrow = movement.ReadValue<Vector2>().x;
        float verticalThrow = movement.ReadValue<Vector2>().y;

        Debug.Log(horizontalThrow);
        Debug.Log(verticalThrow);
    }
}
