using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndingScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Map1");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
