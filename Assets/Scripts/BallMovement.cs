using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public static BallMovement Instance { get; private set; }

    [SerializeField] private float rotateSpeed;
    [SerializeField] private float scaleRate = 1f;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (MainGameManager.Instance.isGamePlaying)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            //? Vertical movement
            transform.Rotate(Vector3.forward * Time.deltaTime * v * rotateSpeed);
            //? Horizontal movement
            transform.Rotate(Vector3.left * Time.deltaTime * h * rotateSpeed);

            float scaleFactor = -0.01f;

            if (Input.GetKey(KeyCode.Space))
                scaleFactor = 0.01f;

            scaleFactor *= scaleRate;

            Vector3 newScale = new Vector3(transform.localScale.x + scaleFactor, transform.localScale.y + scaleFactor, transform.localScale.z + scaleFactor);

            if (newScale.x <= 1 || newScale.y <= 1 || newScale.z <= 1) newScale = Vector3.one;
            if (newScale.x >= 10 || newScale.y >= 10 || newScale.z >= 10) newScale = Vector3.one * 10;

            transform.localScale = newScale;
        }
    }

    public float GetScaleRate() => scaleRate;
}
