using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPresenter : MonoBehaviour
{
    public TextPresenter textPresenter;

    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => { textPresenter.textModel.Text = "ƒNƒŠƒbƒN‚³‚ê‚½"; });
    }
}
