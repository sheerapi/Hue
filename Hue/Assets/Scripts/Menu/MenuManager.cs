using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[AddComponentMenu("Hue/Managers/Menu Manager")]
public class MenuManager : MonoBehaviour
{
    public Image blur;
    
    [Header("Panels")]
    public RectTransform downloadPanel;
    public RectTransform changelogPanel;
    public RectTransform profilePanel;
    public RectTransform notificationsPanel;
    public RectTransform settingsPanel;
    public RectTransform settingsButtonsPanel;
    public RectTransform pluginsPanel;

    [Header("Screens")]
    public CanvasGroup homePage;
    public CanvasGroup selectPage;
    public CanvasGroup introPage;

    [Header("Buttons")]
    public RectTransform[] mainMenuButtons;
    public RectTransform backButton;
    public RectTransform pluginsButton;
    public RectTransform sortButton;
    public RectTransform backIconPlugins;

    [Header("Intro")]
    public Text title;
    public Text description;
    public Text warningText;
    public Text version;
    public Image logo;

    bool changelog;
    bool downloads;
    bool profile;
    bool settings;
    bool notifications;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Intro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Panel Animations
    public void OpenDownloadPanel()
    {
        blur.DOFade(0.7f, 0.7f).SetEase(Ease.InOutExpo);
        downloadPanel.DOAnchorPosY(0f, 0.7f).SetEase(Ease.InOutExpo);
        blur.raycastTarget = true;
        downloads = true;
    }

    public void CloseDownloadPanel()
    {
        if (downloads == true)
        {
            blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
            downloadPanel.DOAnchorPosY(-1590f, 0.7f).SetEase(Ease.InOutExpo);
            blur.raycastTarget = false;
        }
    }

    public void OpenChangelogPanel()
    {
        blur.DOFade(0.7f, 0.7f).SetEase(Ease.InOutExpo);
        changelogPanel.DOAnchorPosY(0f, 0.7f).SetEase(Ease.InOutExpo);
        blur.raycastTarget = true;
        changelog = true;
    }

    public void CloseChangelogPanel()
    {
        if (changelog == true)
        {
            blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
            changelogPanel.DOAnchorPosY(-1590f, 0.7f).SetEase(Ease.InOutExpo);
            blur.raycastTarget = false;
        }
    }

    public void OpenProfilePanel()
    {
        blur.DOFade(0.7f, 0.7f).SetEase(Ease.InOutExpo);
        profilePanel.DOScale(1f, 0.7f).SetEase(Ease.InOutExpo);
        blur.raycastTarget = true;
        profile = true;
    }

    public void CloseProfilePanel()
    {
        if (profile == true)
        {
            blur.raycastTarget = false;
            blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
            profilePanel.DOScale(0f, 0.7f).SetEase(Ease.InOutExpo);
        }
    }

    public void OpenNotificationsPanel()
    {
        blur.DOFade(0.7f, 0.7f).SetEase(Ease.InOutExpo);
        notificationsPanel.DOAnchorPosX(-290f, 0.7f).SetEase(Ease.InOutExpo);
        blur.raycastTarget = true;
        notifications = true;
    }

    public void CloseNotificationsPanel()
    {
        if (notifications == true)
        {
            blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
            notificationsPanel.DOAnchorPosX(290f, 0.7f).SetEase(Ease.InOutExpo);
            blur.raycastTarget = false;
            notifications = false;
        }
    }

    public void OpenSettingsPanel()
    {
        blur.DOFade(0.7f, 0.7f).SetEase(Ease.InOutExpo);
        settingsPanel.DOAnchorPosX(390, 0.7f).SetEase(Ease.InOutExpo);
        settingsButtonsPanel.DOAnchorPosX(50f, 0.7f).SetEase(Ease.InOutExpo);
        blur.raycastTarget = true;
        settings = true;
    }

    public void CloseSettingsPanel()
    {
        if (settings == true)
        {
            blur.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
            settingsPanel.DOAnchorPosX(-390, 0.7f).SetEase(Ease.InOutExpo);
            settingsButtonsPanel.DOAnchorPosX(-50f, 0.7f).SetEase(Ease.InOutExpo);
            blur.raycastTarget = false;
            settings = false;
        }
    }

    public void OpenPluginsPanel()
    {
        pluginsPanel.DOAnchorPosY(0f, 0.7f).SetEase(Ease.InOutExpo);
    }

    public void ClosePluginsPanel()
    {
        pluginsPanel.DOAnchorPosY(-1630f, 0.7f).SetEase(Ease.InOutExpo);
    }
    #endregion

    #region Screen Animations
    public void OpenPlayPage()
    {
        homePage.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        homePage.DOFade(1f, 0.7f).SetEase(Ease.InOutExpo);
        homePage.transform.DOScale(1f, 0.7f).SetEase(Ease.InOutExpo);
        selectPage.transform.DOScale(1.5f, 1f).SetEase(Ease.InOutExpo);
        selectPage.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
        selectPage.blocksRaycasts = false;
        homePage.blocksRaycasts = true;
    }

    public void OpenSelectPage()
    {
        selectPage.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        selectPage.DOFade(1f, 0.7f).SetEase(Ease.InOutExpo);
        selectPage.transform.DOScale(1f, 0.7f).SetEase(Ease.InOutExpo);
        homePage.transform.DOScale(1.5f, 1f).SetEase(Ease.InOutExpo);
        homePage.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);
        selectPage.blocksRaycasts = true;
        homePage.blocksRaycasts = false;
    }
    #endregion

    #region Select Song Buttons
    public void BackHover()
    {
        backButton.DOSizeDelta(new Vector2(225f, 74f), 0.7f).SetEase(Ease.OutBounce);
    }

    public void BackExit()
    {
        backButton.DOSizeDelta(new Vector2(155f, 74f), 1.5f).SetEase(Ease.OutExpo);
    }

    public void BackPluginsHover()
    {
        backIconPlugins.DOAnchorPosX(-315f, 0.7f).SetEase(Ease.InOutExpo);
    }

    public void BackPluginsExit()
    {
        backIconPlugins.DOAnchorPosX(-300f, 0.7f).SetEase(Ease.InOutExpo);
    }
    #endregion

    IEnumerator StartAnimation()
    {
        for (int i = 0; i < mainMenuButtons.Length; i++)
        {
            mainMenuButtons[i].localScale = Vector3.zero;
            mainMenuButtons[i].DOScale(1f, 0.7f).SetEase(Ease.InOutExpo);
            yield return new WaitForSeconds(0.15f);
        }
    }

    IEnumerator Intro()
    {
        introPage.alpha = 1f;
        yield return new WaitForSeconds(0.6f);
        introPage.transform.DOScale(0f, 1f).SetEase(Ease.InOutExpo);
        introPage.DOFade(0f, 0.7f).SetEase(Ease.InOutExpo);

        yield return new WaitForSeconds(0.8f);
        StartCoroutine(StartAnimation());
    }
}
