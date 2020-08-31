using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessChildaGameObject : MonoBehaviour
{
    public GameObject parentCube;
    private float rotationNumber = 50f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationNumber * Time.deltaTime);
        transform.GetChild(0).Rotate(Vector3.left, rotationNumber * Time.deltaTime);
        transform.GetChild(1).Rotate(Vector3.right, rotationNumber * Time.deltaTime);
        transform.GetChild(2).Rotate(Vector3.up, rotationNumber * Time.deltaTime);
        transform.GetChild(3).Rotate(Vector3.left, rotationNumber * Time.deltaTime);
        transform.GetChild(4).Rotate(Vector3.right, rotationNumber * Time.deltaTime);
    }
}
