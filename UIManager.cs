using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _GameOver;
    void Start()
    {
        Player.OnGameOver += OpenGameOver;
    }
    public void OpenGameOver()
    {
        _GameOver.SetActive(true);
    }
}
