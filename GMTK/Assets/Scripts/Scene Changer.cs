using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger Instance;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        MainMenu,
        Tutorial,
        GameScreen,
        Victory,
        GameOver
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.GameScreen.ToString());
    }    

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }
}
