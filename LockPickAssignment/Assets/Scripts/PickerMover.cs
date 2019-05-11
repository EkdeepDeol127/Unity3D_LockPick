using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerMover : MonoBehaviour {

    public GameObject Picker;
    public GameObject Lock;
    private float TurnRadius;
    private float LockRadius;
    private bool check = false;
    public MessageScript message;
    public bool gameOver = false;
    public string holdTag;
    public float success;
    public int difficulty;

    void Start ()
    {
        difficulty = Random.Range(1, 4);
        success = Random.Range(1, 6);
        TurnRadius = 100f * Time.deltaTime;
        LockRadius = 100f * Time.deltaTime;
    }
	
	void Update ()
    {
        if(gameOver == false)
        {
            if (Input.anyKey)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    if (Picker.transform.rotation.eulerAngles.z > 270 || Picker.transform.rotation.eulerAngles.z < 90)// hard reset if too right
                    {
                        TurnRadius = 100f * Time.deltaTime;
                        Picker.transform.Rotate(0, 0, -TurnRadius);
                    }
                    else
                    {
                        Picker.transform.rotation = new Quaternion(0, 0, 0, 0);
                    }
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    if (Picker.transform.rotation.eulerAngles.z < 90 || Picker.transform.rotation.eulerAngles.z > 270)// hard reset if too left
                    {
                        TurnRadius = 100f * Time.deltaTime;
                        Picker.transform.Rotate(0, 0, TurnRadius);                  
                    }
                    else
                    {
                        Picker.transform.rotation = new Quaternion(0, 0, 0, 0);
                    }
                }
                if (Input.GetKey(KeyCode.Space))
                {
                    if (Lock.transform.rotation.eulerAngles.z > 270 || Lock.transform.rotation.eulerAngles.z == 0)
                    {
                        LockRadius = 100f * Time.deltaTime;
                        Lock.transform.Rotate(0, 0, -LockRadius);
                    }
                    else
                    {
                        checkSuccess();
                    }
                }
            }
            else if (Lock.transform.rotation.eulerAngles.z != 0 && check == false)
            {
                if (Lock.transform.rotation.eulerAngles.z > 0 && Lock.transform.rotation.eulerAngles.z > 90)// hard reset if too Left
                {
                    LockRadius = 200f * Time.deltaTime;
                    Lock.transform.Rotate(0, 0, LockRadius);//reverse lock rot
                }
                else
                {
                    Lock.transform.rotation = new Quaternion(0, 0, 0, 0);
                }
            }
        }
    }

    private void checkSuccess()
    {
        check = true;
        if(success == 6)
        {
            success = 5;
        }
        if(holdTag.ToString() == success.ToString())
        {
            reset();
            message.breakLock();
            success = Random.Range(1, 6);
            difficulty = Random.Range(1, 4);
        }
        else
        {
            reset();
            message.WorngPick();
        }
    }

    public void reset()
    {
        check = false;
        Picker.transform.rotation = new Quaternion(0, 0, 0, 0);
        Lock.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}

