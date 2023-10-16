using System;
using UnityEngine;

public class GameOverText : MonoBehaviour
{
    private void Start()
    {
        MainGameManager.Instance.OnGameOver += MainGameManager_OnGameOver;
        gameObject.SetActive(false);
    }

    private void MainGameManager_OnGameOver(object sender, EventArgs e)
    {
        gameObject.SetActive(true);
    }
}
