using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownPresenter : MonoBehaviour
{
    public TextPresenter textPresenter;

    [SerializeField] private Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(_ => { textPresenter.textModel.Text = "ドロップダウン操作された"; });
    }
}
