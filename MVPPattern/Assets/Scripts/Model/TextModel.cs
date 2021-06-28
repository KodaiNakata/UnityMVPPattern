using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TextModel
{
    public UnityAction<string> OnClicked;

    public UnityAction<string> OnValueChanged;

    string text;

    public string Text
    {
        get { return text; }
        set
        {
            if (text != value)
            {
                text = value;
                if (OnClicked != null)
                {
                    OnClicked.Invoke(text);
                }

                if (OnValueChanged != null)
                {
                    OnValueChanged.Invoke(text);
                }
            }
        }
    }
}
