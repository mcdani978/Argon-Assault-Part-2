using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float moveSpeed = 10f; // Added speed multiplier

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

    // Update is called once per frame
    void Update()
    {
        float xThrow = movement.ReadValue<Vector2>().x;

        float xOffset = xThrow * moveSpeed * Time.deltaTime;
        float newPosX = transform.localPosition.x + xOffset;

        transform.localPosition = new Vector3(newPosX, transform.localPosition.y, transform.localPosition.z);
    }
}
