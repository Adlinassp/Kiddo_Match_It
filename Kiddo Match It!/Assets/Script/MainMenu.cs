using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void Game()
    {
        SceneManager.LoadScene("Game0");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Quit");
    }
}
