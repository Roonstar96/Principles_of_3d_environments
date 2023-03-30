using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{ 
    public Camera triggeredCam;
    public Camera liveCam;

    private void Awake()
    {
        liveCam = Camera.allCameras[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Collider PlayerCollider = Player.GetComponent<Collider>();

        if (other.gameObject.tag == "Player")
        {
            triggeredCam.enabled = true;
            liveCam.enabled = false;

            triggeredCam.GetComponent<AudioListener>().enabled = true;
            Player.GetComponent<AudioListener>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Collider PlayerCollider = Player.GetComponent<Collider>();

        if (other.gameObject.tag == "Player")
        {
            triggeredCam.enabled = false;
            liveCam.enabled = true;

            triggeredCam.GetComponent<AudioListener>().enabled = false;
            Player.GetComponent<AudioListener>().enabled = true;
        }
    }

}


