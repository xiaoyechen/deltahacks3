using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int initialScore = 0;
    public Text scoreText;

    int currentScore;

	// Use this for initialization
	void Start () {
        currentScore = initialScore;
        scoreText.text = "SCORE: 0";
	}
	
    void Update()
    {
        scoreText.text = "SCORE: " + currentScore;
    }

	public void AddScore(int amount)
    {
        currentScore += amount;
    }
}
