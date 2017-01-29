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
        //if (collision.collider.tag == "Hand")
        //{
            spawner.enabled = true;
        //}
        
    }
}
