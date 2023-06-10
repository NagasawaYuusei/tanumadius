using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float _bulletSize;
    float _bulletSpeed;
    float _bulletPower;
    Rigidbody2D _rb;

    public float BulletPower => _bulletPower;

    private void Awake()
    {
        _bulletSize = ParameterController.Instance._bulletSize;
        _bulletSpeed = ParameterController.Instance._bulletSpeed;
        _bulletPower = ParameterController.Instance._bulletPower;
    }

    void Start()
    {
        _bulletSize *= 0.5f;
        transform.localScale = new Vector3(_bulletSize, _bulletSize, _bulletSize);
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.velocity = Vector3.right * _bulletSpeed;
    }
}
