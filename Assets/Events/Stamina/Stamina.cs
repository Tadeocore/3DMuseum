using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
	public Slider StaminaBar;
	public float timeOutTimer;
	public float canRun;
	public float ShiftPressed;
	public double DecimalValue1;
	public double DecimalValue2;
	public static int SprintP;
	public static int timeOut;

    // Start is called before the first frame update
    void Start()
    {
        StaminaBar.value = 100;
        canRun = 1;
        SprintP = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
        	ShiftPressed = 1;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
        	ShiftPressed = 0;
        }

        if(Input.GetKey(KeyCode.LeftShift) && timeOut == 0)
        {
        	DecimalValue1 += 0.3;
        }

        if(DecimalValue1 > 0.9)
        {
        	StaminaBar.value -=1;
        	DecimalValue1 = 0;
        }

        if(timeOut == 0)
        {
        	if(ShiftPressed == 0)
        	{
        		DecimalValue2 += 0.2;
        	}
        }

        if(DecimalValue2 > 0.9)
        {
        	StaminaBar.value += 1;
        	DecimalValue2 = 0;
        }

        if(StaminaBar.value == 0)
        {
        	timeOut = 1;
        	timeOutTimer += 1;
        }

        if(timeOutTimer > 500)
        {
        	timeOut = 0;
        }

    }
}
