using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaSonidoPosicional : MonoBehaviour
{
    AudioSource _audio;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Camera.main.transform.position, Vector3.up, 45 * Time.deltaTime);
    }
}
