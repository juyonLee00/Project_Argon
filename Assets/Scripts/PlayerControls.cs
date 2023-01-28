using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float xControlSpeed = 30f;
    [SerializeField] float yControlSpeed = 20f;

    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");
        
        float xOffset = xThrow * Time.deltaTime * xControlSpeed;
        float newXPos = transform.localPosition.x + xOffset;

        float yOffset = yThrow * Time.deltaTime * yControlSpeed;
        float newYPos = transform.localPosition.y + yOffset;

        transform.localPosition = new Vector3
        (newXPos, 
        newYPos,
        transform.localPosition.z);
    }
}
