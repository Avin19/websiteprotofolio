using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class LoadingPage : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI loadingText;
    [SerializeField] private Slider slider;
    private bool sliderStart;
    private float sValue = 0f;
    [SerializeField] private int loadingSpeed = 10;
    // Start is called before the first frame update
    public void LoadingStart()
    {
        slider.value = sValue;
        sliderStart = true;
        loadingText.text = "Loading ";
    }

    // Update is called once per frame
    void Update()
    {
        if (sliderStart)
        {
            sValue += Time.deltaTime * loadingSpeed;
            slider.value = sValue;
            if (sValue <= 30f)
            {
                loadingText.text = "Loading . ";
            }
            if (sValue <= 60f && sValue >= 30f)
            {
                loadingText.text = "Loading . . ";
            }
            if (sValue <= 90f && sValue >= 60f)
            {
                loadingText.text = "Loading . . .";
            }
            if (sValue >= 99f)
            {
                sliderStart = false;
                gameObject.SetActive(false);
            }
        }
    }
}
