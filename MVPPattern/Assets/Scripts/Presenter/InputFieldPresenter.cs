using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldPresenter : MonoBehaviour
{
    public TextPresenter textPresenter;

    [SerializeField] private InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField.onValueChanged.AddListener(_ => { textPresenter.textModel.Text = "�C���v�b�g�t�B�[���h���͂��ꂽ"; });
    }
}
