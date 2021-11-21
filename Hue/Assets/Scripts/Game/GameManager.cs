using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hue.Game;
using DG.Tweening;

[AddComponentMenu("Hue/Managers/Game Manager")]
public class GameManager : MonoBehaviour
{
    [Header("Gameplay")]
    public SongData song;

    [Header("UI")]
    public CanvasGroup restPanel;
    public CanvasGroup pausePanel;
    public Image blur;

    [Header("Rest")]
    public RectTransform restBar;
    public Text timerText;

    int currentRestTime;
    bool paused;

    // Start is called before the first frame update
    void Start()
    {
        restPanel.DOFade(1f, 0.7f).SetEase(Ease.InOutExpo);
        restBar.DOSizeDelta(new Vector2(0f, restBar.sizeDelta.y), song.Rests[0].Duration).SetEase(Ease.Linear);
        currentRestTime = song.Rests[0].Duration;
        StartCoroutine(RestTimer(song.Rests[0]));
        blur.DOFade(0.4f, 0.7f).SetEase(Ease.InOutExpo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

            if (paused == true)
            {
                blur.DOFade(0.6f, 0.7f).SetEase(Ease.InOutExpo);
                pausePanel.DOFade(1f, 0.7f).SetEase(Ease.InOutExpo);
                pausePanel.GetComponent<RectTransform>().DOScale(1f, 0.9f).SetEase(Ease.InOutExpo);
            }
            else
            {
                blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
                pausePanel.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
                pausePanel.GetComponent<RectTransform>().DOScale(0f, 1.2f).SetEase(Ease.InOutExpo);
            }
        }
    }

    IEnumerator RestTimer(Rest currentRest)
    {
        timerText.text = currentRestTime.ToString();
        yield return new WaitForSeconds(1f);
        if (currentRestTime != 1)
        {
            currentRestTime--;
            StartCoroutine(RestTimer(currentRest));
        }
        else
        {
            restPanel.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
            restPanel.GetComponent<RectTransform>().DOScale(0f, 1.2f).SetEase(Ease.InOutExpo);
            blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
        }
    }
}
