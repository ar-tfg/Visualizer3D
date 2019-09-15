using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlaneView : MonoBehaviour
{
    // Start is called before the first frame update
    bool visible = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(UnityEngine.Input.GetButtonDown("Fire2"))
        {
            foreach (MeshRenderer r in GetComponentsInChildren<MeshRenderer>())
                r.enabled = visible;
           
            visible = !visible;
        }
        
    }
}
