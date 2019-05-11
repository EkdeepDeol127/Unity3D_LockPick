using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageScript : MonoBehaviour {

    private Text message;
    private float timer = 0;
    public LivesText life;
    public WinCounter locksLeft;
    public PickerMover lockPicker;

    void Start ()
    {
        message = this.GetComponent<Text>();
        message.text = "Pick the Lock";
    }

    public void breakLock()
    {
        message.text = "You broke through one lock";
        locksLeft.UpdateWin();
    }

    public void OutofScans()
    {
        message.text = "Your out of Scans";
    }

    public void YouWin()
    {
        message.text = "You Won!";
        lockPicker.gameOver = true;
    }

    public void YouLose()
    {
        message.text = "You Lose!";
        lockPicker.gameOver = true;
    }

    public void WorngPick()
    {
        message.text = "Your pick broke";
        life.updateLives();
    }

    public void about10()
    {
        message.text = "Sweet spot is about 10%";
    }
    public void about25()
    {
        message.text = "Sweet spot is about 25%";
    }
    public void about50()
    {
        message.text = "Sweet spot is about 50%";
    }
    public void about75()
    {
        message.text = "Sweet spot is about 75%";
    }
    public void about100()
    {
        message.text = "Sweet spot is about 90%";
    }

    public void greaterScans()
    {
        message.text = "Scans say greater then 50%";
    }

    public void lesserScans()
    {
        message.text = "Scans say less than then 50%";
    }

    public void lessgreatScans()
    {
        message.text = "Scans say neither left or right...";
    }

    public void messedUpScans()
    {
        message.text = "Scans can't make sence of this...";
    }
}
