using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float Speed;
    public bool Destroy;
    public float DestroyTime;

    public Vector3 vector;

    void Start()
    {
        if(Destroy)
            Destroy(gameObject, DestroyTime);
    }

    void Update()
    {
        transform.Translate(vector*Time.deltaTime*Speed);
    }
}
