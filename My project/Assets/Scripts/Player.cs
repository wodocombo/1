using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
    }

    public  void Move(Vector3 direction)
    {
        _rigidbody.AddRelativeForce(direction * _speed);
    }
}
