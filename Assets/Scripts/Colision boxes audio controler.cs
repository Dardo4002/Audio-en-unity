using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionboxesaudiocontroler : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al componente AudioSource
    public AudioClip floor_sound;
    public AudioClip cube_sound;


    private void OnCollisionEnter(Collision collision)
    {
        // Identificar el objeto con el que chocaste usando su Tag
        if (collision.gameObject.CompareTag("Terrain"))
        {
            PlaySound(floor_sound);
        }
        else if (collision.gameObject.CompareTag("cube"))
        {
            PlaySound(cube_sound);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.clip = clip;   // Asigna el clip al AudioSource
            audioSource.Play();       // Reproduce el sonido
        }
    }
}
