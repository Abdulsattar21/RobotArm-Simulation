using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Joint4_Script : MonoBehaviour
{
    public Vector3 Axis;//= (1, 0, 0); //Rotating around X;
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
        Axis = new Vector3(1, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.left, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.left, -rotateSpeed * Time.deltaTime);
        }
        Rotation = transform.localRotation.eulerAngles.x;


    }
}
