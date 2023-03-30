using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    Animator doorAnim;

    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            doorAnim.SetBool("Open", true);
        }
    }
}