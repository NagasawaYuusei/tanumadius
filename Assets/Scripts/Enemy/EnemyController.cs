using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float _maxEnemyHP;
    float _currentEnemyHP;
    float _enemyPower;

    public float EnemyPower => _enemyPower;

    private void Awake()
    {
        _maxEnemyHP = ParameterController.Instance._enemyHP;
        _enemyPower = ParameterController.Instance._enemyPower;
    }
    void Start()
    {
        _currentEnemyHP = _maxEnemyHP;
    }

    void AddDamage(float damage)
    {
        _currentEnemyHP -= damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet;
        if(collision.TryGetComponent(out bullet))
        {
            AddDamage(bullet.BulletPower);
            if(_currentEnemyHP <= 0)
            {

                Destroy(this.gameObject);
            }
        }
    }
}
