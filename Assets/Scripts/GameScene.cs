using UnityEngine;

public class GameScene : MonoBehaviour
{
    [SerializeField] Transform _PlayerSpawnpoint;
    private void Start()
    {
        GameObject prefab = Resources.Load($"Player/{GameController.Instance.Characters}") as GameObject;
        Instantiate(prefab, _PlayerSpawnpoint.position, Quaternion.identity);
    }
}
