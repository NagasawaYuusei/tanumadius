using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D _rb;
    float _playerSpeed;
    PlayerController _controller;

    void Awake()
    {
        _playerSpeed = ParameterController.Instance._playerSpeed;
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _controller = GetComponent<PlayerController>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (_controller.State != PlayerController.PlayerState.Move) return;
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 vec = new Vector2(h, v);
        _rb.velocity = vec.normalized * _playerSpeed;
    }
}
