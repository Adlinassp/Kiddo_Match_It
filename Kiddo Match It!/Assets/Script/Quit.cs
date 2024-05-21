using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Exit_Yes(){
        Application.Quit();
        Debug.Log("Aplikasi Telah Keluar");
    }

    public void Exit_No()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
