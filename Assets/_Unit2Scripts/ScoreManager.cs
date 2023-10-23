using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public event EventHandler<OnScoreChangeEventArgs> OnScoreChange;

    private void Awake()
    {
        Instance = this;
    }

    public class OnScoreChangeEventArgs : EventArgs
    {
        public int score;
    }

    private int score = 0;

    public void IncrementScore()
    {
        score++;
        OnScoreChange?.Invoke(this, new OnScoreChangeEventArgs { score = score });
    }
}
