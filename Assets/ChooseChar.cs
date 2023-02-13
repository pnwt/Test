using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseChar : MonoBehaviour
{
    
    public void back() 
    {
        SceneManager.LoadScene("MenMenu");
    }
}
