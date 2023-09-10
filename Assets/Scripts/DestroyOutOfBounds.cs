using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float XBound = 15.0f;
    private const float YBound = -5.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > XBound || transform.position.y < YBound)
        {
            // Instead of destroying the projectile when it leaves the screen
            Destroy(gameObject);

            //// Just deactivate it
            //gameObject.SetActive(false);

        }
        //else if (transform.position.x > XBound)
        //{
        //    Debug.Log("Game Over!");
        //    Destroy(gameObject);
        //}
    }
}
