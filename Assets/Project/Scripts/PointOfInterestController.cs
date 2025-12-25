using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointOfInterestController : MonoBehaviour
{
    [SerializeField] private Button closeBtn;
    [SerializeField] private TextMeshProUGUI titleMessage;
    [SerializeField] private TextMeshProUGUI infoMessage;
    [SerializeField] private GameObject panel;
    [SerializeField] private InfoDetialSO infoDetialSO;

    void Start()
    {
        ProtofolioLoading(infoDetialSO);
    }

    public void ProtofolioLoading(InfoDetialSO _infoDetialSO)
    {
        panel.SetActive(true);
        titleMessage.text = _infoDetialSO.Title;
        infoMessage.text = _infoDetialSO.Info.Replace("\\n", "\n");
    }

    void OnEnable()
    {
        closeBtn.onClick.AddListener(CloseButtonClicked);
    }
    void OnDisable()
    {
        closeBtn.onClick.RemoveAllListeners();
    }

    private void CloseButtonClicked()
    {
        panel.SetActive(false);
    }
}
