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
    [SerializeField] private VignetteController vc;

    [Header("Button")]
    [SerializeField] private Button playBtn;
    [SerializeField] private Button resumeBtn;

    [Header("GameComopenets")]
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject uI;


    void OnEnable()
    {
        playBtn.onClick.AddListener(() => PlayButtonClicked());
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
        vc.FadeIn(.5f);
        vc.FadeOut(.5f);
        vc.FadeIn(1.5f);
        Invoke(nameof(LoadingPage), 5f);
    }

    private void LoadingPage()
    {

        logoPanel.SetActive(false);
        vc.FadeIn(0.5f);
        vc.FadeOut(0.5f);
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
        vc.FadeIn(0.5f);
        landingPanel.SetActive(true);
    }
}
