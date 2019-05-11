using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScaneBehavior : MonoBehaviour {

    public PickerMover lockPicker;
    public MessageScript message;
    public difficultyScript Difficulty;
    private Button scan;
    private int numScans = 3;

	void Start ()
    {
        scan = GetComponent<Button>();
        scan.onClick.AddListener(Scaning);
    }

    private void Scaning()
    {
        if(numScans > 0)
        {
            if(lockPicker.difficulty == 1)
            {
                Difficulty.easy();
                if (lockPicker.success == 1)
                {
                    message.about10();
                }
                else if (lockPicker.success == 2)
                {
                    message.about25();
                }
                else if (lockPicker.success == 3)
                {
                    message.about50();
                }
                else if (lockPicker.success == 4)
                {
                    message.about75();
                }
                else if (lockPicker.success == 5 || lockPicker.success == 6)
                {
                    message.about100();
                }
                numScans--;
            }
            else if(lockPicker.difficulty == 2)
            {
                Difficulty.normal();
                if (lockPicker.success > 3)
                {
                    message.greaterScans();
                }
                else if (lockPicker.success < 3)
                {
                    message.lesserScans();
                }
                else
                {
                    message.lessgreatScans();
                }
                numScans--;
            }
            else
            {
                message.messedUpScans();
                Difficulty.hard();
                numScans--;
            }
        }
        else
        {
            message.OutofScans();
        }
    }
}
