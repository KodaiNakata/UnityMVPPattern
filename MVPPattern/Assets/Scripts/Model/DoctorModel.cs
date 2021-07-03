using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorModel
{
    public bool raiseHand;

    public bool RaiseHand
    {
        get
        {
            return raiseHand;
        }
        private set
        {
            raiseHand = value;
        }
    }

    public DoctorModel()
    {
        raiseHand = false;
    }

    public void Control()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            raiseHand = true;
        }
    }
}
