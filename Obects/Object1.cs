using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer renderer;
    Color initColor;    
    Color[] colors;
    float transitionTime = 5f;
    
    void Start()
    {
        renderer = GetComponent<Renderer>();
        initColor = renderer.material.color;
        Debug.Log(initColor);

        colors = new Color[5];

        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        colors[3] = Color.red + Color.yellow;
        colors[4] = Color.yellow;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameVisible(){
        float transitionRate = 0;
        var new_color = colors[(Random.Range(0,4))];

        while(transitionRate < 1){
            
            renderer.material.SetColor("_Color", Color.Lerp(renderer.material.color, new_color, Time.deltaTime * transitionRate));
            transitionRate += Time.deltaTime / transitionTime;
                    
        }

    }   

    void OnBecameInvisible() {
        renderer.material.SetColor("_Color", initColor);
    }
}
