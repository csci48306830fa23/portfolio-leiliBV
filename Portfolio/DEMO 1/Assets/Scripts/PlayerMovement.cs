using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 3.0f;
    public float Jumpforced = 5.0f;
    AudioSource jumpsound;
    private Rigidbody playerRb;
       
    private float horizontalinput;
    private float forwardinput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        jumpsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //get plyer input
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalinput);

        // let the palyer jump
        if (Input.GetKeyDown(KeyCode.Space))
                    {
            playerRb.AddForce(Vector3.up * Jumpforced, ForceMode.Impulse);
            jumpsound.Play();
            
        }



    }
}