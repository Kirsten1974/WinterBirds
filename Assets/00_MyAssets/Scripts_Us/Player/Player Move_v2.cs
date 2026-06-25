using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove_v2 : MonoBehaviour
{
    //Value based variables
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;

    //Input system write and read
    [SerializeField] InputAction moveAction; //based on newer input system
    public Vector3 moveInput; //to read input

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turnSpeed = speed * 4;
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector3>();

        //forward and back
        transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * speed); 

        //left and right + rotates with turn
        //transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * moveInput.x * turnSpeed);

        //flies up and down + rotates accordingly
        //transform.Translate(Vector3.up * moveInput.z * speed * Time.deltaTime);
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * moveInput.z);

        
    }
}
