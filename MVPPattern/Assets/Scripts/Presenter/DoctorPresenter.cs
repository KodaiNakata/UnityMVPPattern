using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorPresenter : MonoBehaviour
{
    public DoctorModel doctorModel = new DoctorModel();

    public DoctorView doctorView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        doctorModel.Control();
        if (doctorModel.raiseHand)
        {
            doctorView.DoBanzai();
        }
    }
}
