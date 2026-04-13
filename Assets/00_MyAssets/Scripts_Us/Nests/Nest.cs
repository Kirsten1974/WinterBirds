using UnityEngine;

public class Nest : MonoBehaviour

//want the nest's own health to deteriorate slowly over time
//nest will provide health to player
{
    /* [SerializeField] private */
    public float nestMaxHealth;
    public float nestCurrentHealth;

    public Vector3 originalNestSize;
    private bool nestLost = false;

    public void DoDamage(int amount)
    {
        throw new System.NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalNestSize = transform.lossyScale;
    }

    // Update is called once per frame
    void Update()
    {
        //do
        //{
        //    nestHealth = nestHealth - Time.deltaTime;
        //    Debug.Log(nestHealth);
        //}
        //while (nestHealth > 0f);
        if (nestLost == false)
        {
            float healthPercent = nestCurrentHealth / nestMaxHealth;
            transform.localScale = new Vector3(healthPercent, healthPercent, healthPercent);

            if (nestCurrentHealth > 0f)
            {
                nestCurrentHealth = nestCurrentHealth - Time.deltaTime * 0.5f;

                if (nestCurrentHealth < 0f)
                {
                    nestCurrentHealth = 0f;
                    Debug.Log("Nest Lost");
                    nestLost = true;
                    //Destroy(gameObject);
                }
                Debug.Log(nestCurrentHealth);
            }
            
            //else
            //{
            //    Debug.Log("Nest Lost");
            //    nestLost = true;
            //    Destroy(gameObject);
            //}
        }
    }
}

