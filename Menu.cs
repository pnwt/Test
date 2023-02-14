using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public GameObject credit;
    public void Play()
    {
        SceneManager.LoadScene("Character");
    }
    public void Option()
    {

    }
    public void Credit()
    {
        credit.SetActive(true);
    }
    public void Howtoplay()
    {

    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        credit.SetActive(false);
    }
}
