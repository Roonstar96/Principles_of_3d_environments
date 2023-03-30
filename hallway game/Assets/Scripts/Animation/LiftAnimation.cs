using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftAnimation : MonoBehaviour
{
    Animator liftAnim;

    void Start()
    {
        liftAnim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            liftAnim.SetBool("LiftUp", true);
        }
    }
}