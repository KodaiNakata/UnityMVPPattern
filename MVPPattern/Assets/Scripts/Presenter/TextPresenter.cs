using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPresenter : MonoBehaviour
{
    [SerializeField] private Text text;

    public TextModel textModel = new TextModel();

    // Start is called before the first frame update
    void Start()
    {
        textModel.OnClicked = ( (hyojiMoji) => { text.text = hyojiMoji.ToString(); });
    }
}
