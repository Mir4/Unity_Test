using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Sphere;
    private Vector3 distanse;
    void Start()
    {
        distanse = transform.position - Sphere.transform.position;
    }

    void Update()
    {
        transform.position = Sphere.transform.position + distanse;
    }
}
