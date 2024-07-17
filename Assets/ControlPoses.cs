using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ControlPoses : MonoBehaviour
{
    public TextMeshProUGUI textComponent;

    void Start()
    {
        IncrementLikes(); 
    }

    public void IncrementLikes()
    {
        if (textComponent != null)
        {
            int currentLikes;

            if (int.TryParse(textComponent.text, out currentLikes))
            {
                currentLikes += 1; 
                textComponent.text = currentLikes.ToString(); 
            }
            else
            {
                Debug.LogError("El texto actual no es un número");
            }
        }
        else
        {
            Debug.LogError("Componente TextMeshProUGUI no asignado");
        }
    }
}
