using UnityEngine;

public class PlayerDetecter : MonoBehaviour
{
    public bool playerDetecter = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerDetecter = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerDetecter = false;
        }
    }
}
