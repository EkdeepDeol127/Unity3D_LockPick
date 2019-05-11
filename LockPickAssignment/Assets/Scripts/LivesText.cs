using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LivesText : MonoBehaviour {

    private Text lives;
    private int amount = 3;
    public MessageScript message;
    public PickerMover lockPicker;

    void Start ()
    {
        lives = this.GetComponent<Text>();
        lives.text = "Lives: " + amount;
	}

    public void updateLives()
    {
        amount--;
        lives.text = "Lives: " + amount;
        lockPicker.reset();
        if (amount <= 0)
        {
            message.YouLose();
        }
    }
}
