
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField] private float zRange = 20f;

    void Update()
    {
        if (transform.position.z <= -zRange || transform.position.z >= zRange)
            Destroy(gameObject);
    }
}
