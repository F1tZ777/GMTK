using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuSceneChanger : MonoBehaviour
{
    [SerializeField] Button _back;
    // Start is called before the first frame update
    void Start()
    {
        _back.onClick.AddListener(Back);
    }

    private void Back()
    {
        SceneChanger.Instance.LoadMainMenu();
    }
}
