using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
      transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
      float rotation= 0;
      if (Input.GetKey(KeyCode.Q))
            rotation -= 1;
      if (Input.GetKey(KeyCode.E))
            rotation += 1;
      transform.Rotate(0, rotation, 0);

    }
}

