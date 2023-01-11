using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    public Camera cam;
    private Vector3 direction;
    void FixedUpdate()
    {
        if (Input.GetMouseButton(1)) {
            direction = cam.ScreenToWorldPoint(Input.mousePosition);
            direction.z = -1;
            cam.transform.position = direction;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
            cam.orthographicSize--; 
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            cam.orthographicSize++;
        }
    }
}
