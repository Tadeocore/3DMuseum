using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    public static int isHolding = 0;
    public static int holdingWrench;
    public float HoldTimer = 0;   

    void OnMouseOver()
    {
    	if(Input.GetMouseButtonDown(0))
    	{
    	if(isHolding == 0 && HoldTimer > 2)
    	{
            this.transform.position = theDest.position;
    		this.transform.parent = GameObject.Find("PickUp").transform;
    		GetComponent<BoxCollider>().enabled = false;
    		GetComponent<Rigidbody>().useGravity = false;
    		HoldTimer = 0;
    		isHolding = 1;
    	}
    	}	
    }
    


    void Update()
    {
    	HoldTimer = HoldTimer + 1;

    	if(Input.GetMouseButtonDown(1))
    	{
    	if(isHolding == 1 && HoldTimer > 2)
    	{
            this.transform.parent = null;
    		GetComponent<Rigidbody>().useGravity = true;
    		GetComponent<BoxCollider>().enabled = true;
    		HoldTimer = 0;
    		isHolding = 0;
    	}
    	}
    }	
}
