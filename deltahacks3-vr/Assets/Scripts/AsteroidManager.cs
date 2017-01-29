using UnityEngine;
using System.Collections;

public class AsteroidManager : MonoBehaviour {
    public Transform[] spawnPoints;
    public Rigidbody asteroid;
    public float spawnForce;
    public float spawnTime;

    private Transform camPos;
    Rigidbody asteroidInstance;

    // Use this for initialization
    void Start () {
        camPos = GameObject.FindGameObjectWithTag("MainCamera").transform;
        
        InvokeRepeating("SpawnAsteroid", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void SpawnAsteroid()
    {
        int spid = Random.Range(0, spawnPoints.Length);
        Transform spawnPos = spawnPoints[spid];
        spawnPos.position = new Vector3(spawnPos.position.x == 0 ? Random.Range(-10, 10) : spawnPos.position.x,
                                        Random.Range(-10, 10),
                                        spawnPos.position.z == 0 ? Random.Range(-10, 10) : spawnPos.position.z);
        asteroidInstance = Instantiate(asteroid, spawnPos.position, spawnPos.rotation) as Rigidbody;

        
        asteroidInstance.transform.LookAt(camPos);
        //asteroidInstance.velocity = spawnForce * (-transform.forward+transform.up);

        asteroidInstance.velocity = spawnForce * (camPos.position- spawnPos.position).normalized;
    }
}
