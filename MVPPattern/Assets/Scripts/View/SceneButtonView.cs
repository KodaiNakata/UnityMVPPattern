using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneButtonView : MonoBehaviour
{
    public ScenePresenter scenePresenter;

    [SerializeField] private Button button;

    [SerializeField] private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => { scenePresenter.sceneView.LoadScene(sceneName); });
    }
}
