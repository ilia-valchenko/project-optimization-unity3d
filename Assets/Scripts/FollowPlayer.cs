using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 _offset = new Vector3(-1f, 1.4f, 0);

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    void LateUpdate()
    {
        transform.position = _player.transform.position + _offset;
        transform.rotation = _player.transform.rotation;
    }
}
