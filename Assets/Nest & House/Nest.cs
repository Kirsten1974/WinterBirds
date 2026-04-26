using UnityEngine;

public class Nest : MonoBehaviour
{
    private int storedSticks = 0;

    public int requiredSticks = 20;
    public GameObject birdHousePrefab;
    public Transform spawnPoint;

    private bool houseCreated = false;

    private void OnTriggerEnter(Collider other)
    {
        BirdCollector bird = other.GetComponent<BirdCollector>();

        if (bird != null)
        {
            AddSticksFromBird(bird);
        }
    }

    public void AddSticksFromBird(BirdCollector bird)
    {
        int sticks = bird.GetCarriedSticks();

        storedSticks += sticks;
        bird.RemoveAllSticks();

        Debug.Log("Nest has sticks: " + storedSticks);

        if (storedSticks >= requiredSticks && houseCreated == false)
        {
            CreateBirdHouse();
        }
    }

    private void CreateBirdHouse()
    {
        houseCreated = true;
        Instantiate(birdHousePrefab, spawnPoint.position, spawnPoint.rotation);

        Debug.Log("Bird house created!");
    }
}