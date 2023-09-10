using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private readonly Vector3 _offset = new Vector3(5.0f, 3.3f, 0);

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position + _offset;
    }
}
