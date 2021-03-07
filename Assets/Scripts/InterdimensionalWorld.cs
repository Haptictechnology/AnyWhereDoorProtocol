using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InterdimensionalWorld : MonoBehaviour
{
    public Material[] materials;

    void Start()
    {
        foreach (var mat in materials)
          {
              mat.SetInt("_StencilTest",(int)CompareFunction.Equal);
          }
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.name != "Main Camera")
        return;
     //outside of other world
        if(transform.position.z > other.transform.position.z)
        {
           Debug.Log("Outside of other world"); 
           foreach (var mat in materials)
          {
              mat.SetInt("_StencilTest",(int)CompareFunction.Equal);
          }
          //inside oher dimension
        }
        else
        {
            Debug.Log("Inside Other World");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest",(int)CompareFunction.NotEqual);
            
            }
        }

    }
    void OnDestroy()
    {
        foreach (var mat in materials)
          {
              mat.SetInt("_StencilTest",(int)CompareFunction.Equal);
          }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
