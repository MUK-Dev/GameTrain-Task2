using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    private TextMeshProUGUI timer;
    void Start()
    {
        timer = gameObject.GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        timer.text = Mathf.Round(MainGameManager.Instance.GetPlayedTimer()).ToString();
    }
}
