using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransformer : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 50;
    public float RotationSpeed = 50;
    public float scaleSpeed = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("6"), UnityEngine.Input.GetAxis("Vertical")) / movementSpeed;
        transform.eulerAngles += new Vector3(Input.GetAxis("VerticalTurn"), Input.GetAxis("HorizontalTurn"), 0.0f) * RotationSpeed;
        transform.localScale += new Vector3(1, 1, 1) * Input.GetAxis("5") / scaleSpeed;
    }
       
}
