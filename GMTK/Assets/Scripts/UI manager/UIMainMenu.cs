using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Button _play, _tutorial,_quit;
    // Start is called before the first frame update
    void Start()
    {
        _play.onClick.AddListener(PlayGame);
        _tutorial.onClick.AddListener(Tutorial);
        _quit.onClick.AddListener(Exit);
    }

    private void PlayGame()
    {
        SceneChanger.Instance.LoadNewGame();
    }

    private void Tutorial()
    {
        SceneChanger.Instance.LoadNextScene();
    }
    private void Exit()
    {
        Application.Quit();
    }
}
