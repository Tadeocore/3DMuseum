using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : MonoBehaviour
{
    public static int holdingWrench;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1) && PickUp.isHolding == 1)
        {
        	holdingWrench = 0;
        } 
    }

    void OnMouseOver()
    {
    	if(Input.GetMouseButtonDown(0))
        {
        	holdingWrench = 1;
        }

    }
}
