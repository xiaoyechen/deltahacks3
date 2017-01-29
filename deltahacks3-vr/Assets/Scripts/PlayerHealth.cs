using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    public int health;
    public Text healthText;
    bool damaged;
    // Use this for initialization
    void Start () {
        healthText.text = "Health: 0";
	}
	
	// Update is called once per frame
	void Update () {
	    if (damaged)
        {
            damageImage.color = flashColour;
            health--;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
        healthText.text = "Health: " + health;

        if (health <= 0)
            SceneManager.LoadScene(0);

    }

    public void GotHit()
    {
        damaged = true;
    }
}
