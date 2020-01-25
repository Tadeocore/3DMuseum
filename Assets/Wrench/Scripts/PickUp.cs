using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    public float isHolding = 0;
    public float HoldTimer = 0;
    
    void OnMouseDown()
    {
    	if(isHolding == 1 && HoldTimer > 50)
    	{
    		this.transform.parent = null;
    		GetComponent<Rigidbody>().useGravity = true;
    		GetComponent<BoxCollider>().enabled = true;
    		isHolding = 0;
    	}

    	if(isHolding == 0)
    	{
    		HoldTimer = 0;
    		GetComponent<BoxCollider>().enabled = false;
    		GetComponent<Rigidbody>().useGravity = false;
    		this.transform.position = theDest.position;
    		this.transform.parent = GameObject.Find("PickUp").transform;
    		isHolding = 1;
    	}
    }   

    void Update()
    {
    	HoldTimer = HoldTimer + 1;
    }	
}
