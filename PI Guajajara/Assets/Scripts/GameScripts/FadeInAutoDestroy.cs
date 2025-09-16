using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInAutoDestroy : MonoBehaviour
{
    public Image fadeImage;       
    public float fadeDuration = 2f;

    void Start()
    { 
        Color c = fadeImage.color;
        c.a = 1f;
        fadeImage.color = c;
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float timer = 0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);

            Color c = fadeImage.color;
            c.a = alpha;
            fadeImage.color = c;

            yield return null;
        }

        // Garante que terminou totalmente transparente
        Color final = fadeImage.color;
        final.a = 0f;
        fadeImage.color = final;

        // Destroi o Canvas após o fade
        Destroy(gameObject);
    }
}
