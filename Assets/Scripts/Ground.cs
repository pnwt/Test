using UnityEngine;

public class Ground : MonoBehaviour
{
    public static Ground Instance { get; private set; }
    [SerializeField] private float _GroundStartSpeed = 10f;
    [SerializeField] private GameObject _PhaseOne;
    [SerializeField] private GameObject _PhaseTwo;
    private float _Multiplier;
    private bool _GameOver = false;
    public int WaveCount = 0;
    public int EndPhase = 2;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
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
            Debug.Log($"Wave count = {WaveCount}/{EndPhase}");
        }
        if (_GameOver == false && WaveCount < EndPhase) transform.Translate(-transform.right * _GroundStartSpeed * ((_Multiplier >= 1) ? _Multiplier : 1) * Time.deltaTime);
        else if(WaveCount >= EndPhase) 
        {
            Debug.Log($"Wave count = {WaveCount}/{EndPhase}\nEndPhase");
            Destroy(_PhaseOne);
            _PhaseTwo.SetActive(true);
        }
    }
}
