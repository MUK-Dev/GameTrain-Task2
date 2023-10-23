using System;
using TMPro;
using UnityEngine;

public class Stars : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI starsCount;

    private void Start()
    {
        ScoreManager.Instance.OnScoreChange += ScoreManager_OnScoreChange;
    }

    private void ScoreManager_OnScoreChange(object sender, ScoreManager.OnScoreChangeEventArgs e)
    {
        starsCount.text = Mathf.Ceil(e.score / 3).ToString();
    }
}
