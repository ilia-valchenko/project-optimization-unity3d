using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private const float Offset = 5.0f;

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position + new Vector3(Offset, 3.3f, 0);
    }
}
