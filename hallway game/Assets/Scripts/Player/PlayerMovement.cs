using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioClip shoutingClip;
    public float speedDampTime = 0.01f;
    public float sensitivityX = 1.0f;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    public bool hasKey;

    private Animator anim;
    private HashIDs hash;


    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        hasKey = false;
    }

    void Awake()
    {
        anim = GetComponent <Animator> ();
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();

        anim.SetLayerWeight(1, 1f);
    }

    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        bool sneak = Input.GetButton("Sneak");
        
        Rotating(h);
        MovementManager(v, sneak);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
        anim.SetBool(hash.jumpingBool, false);
    }

    void Update()
    {
        bool shout = Input.GetButtonDown("Attract");
        anim.SetBool(hash.shoutingBool, shout);
        AudioManagment(shout);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Rigidbody ourBody = this.GetComponent<Rigidbody>();
            ourBody.AddForce(jump * jumpForce, ForceMode.Impulse);
            anim.SetBool(hash.jumpingBool, true);
            isGrounded = false;
        }
    }

    void MovementManager (float vertical, bool sneaking)
    {
        anim.SetBool(hash.sneakingBool, sneaking);
      
        if (vertical > 0)
        {
            anim.SetFloat (hash.speedFloat, 1.4f, speedDampTime, Time.deltaTime);
        }
        else
        {
            anim.SetFloat(hash.speedFloat, 0);
        }
    }

    void Rotating (float hInput)
    {
        Rigidbody ourBody = this.GetComponent<Rigidbody>();

        if (hInput !=0)
        {
            Quaternion deltaRotation = Quaternion.Euler(0f, hInput * sensitivityX, 0f);
            ourBody.MoveRotation(ourBody.rotation * deltaRotation);
            anim.SetBool (hash.rotateBool, true);
        }
    }

    void AudioManagment (bool shout)
    {
        if (anim.GetCurrentAnimatorStateInfo (0).IsName("Walk"))
        {
            if(!GetComponent<AudioSource> ().isPlaying)
            {
                GetComponent<AudioSource> ().pitch = 0.50f;
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
        if (shout)
        {
            AudioSource.PlayClipAtPoint(shoutingClip, transform.position);
        }
    }

}
