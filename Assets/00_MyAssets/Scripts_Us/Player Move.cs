using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    private float horizontalInput;
    private float verticalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//taken from input manager
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime); //moves forwards or back
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime); //moves left or right
     
             

        }
}
