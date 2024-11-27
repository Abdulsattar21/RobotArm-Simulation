using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Joint0_Script : MonoBehaviour
{
    public Vector3 Axis;// = (0.00,1.00,0.00); // Rotating around Y 
    public Vector3 StartOffset;
    public float _speed;
    public float Rotation;
    public float rotateSpeed = 50f;

    void Awake()
    {
        StartOffset = transform.localPosition;
        _speed = 10f;
    }

    // Start is called before the first frame update
    void Start()
    {
        Axis = new Vector3(0, 1, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        }
        Rotation = transform.localRotation.eulerAngles.y;

        
    }
}
