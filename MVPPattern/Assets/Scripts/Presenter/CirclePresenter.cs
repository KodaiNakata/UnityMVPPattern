using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePresenter : MonoBehaviour
{
    public CircleModel circleModel = new CircleModel();

    public CircleView circleView;

    // Start is called before the first frame update
    void Start()
    {
        circleView = GetComponent<CircleView>();
    }

    // Update is called once per frame
    void Update()
    {
        circleModel.Control();
        circleView.SetPosition(circleModel.position);
    }
}
