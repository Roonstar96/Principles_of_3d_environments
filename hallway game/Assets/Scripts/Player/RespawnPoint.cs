using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    private Animator anim;
    private HashIDs hash;

    void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
