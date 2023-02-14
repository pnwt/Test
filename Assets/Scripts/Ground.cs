using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float _GroundStartSpeed = 10f;
    [SerializeField] private GameObject _PhaseOne;
    [SerializeField] private GameObject _PhaseTwo;
    private float _Multiplier;
    private bool _GameOver = false;
    public static int WaveCount = 0;
    public static int EndPhase = 2;
    private void Start()
    {
        Player.OnGameOver += () => _GameOver = true;
    }
    void Update()
    {
        if (_Multiplier <= 2) _Multiplier += Time.deltaTime / 20;
        if (transform.position.x < -40)
        {
            transform.position = new Vector3(37, transform.position.y, transform.position.z);
            WaveCount++;
        }
        if (!_GameOver && WaveCount < EndPhase) transform.Translate(-transform.right * _GroundStartSpeed * ((_Multiplier >= 1) ? _Multiplier : 1) * Time.deltaTime);
        else if(WaveCount >= EndPhase) 
        {
            Destroy(_PhaseOne);
            _PhaseTwo.SetActive(true);
        }
    }
}
