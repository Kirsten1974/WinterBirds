using UnityEngine;

//simple movement script for the bird
//Source: Unity Input System + Transform movement
public class SimpleBirdMovement : MonoBehaviour
{
    //controls how fast the bird moves
    //public so it can be adjusted in Inspector
    public float moveSpeed = 5f;

    //Update runs every frame
    //used to constantly check player input
    private void Update()
    {
        //gets left/right input (A/D or arrow keys)
        float horizontal = Input.GetAxis("Horizontal");

        //gets forward/backward input (W/S or arrow keys)
        float vertical = Input.GetAxis("Vertical");

        //creates a movement direction vector
        //x = horizontal, y = 0 (no up/down), z = vertical
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        //moves the object based on direction, speed, and time
        //Time.deltaTime makes movement smooth and frame-rate independent
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}