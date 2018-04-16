using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject powerup;
    public float default_spawntime = 10f;
    public float spawnTime = 10f;
    public Transform[] spawnPoints;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (powerup, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    public void ResetTimer()
    {
        spawnTime = default_spawntime;
    }
}
