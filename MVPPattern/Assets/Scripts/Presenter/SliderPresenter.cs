using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPresenter : MonoBehaviour
{
    public TextPresenter textPresenter;

    [SerializeField] private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(_ => { textPresenter.textModel.Text = "ƒXƒ‰ƒCƒh‚³‚ê‚½"; });
    }
}
