using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object5 : MonoBehaviour
{
    private MeshFilter mesh_filter;
    private Mesh cur_mesh;
    private Mesh new_mesh;
    
    void Start()
    {
        mesh_filter = GetComponent<MeshFilter>();
        cur_mesh = mesh_filter.mesh;
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        new_mesh = Instantiate(obj.GetComponent<MeshFilter>().mesh);
        Destroy(obj);
        
    }

    void Update()
    {
    }

    void OnBecameVisible()
    {
        mesh_filter.mesh = new_mesh;
    }

    void OnBecameInvisible()
    {
        mesh_filter.mesh = cur_mesh;
    }
}
