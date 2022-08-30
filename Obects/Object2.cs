using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 initPos;
    bool isInView;
    bool hasCollided;
    bool hasRb;

    void Start()
    {
        initPos = transform.position;
        hasCollided = false;
        isInView = false;
        hasRb = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isInView && !hasRb){
            gameObject.AddComponent<Rigidbody>();
            hasRb = true;
        }
        if(hasCollided && !isInView){
            Destroy(gameObject.GetComponent<Rigidbody>());
            transform.SetPositionAndRotation(initPos , Quaternion.Euler(0 , 0 , 0));
            hasCollided = false;
            hasRb = false;
        }
        Debug.Log(transform.position);
    }

    void OnBecameVisible()
    {
        isInView = true;
    }

    void OnBecameInvisible()
    {
        isInView = false;
    }

    void OnCollisionEnter(){
        
        hasCollided = true;
        hasRb = false;
    }
}
