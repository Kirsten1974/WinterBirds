using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private float turnSpeed;
    private float horizontalInput;
    private float verticalInput;
    private float flightInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Code automatically puts in what Sabrina's recommended turnSpeed to speed ratio
        //when using rotation functions
        //turnSpeed = speed * 4f;  
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//taken from input manager
        verticalInput = Input.GetAxis("Vertical");
        flightInput = Input.GetAxis("Flight");

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime); //moves forwards or back
        transform.Rotate(Vector3.up* turnSpeed * horizontalInput * Time.deltaTime); //rotates bird
        transform.Rotate(Vector3.left * turnSpeed * flightInput * Time.deltaTime); // makes the bird go up and down by using z and x keys
        //moves left or right 
        //transform.Translate(Vector3.right, turnSpeed * horizontalInput * Time.deltaTime);



    }
}
