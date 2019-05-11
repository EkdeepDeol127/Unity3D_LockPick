using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColl : MonoBehaviour {

    public PickerMover pick;

    void OnTriggerEnter2D(Collider2D other)
    {
        pick.holdTag = this.tag.ToString();
    }
}
