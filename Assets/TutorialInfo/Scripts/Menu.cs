using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu"); // Замените "Menu" на название вашей сцены главного меню
    }
}
