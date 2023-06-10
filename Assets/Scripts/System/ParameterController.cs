using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterController : MonoBehaviour
{
    public static ParameterController Instance;
    [SerializeField, Range(1.0f, 100.0f), Header("プレイヤーのHP")] public float _playerHP = 100;
    [SerializeField, Range(1.0f, 50.0f), Header("プレイヤーのスピード")] public float _playerSpeed = 1;
    [SerializeField, Range(1.0f, 100.0f), Header("弾の威力")] public float _bulletPower = 50;
    [SerializeField, Range(1.0f, 50.0f), Header("弾の速度")] public float _bulletSpeed = 1;
    [SerializeField, Range(1.0f, 50.0f), Header("弾の大きさ")] public float _bulletSize = 1;
    [SerializeField, Range(1.0f, 100.0f), Header("敵のHP")] public float _enemyHP = 100;
    [SerializeField, Range(1.0f, 50.0f), Header("敵のスピード")] public float _enemySpeed = 1;//
    [SerializeField, Range(1.0f, 100.0f), Header("敵のパワー")] public float _enemyPower = 10;
    [SerializeField, Range(1.0f, 50.0f), Header("マップのスピード")] public float _mapSpeed = 1;



    private void Awake()
    {
        Instance = this;
    }

    public enum SettingsPriority
    {
        Controller,
        Component
    }
}
