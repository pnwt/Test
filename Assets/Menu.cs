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
        Debug.Log("play");
    }
    public void Option()
    {
        Debug.Log("option");
    }
    public void Credit()
    {
        credit.SetActive(true);
        Debug.Log("credit");
    }
    public void Howtoplay()
    {
        Debug.Log("how to play");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("exit");
    }
    public void Back()
    {
        credit.SetActive(false);
        Debug.Log("back");
    }
}
