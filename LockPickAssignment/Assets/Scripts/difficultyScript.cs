using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class difficultyScript : MonoBehaviour {

    private Text difficulty;
    public SpriteRenderer background;

	void Start ()
    {
        difficulty = GetComponent<Text>();
        difficulty.text = "Difficulty: Unknown";
        background.color = Color.gray;
    }

    public void easy()
    {
        difficulty.text = "Difficulty: Easy";
        background.color = Color.green;
    }
    public void normal()
    {
        difficulty.text = "Difficulty: Normal";
        background.color = Color.yellow;
    }
    public void hard()
    {
        difficulty.text = "Difficulty: Hard";
        background.color = Color.red;
    }

}
