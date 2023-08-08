using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPersonaje : MonoBehaviour
{
    
    public int vida;
    public string[] tag;
    
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.CompareTag("SubirVida") && other.CompareTag("Player")){
            other.GetComponent<PlayerController>().Vida(vida);            
            Destroy(gameObject);
        }

        if(gameObject.CompareTag("Enemigo") && other.CompareTag("Player")){
            other.GetComponent<PlayerController>().Vida(-vida);            
            Destroy(gameObject);
        }
    }

}
