using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
    public AsteroidManager spawner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision collision)
    {
        spawner.enabled = true;
    }
}
