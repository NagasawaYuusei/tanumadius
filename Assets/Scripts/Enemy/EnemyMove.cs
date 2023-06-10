using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float _enemySpeed;
    Vector2 _enemyPosition;
    [SerializeField] EnemyMoveState _state;
    bool _isReturn;


    void Awake()
    {
        _enemySpeed = ParameterController.Instance._enemySpeed * 0.2f;
    }

    void Start()
    {
        _enemyPosition = transform.position;
    }

    void Update()
    {
        if(_state == EnemyMoveState.Horizontal)
        {
            MoveHorizontal();
        }
        else if(_state == EnemyMoveState.Vertical)
        {
            MoveVertical();
        }
    }

    void MoveHorizontal()
    {
        if(!_isReturn)
        {
            transform.position -= new Vector3(Time.deltaTime * _enemySpeed ,0 ,0);
            if(_enemyPosition.x - 1.5f > transform.position.x)
            {
                _isReturn = true;
            }
        }
        else
        {
            transform.position += new Vector3(Time.deltaTime * _enemySpeed, 0, 0);
            if (_enemyPosition.x + 1.5f < transform.position.x)
            {
                _isReturn = false;
            }
        }
    }

    void MoveVertical()
    {
        if (!_isReturn)
        {
            transform.position -= new Vector3(0, Time.deltaTime * _enemySpeed, 0);
            if (_enemyPosition.y - 1.5f > transform.position.y)
            {
                _isReturn = true;
            }
        }
        else
        {
            transform.position += new Vector3(0, Time.deltaTime * _enemySpeed, 0);
            if (_enemyPosition.y + 1.5f < transform.position.y)
            {
                _isReturn = false;
            }
        }
    }

    enum EnemyMoveState
    {
        None,
        Horizontal,
        Vertical
    }
}
