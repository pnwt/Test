using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    private int _Index;
    private int _LastIndex;
    private int _MaxChar;
    [SerializeField] private List<GameObject> _Characters;


    private void Start()
    {
        _Index = 0;
        _MaxChar = _Characters.Count - 1;
    }
    private void Update()
    {
        if (_LastIndex != _Index)
        {
            OnIndexChange();
            _LastIndex = _Index;
        }
    }
    public void Next()
    {
        if (_Index < _MaxChar)
        {
            _Index++;
        }
    }
    public void Previous()
    {
        if (_Index > 0)
        {
            _Index--;
        }
    }
    public void OnIndexChange()
    {
        Debug.Log(_Index);
        _Characters[_Index].gameObject.SetActive(true);
        _Characters[_LastIndex].gameObject.SetActive(false);
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
