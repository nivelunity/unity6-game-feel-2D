using System;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    [SerializeField] private float _velocidad = 10f;
    
    private Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidBody.linearVelocity = _rigidBody.linearVelocity * _velocidad;
    }


}
