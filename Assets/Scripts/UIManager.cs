using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _GameOver;
    [SerializeField] private GameObject _TotalScore;
    [SerializeField] private TMP_Text _ScoreText;
    
    void Start()
    {
        Player.OnGameOver += OpenGameOver;
    }
    public void OpenGameOver()
    {
        _GameOver.SetActive(true);
    }
    public void TotalScore()
    {
        _TotalScore.SetActive(true);
        _TotalScore.GetComponent<TotalScore>().SetUp(_ScoreText.text);
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void OnDestroy()
    {
        Player.OnGameOver -= OpenGameOver;
    }
}
