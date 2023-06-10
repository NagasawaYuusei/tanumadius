using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    [SerializeField] PlayerController _controller;
    float _speed;

    void Awake()
    {
        _speed = ParameterController.Instance._mapSpeed * 0.2f;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (_controller.State == PlayerController.PlayerState.None) return;
        transform.position += Vector3.left * Time.deltaTime * _speed;
    }
}
