using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour {

    private Text Timertext;
    private float timer = 60;
    public MessageScript message;
    public PickerMover lockPicker;

	void Start ()
    {
        Timertext = GetComponent<Text>();
        Timertext.text = "Time: " + timer.ToString("F2");
	}
	
	void Update ()
    {
        if(lockPicker.gameOver == false)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                Timertext.text = "Time: " + timer.ToString("F2");
            }
            else
            {
                Timertext.text = "Time: 0";
                message.YouLose();
            }
        }
	}
}
