using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;

    void Update()
    {
        if (MainGameManager.Instance.isGamePlaying)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            //? Vertical movement
            transform.Rotate(Vector3.forward * Time.deltaTime * v * rotateSpeed);
            //? Horizontal movement
            transform.Rotate(Vector3.left * Time.deltaTime * h * rotateSpeed);

            float scaleFactor = 0.01f;

            if (Input.GetKey(KeyCode.Space))
                transform.localScale = new Vector3(transform.localScale.x + scaleFactor, transform.localScale.y + scaleFactor, transform.localScale.z + scaleFactor);
            else if (transform.localScale != Vector3.zero)
                transform.localScale = new Vector3(transform.localScale.x - scaleFactor, transform.localScale.y - scaleFactor, transform.localScale.z - scaleFactor);
        }
    }
}
