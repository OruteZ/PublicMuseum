using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLinear : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private Vector3 axis = Vector3.up;

    void Update()
    {
        // 매 프레임 회전
        transform.Rotate(axis, speed * Time.deltaTime, Space.World);
    }
}
