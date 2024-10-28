using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{ 

    [SerializeField] InputAction movement;

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
        float horizontalthrow = movement.ReadValue<Vector2>().x;
        float verticalthrow = movement.ReadValue<Vector2>().y;

        //float horizontalthrow = Input.GetAxis("Horizontal");
        Debug.Log(horizontalthrow);

        //float verticalthrow = Input.GetAxis("Vertical");
        Debug.Log(verticalthrow);
    }
}
