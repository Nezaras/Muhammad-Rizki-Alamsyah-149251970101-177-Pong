using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
        Debug.Log("Muhammad Rizki Alamsyah-149251970101-177");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Muhammad Rizki Alamsyah-149251970101-177");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
