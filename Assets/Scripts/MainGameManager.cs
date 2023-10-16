using System;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    public static MainGameManager Instance { get; private set; }

    public event EventHandler OnGameOver;

    [HideInInspector] public bool isGamePlaying = true;
    [SerializeField] float totalPlayTime = 0;

    private float playedTimer = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (isGamePlaying)
            playedTimer += Time.deltaTime;

        if (playedTimer >= totalPlayTime)
        {
            isGamePlaying = false;
            OnGameOver?.Invoke(this, EventArgs.Empty);
        }
    }

    public float GetPlayedTimer() => playedTimer;
    public float GetTotalPlayTime() => totalPlayTime;
}
