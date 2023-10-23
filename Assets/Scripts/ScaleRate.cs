using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScaleRate : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        float scaleRate = BallMovement.Instance.GetScaleRate();
        text.text += Mathf.Round(scaleRate).ToString();
    }
}
