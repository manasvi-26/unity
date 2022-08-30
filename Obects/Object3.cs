using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3 : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem ps;
    private GameObject particle_object;
    Vector3 scale;

    void Start()
    {
        particle_object = transform.GetChild(0).gameObject;
        ps = particle_object.GetComponent<ParticleSystem>();
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(ps.time > 0){
            transform.localScale = new Vector3(0,0,0);
        }    
    }

    void OnBecameVisible(){
        
        ps.Play();
    
    }

    void OnBecameInvisible() {
        ps.Stop();
        transform.localScale  = new Vector3(3,3,3);
    }


}
