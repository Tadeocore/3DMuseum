using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOC : MonoBehaviour
{
    public GameObject CarPart1;
     public GameObject CarPart2;
      public GameObject CarPart3;
       public GameObject CarPart4;
        public GameObject CarPart5;
         public GameObject CarPart6;
          public GameObject CarPart7;
           public GameObject CarPart8;
            public GameObject CarPart9;

    // Start is called before the first frame update
    void Start()
    {
    	CarPart1.GetComponent<Rigidbody>().useGravity = false;
    	CarPart2.GetComponent<Rigidbody>().useGravity = false;
    	CarPart3.GetComponent<Rigidbody>().useGravity = false;
    	CarPart4.GetComponent<Rigidbody>().useGravity = false;
    	CarPart5.GetComponent<Rigidbody>().useGravity = false;
    	CarPart6.GetComponent<Rigidbody>().useGravity = false;
    	CarPart7.GetComponent<Rigidbody>().useGravity = false;
    	CarPart8.GetComponent<Rigidbody>().useGravity = false;
    	CarPart9.GetComponent<Rigidbody>().useGravity = false;
    	CarPart1.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart2.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart3.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart4.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart5.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart6.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart7.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart8.GetComponent<Rigidbody>().isKinematic = true;
    	CarPart9.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
