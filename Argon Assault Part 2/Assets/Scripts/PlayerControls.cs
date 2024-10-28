using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float moveSpeed = 10f; 

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    
    void Update()
    {
        float xThrow = movement.ReadValue<Vector2>().x;
        float yThrow = movement.ReadValue<Vector2>().y; 

        float xOffset = xThrow * moveSpeed * Time.deltaTime;
        float yOffset = yThrow * moveSpeed * Time.deltaTime; 

        float newPosX = transform.localPosition.x + xOffset;
        float newPosY = transform.localPosition.y + yOffset; 

        transform.localPosition = new Vector3(newPosX, newPosY, transform.localPosition.z);
    }
}