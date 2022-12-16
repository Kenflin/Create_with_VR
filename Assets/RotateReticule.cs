using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticule : MonoBehaviour
{
    [Range(0, 1)] public float sensitivity = 1.0f;

    [Tooltip("The max speed of the rotation")]

    public float speed = 10.0f;
    private Transform transformReticle;

    // Start is called before the first frame update
    void Start()
    {
        transformReticle = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transformReticle.Rotate(transformReticle.up, (sensitivity * speed) * Time.deltaTime);
    }
}
