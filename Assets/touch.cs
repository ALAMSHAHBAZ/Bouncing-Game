using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touch : MonoBehaviour
{
	public Rigidbody rb;
	public float strength=500.0f;
	AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {    
        rb = GetComponent<Rigidbody>();
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

            if(Input.touchCount>0){

             rb.AddForce(Vector3.up*strength, ForceMode.Impulse);
             audioData.Play(1);	
            Debug.Log(Input.touchCount); 

            }
      
    }
}
