using TMPro;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private int _Score;
    private float _Time;
    private bool isDead = false;
    [SerializeField] private TMP_Text _ScoreText;

    private void Start()
    {
        Player.OnGameOver += SetIsDeadTrue;
    }
    void Update()
    {
        if (!isDead)
        {
            _Time += Time.deltaTime;
            _Score += (int)(_Time * 1.25f);
            _ScoreText.text = _Score.ToString();
        }
    }
    private void SetIsDeadTrue()
    {
        isDead = true;
    }
    private void OnDestroy()
    {
        Player.OnGameOver -= SetIsDeadTrue;
    }
}
