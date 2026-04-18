using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [Header("Panel")]
    [SerializeField] private GameObject logoPanel;
    [SerializeField] private GameObject loadingPanel;
    [SerializeField] private GameObject landingPanel;

    [Header("Button")]
    [SerializeField] private Button playBtn;
    [SerializeField] private Button resumeBtn;
    [SerializeField] private Button githubBtn;
    [SerializeField] private Button linkedinBtn;

    [SerializeField] private Button itchBtn;
    [SerializeField] private Button playStorebtn;
    // [SerializeField] private Button steamPagebtn;
    [Header("GameComopenets")]
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject uI;

    void OnEnable()
    {
        playBtn.onClick.AddListener(() => PlayButtonClicked());
        resumeBtn.onClick.AddListener(() => DownloadResume());
        githubBtn.onClick.AddListener(() => ShowGithub());
        linkedinBtn.onClick.AddListener(() => LinkedPage());
        itchBtn.onClick.AddListener(() => ItchShowButton());
        playStorebtn.onClick.AddListener(() => PlayStoreShow());
        // steamPagebtn.onClick.AddListener(() => SteamWorkPage());


    }
    void Osable()
    {
        playBtn.onClick.RemoveAllListeners();
        resumeBtn.onClick.RemoveAllListeners();
        githubBtn.onClick.RemoveAllListeners();
        linkedinBtn.onClick.RemoveAllListeners();
        itchBtn.onClick.RemoveAllListeners();
        playStorebtn.onClick.RemoveAllListeners();
        //  steamPagebtn.onClick.RemoveAllListeners();
    }

    private void SteamWorkPage()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=7935807604689671060");
    }

    private void PlayStoreShow()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=7935807604689671060");

    }

    private void ItchShowButton()
    {
        Application.OpenURL("https://avinashyadav.itch.io/");
    }

    private void LinkedPage()
    {
        Application.OpenURL("https://www.linkedin.com/in/avinash-y-43057196/");

    }

    private void ShowGithub()
    {
        Application.OpenURL("https://github.com/Avin19");

    }

    private void DownloadResume()
    {
        Application.OpenURL("https://drive.google.com/file/d/1st2yBYvXjuUaU8ZFi4HlJ9Dkzh3rKfKO/view?usp=sharing");

    }


    private void PlayButtonClicked()
    {
        landingPanel.SetActive(false);
        player.SetActive(true);
        uI.SetActive(true);
    }

    void Start()
    {
        logoPanel.SetActive(true);
        // vc.FadeIn(.5f);
        // vc.FadeOut(.5f);
        // vc.FadeIn(1.5f);
        Invoke(nameof(LoadingPage), 1.5f);
    }

    private void LoadingPage()
    {

        logoPanel.SetActive(false);
        // vc.FadeIn(0.5f);
        // vc.FadeOut(0.5f);
        loadingPanel.SetActive(true);
        loadingPanel.GetComponent<LoadingPage>().LoadingStart();
    }
    // Update is called once per frame
    void Update()
    {
        if (loadingPanel.activeSelf)
        {
            StartCheckingForLoadingPage();
        }
    }

    private void StartCheckingForLoadingPage()
    {
        // vc.FadeIn(0.5f);
        landingPanel.SetActive(true);
    }
}
