using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SongButton : MonoBehaviour
{
    public void Hover()
    {
        GetComponent<RectTransform>().DOSizeDelta(new Vector2(800f, 148f), 0.7f).SetEase(Ease.InOutExpo);
    }

    public void Exit()
    {
        GetComponent<RectTransform>().DOSizeDelta(new Vector2(700f, 148f), 0.7f).SetEase(Ease.InOutExpo);
    }
}
