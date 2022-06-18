using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by 149251970101-169-Ahmadien Hafizh Yusufi");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void CreditMenu()
    {
        SceneManager.LoadScene("Credit");
        Debug.Log("Ahmadien Hafizh Yusufi");
        Debug.Log("149251970101-169");
        Debug.Log("Github  : https://github.com/majime-ui?tab=repositories");
    }
}
