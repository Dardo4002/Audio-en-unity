using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiocontroler : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Camera.main.transform.position,Vector3.up, 45 * Time.deltaTime);
    }
}
