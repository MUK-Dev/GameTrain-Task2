using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject projectilePrefab;

    private float zBound = 15f;
    private float xBound = 15f;

    void Update()
    {
        Movement();
        ShootProjectile();
    }

    private void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, transform.position, transform.rotation);
    }

    private void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 position = transform.position;

        if (position.z <= 0)
        {
            transform.position = new Vector3(position.x, position.y, 0);
        }

        if (position.z >= zBound)
        {
            transform.position = new Vector3(position.x, position.y, zBound);
        }

        if (position.x <= -xBound)
        {
            transform.position = new Vector3(-xBound, position.y, position.z);
        }
        else if (position.x >= xBound)
        {
            transform.position = new Vector3(xBound, position.y, position.z);
        }

        transform.Translate(Vector3.right * h * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * v * Time.deltaTime * speed);
    }
}
