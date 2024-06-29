using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorControl : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    
    // Variables para controlar el estado de la puerta
    private bool isDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Abre la puerta si está cerrada
            if (!isDoorOpen)
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
                isDoorOpen = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Cierra la puerta si está abierta
            if (isDoorOpen)
            {
                myDoor.Play("DoorClose", 0, 0.0f);
                isDoorOpen = false;
            }
        }
    }
}
