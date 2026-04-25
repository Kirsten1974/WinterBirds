using UnityEngine;

public class SimpleBirdMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}