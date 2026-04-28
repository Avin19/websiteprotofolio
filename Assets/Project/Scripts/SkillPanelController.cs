using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using System;

public class SkillPanelController : MonoBehaviour
{
    [SerializeField] private Sprite programmingSprite, unitySprite, multipleplayerSprite, systemdesignSprite, toolSprite;

    [SerializeField] private int programminglevel, unityLevel, multipleplayerlevel, systemLevel, toolLevel;
    [SerializeField] private string programmingInfo, unityInfo, multiplayerInfo, systemInfo, toolInfo;
    [SerializeField] private string programmingDes, unityDes, multiplayerDes, systemDes, toolDes;

    [Header(" GameObject")]
    [SerializeField]
    private Image programmingbrtImage, unitybtnImage, multiplayerbtnImage, systembtnImage, toolbtnImage, displayImage;
    [SerializeField] private TextMeshProUGUI inforText, DescripText, levelText, nameText;
    [Header("Button")]
    [SerializeField] private Button proBtn, unityBtn, multipleBtn, systemBtn, toolBtn, closeBtn;


    void OnEnable()
    {
        proBtn?.onClick.AddListener(ProgrammingDisplay);
        unityBtn?.onClick.AddListener(UnityDisplay);
        multipleBtn?.onClick.AddListener(MultiplayerDisplay);
        systemBtn?.onClick.AddListener(SystemDisplay);
        toolBtn?.onClick.AddListener(ToolDisplay);
        closeBtn?.onClick.AddListener(CloseDisplay);
    }

    private void CloseDisplay()
    {
        gameObject.SetActive(false);
    }

    private void ToolDisplay()
    {
        displayImage.sprite = toolSprite;
        inforText.text = toolInfo;
        DescripText.text = toolDes;
        levelText.text = "LEVEL  " + toolLevel.ToString();
        nameText.text = "TOOL & PIPELINE";
    }

    private void SystemDisplay()
    {
        displayImage.sprite = systemdesignSprite;
        inforText.text = systemInfo;
        DescripText.text = systemDes;
        levelText.text = "LEVEL  " + systemLevel.ToString();
        nameText.text = "SYSTEM DESIGN";
    }

    private void MultiplayerDisplay()
    {
        displayImage.sprite = multipleplayerSprite;
        inforText.text = multiplayerInfo;
        DescripText.text = multiplayerDes;
        levelText.text = "LEVEL  " + multipleplayerlevel.ToString();
        nameText.text = "MULTIPLAYER";

    }

    private void UnityDisplay()
    {
        displayImage.sprite = unitySprite;
        inforText.text = unityInfo;
        DescripText.text = unityDes;
        levelText.text = "LEVEL  " + unityLevel.ToString();
        nameText.text = "UNITY ENGINE";

    }

    private void ProgrammingDisplay()
    {
        displayImage.sprite = programmingSprite;
        inforText.text = programmingInfo;
        DescripText.text = programmingDes;
        levelText.text = "LEVEL  " + programminglevel.ToString();
        nameText.text = "C# PROGRAMMING";

    }

    // Start is called before the first frame update
    void Start()
    {
        displayImage.sprite = programmingSprite;
        inforText.text = programmingInfo;
        DescripText.text = programmingDes;
        levelText.text = "LEVEL  " + programminglevel.ToString();
        nameText.text = "C# PROGRAMMING";

    }


}
