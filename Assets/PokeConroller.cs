using UnityEngine;

public class PokeController : MonoBehaviour
{
    public GameObject panel; // Referencia al panel que quieres mostrar/ocultar
    public AudioSource audioSource; // Referencia al componente AudioSource

    void Start()
    {
        HidePanel(); // Oculta el panel al inicio
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // A�ade un AudioSource si no hay ninguno
        }
    }

    // Llama a este m�todo para alternar la visibilidad del panel
    public void TogglePanel()
    {
        if (panel != null)
        {
            panel.SetActive(!panel.activeSelf); // Alternar el estado activo del panel
        }
    }

    // M�todo para mostrar el panel
    public void ShowPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    // M�todo para ocultar el panel
    public void HidePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

    // M�todo para alternar el estado del audio (reproducir/pausar)
    public void ToggleAudio()
    {
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause(); // Pausa el audio si est� reproduciendo
            }
            else
            {
                audioSource.Play(); // Reproduce el audio si est� pausado
            }
        }
    }
}
