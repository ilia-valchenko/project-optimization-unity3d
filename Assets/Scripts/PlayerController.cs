﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float spinSpeed = 200.0f;
    private float zRange = 4;
    public GameObject projectilePrefab;

    void FixedUpdate()
    {
        // Check for left and right bounds
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, spinSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //transform.Rotate(Vector3.up, spinSpeed * horizontalInput * Time.deltaTime, Space.Self);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // No longer necessary to Instantiate prefabs
            // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            // Get an object object from the pool
            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();

            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true); // activate it
                pooledProjectile.transform.position = transform.position; // position it at player
            }
        }
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    // Check for left and right bounds
    //    if (transform.position.z < -zRange)
    //    {
    //        transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
    //    }

    //    if (transform.position.z > zRange)
    //    {
    //        transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
    //    }

    //    var horizontalInput = Input.GetAxis("Horizontal");
    //    var verticalInput = Input.GetAxis("Vertical");

    //    transform.Rotate(Vector3.up, spinSpeed * horizontalInput * Time.deltaTime);
    //    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

    //    //transform.Rotate(Vector3.up, spinSpeed * horizontalInput * Time.deltaTime, Space.Self);
    //    //transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput, Space.World);

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        // No longer necessary to Instantiate prefabs
    //        // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

    //        // Get an object object from the pool
    //        GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();

    //        if (pooledProjectile != null)
    //        {
    //            pooledProjectile.SetActive(true); // activate it
    //            pooledProjectile.transform.position = transform.position; // position it at player
    //        }
    //    }
    //}
}
