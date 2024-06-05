using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class colision : MonoBehaviour
{
    // Referencia al Animator
    public Animator animator;

    // Nombre del trigger en el Animator
    public string triggerName = "TriggerAnimation";

    // M�todo llamado cuando comienza una colisi�n
    private void OnCollisionEnter(Collision collision)
    {
        // Comprueba si el objeto con el que ha colisionado tiene un tag espec�fico (opcional)
        if (collision.gameObject.CompareTag("OtherObject"))
        {
            // Activa el trigger en el Animator
            animator.SetTrigger(triggerName);
        }
    }

    // M�todo llamado cuando un collider entra en el trigger (en caso de usar triggers en lugar de colisiones)
    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que ha entrado en el trigger tiene un tag espec�fico (opcional)
        if (other.CompareTag("OtherObject"))
        {
            // Activa el trigger en el Animator
            animator.SetTrigger(triggerName);
        }
    }

   
}


