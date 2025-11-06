using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightTrigger : MonoBehaviour
{
    [Header("Configurações")]
    [Tooltip("O Light 2D que vai ter sua intensidade alterada")]
    public Light2D luzAlvo;

    [Tooltip("Nova intensidade da luz quando o player entrar no trigger")]
    public float novaIntensidade = 0.5f;

    [Tooltip("Tag do objeto que ativa o trigger (ex: 'Player')")]
    public string tagDoPlayer = "Player";

    private float intensidadeOriginal;

    private void Start()
    {
        if (luzAlvo != null)
            intensidadeOriginal = luzAlvo.intensity;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagDoPlayer) && luzAlvo != null)
        {
            luzAlvo.intensity = novaIntensidade;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(tagDoPlayer) && luzAlvo != null)
        {
            luzAlvo.intensity = intensidadeOriginal;
        }
    }
}
