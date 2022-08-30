using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object4 : MonoBehaviour
{

    private ParticleSystem ps;
    private GameObject particle_object;
    void Start()
    {
        particle_object = transform.GetChild(0).gameObject;
        ps = particle_object.GetComponent<ParticleSystem>();
    }

    void Update()
    {
    }

    void OnBecameVisible()
    {
        ps.Play();
    }

    void OnBecameInvisible()
    {
        ps.Stop();
    }
}
