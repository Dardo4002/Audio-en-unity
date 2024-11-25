using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiocanonball : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al componente AudioSource
    public AudioClip floor_sound;  // Sonido al chocar con una pared
    public AudioClip wall_sound; // Sonido al chocar con un enemigo

    private void OnCollisionEnter(Collision collision)
    {
        // Identificar el objeto con el que chocaste usando su Tag
        if (collision.gameObject.CompareTag("floor"))
        {
            PlaySound(floor_sound);
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            PlaySound(wall_sound);
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
