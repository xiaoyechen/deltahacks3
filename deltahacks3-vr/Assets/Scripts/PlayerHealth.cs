using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    bool damaged;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void GotHit()
    {
        damaged = true;
    }
}
