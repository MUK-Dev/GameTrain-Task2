using UnityEngine;
using UnityEngine.UI;

public class RoundedTimer : MonoBehaviour
{
    [SerializeField] private Image timer;
    void Start()
    {
        timer.fillAmount = 1;
    }

    void Update()
    {
        float playedTime = MainGameManager.Instance.GetPlayedTimer();
        float totalPlayedTime = MainGameManager.Instance.GetTotalPlayTime();
        timer.fillAmount = playedTime / totalPlayedTime;
    }
}
