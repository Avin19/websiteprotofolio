using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VignetteController : MonoBehaviour
{
    public Volume volume;

    private Vignette vignette;

    void Awake()
    {
        if (volume.profile.TryGet(out vignette))
        {
            vignette.intensity.overrideState = true;
        }
    }

    public void FadeIn(float duration)
    {
        StartCoroutine(FadeVignette(1f, 0f, duration));
    }

    public void FadeOut(float duration)
    {
        StartCoroutine(FadeVignette(0f, 1f, duration));
    }

    private System.Collections.IEnumerator FadeVignette(float start, float end, float duration)
    {
        float time = 0f;

        while (time < duration)
        {
            float t = time / duration;
            vignette.intensity.value = Mathf.Lerp(start, end, t);

            time += Time.deltaTime;
            yield return null;
        }

        vignette.intensity.value = end;
    }
}