using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinCounter : MonoBehaviour {

    private Text winCounter;
    private int amount = 3;
    public MessageScript message;

	void Start ()
    {
        winCounter = GetComponent<Text>();
        winCounter.text = "Locks left: " + amount;
	}
	
    public void UpdateWin()
    {
        amount--;
        winCounter.text = "Locks left: " + amount;
        if(amount <= 0)
        {
            message.YouWin();
        }
    }
}
