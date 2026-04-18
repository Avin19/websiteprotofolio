using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Panel")]
    [SerializeField] private GameObject logoPanel;
    [SerializeField] private GameObject loadingPanel;
    [SerializeField] private GameObject landingPanel;
    [SerializeField] private VignetteController vc;



    void Start()
    {
        logoPanel.SetActive(true);
        vc.FadeIn(.5f);
        vc.FadeOut(.5f);
        vc.FadeIn(1.5f);
        Invoke(nameof(LoadingPage), 3f);
    }

    private void LoadingPage()
    {

        logoPanel.SetActive(false);
        landingPanel.SetActive(true);
        vc.FadeIn(0.5f);
        vc.FadeOut(0.5f);
        loadingPanel.GetComponent<LoadingPage>().LoadingStart();
    }
    // Update is called once per frame
    void Update()
    {
        if (landingPanel.activeSelf)
        {
            StartCheckingForLoadingPage();
        }
    }

    private void StartCheckingForLoadingPage()
    {
        landingPanel.SetActive(true);
    }
}
