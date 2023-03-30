using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Door").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            anim.SetBool("Key", true);
            Destroy(gameObject);
        }
    }
}
