using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager : MonoBehaviour
{
    public Joint0_Script Joint0;
    public Joint1_Script Joint1;
    public Joint2_Script Joint2;
    public Joint3_Script Joint3;
    public Joint4_Script Joint4;
    public Joint5_Script Joint5;

    public GameObject joint0;
    public GameObject joint1;
    public GameObject joint2;
    public GameObject joint3;
    public GameObject joint4;
    public GameObject joint5;

    public GameObject[] Joints;

    public float[] Angles = new float[6];
    
    /**/
    public Vector3 ForwardKinematics (float [] angles)
    {
        Vector3 prevPoint = Joint0.transform.position;
        Quaternion rotation = Quaternion.identity;
        rotation *= Quaternion.AngleAxis(angles[0], Joint0.Axis);
        Vector3 nextPoint = prevPoint + rotation * Joint0.StartOffset;
        prevPoint = nextPoint;

        prevPoint = Joint1.transform.position;
        rotation *= Quaternion.AngleAxis(angles[1], Joint1.Axis);
        nextPoint = prevPoint + rotation * Joint1.StartOffset;
        prevPoint = nextPoint;

        prevPoint = Joint2.transform.position;
        rotation *= Quaternion.AngleAxis(angles[2], Joint2.Axis);
        nextPoint = prevPoint + rotation * Joint2.StartOffset;
        prevPoint = nextPoint;

        prevPoint = Joint3.transform.position;
        rotation *= Quaternion.AngleAxis(angles[3], Joint3.Axis);
        nextPoint = prevPoint + rotation * Joint3.StartOffset;
        prevPoint = nextPoint;

        prevPoint = Joint4.transform.position;
        rotation *= Quaternion.AngleAxis(angles[4], Joint4.Axis);
        nextPoint = prevPoint + rotation * Joint4.StartOffset;
        prevPoint = nextPoint;

        prevPoint = Joint5.transform.position;
        rotation *= Quaternion.AngleAxis(angles[5], Joint5.Axis);
        nextPoint = prevPoint + rotation * Joint5.StartOffset;
        prevPoint = nextPoint;

        return nextPoint; 
    } 
    
    public float DistanceFromTarget(Vector3 target, float[] angles)
    {
        Vector3 point = ForwardKinematics(angles);
        return Vector3.Distance(point, target);
    }

    void Start()
    {
        //        Joint0.Axis = Transform.axis.up;
        Joint0 = joint0.GetComponent<Joint0_Script>();
        Joint1 = joint1.GetComponent<Joint1_Script>();
        Joint2 = joint2.GetComponent<Joint2_Script>();
        Joint3 = joint3.GetComponent<Joint3_Script>();
        Joint4 = joint4.GetComponent<Joint4_Script>();
        Joint5 = joint5.GetComponent<Joint5_Script>();


        Joints = new GameObject[6];
        // Joints = {joint0, joint1, joint2, joint3, joint4, joint5};
        //Joints[0] = joint0;
        //Joints[1] = joint1;
        //Joints[2] = joint2;
        //Joints[3] = joint3;
        //Joints[4] = joint4;
        //Joints[5] = joint5;
        


    }

    // Update is called once per frame
    void Update()
    {
        Angles[0] = Joint0.Rotation;
        Angles[1] = Joint1.Rotation;
        Angles[2] = Joint2.Rotation;
        Angles[3] = Joint3.Rotation;
        Angles[4] = Joint4.Rotation;
        Angles[5] = Joint5.Rotation;

        //Angles = {Joint0.Rotation, Joint1.Rotation, Joint2.Rotation, Joint3.Rotation, Joint4.Rotation, Joint5.Rotation};

        Debug.Log(ForwardKinematics(Angles));

    }
}
