using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePresenter : MonoBehaviour
{
    public TextPresenter textPresenter;

    [SerializeField] private Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle.onValueChanged.AddListener(_ => { textPresenter.textModel.Text = "チェックされた"; });
    }
}
