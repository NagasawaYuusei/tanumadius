using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterController : MonoBehaviour
{
    public static ParameterController Instance;
    [SerializeField, Range(1.0f, 100.0f), Header("�v���C���[��HP")] public float _playerHP = 100;
    [SerializeField, Range(1.0f, 50.0f), Header("�v���C���[�̃X�s�[�h")] public float _playerSpeed = 1;
    [SerializeField, Range(1.0f, 100.0f), Header("�e�̈З�")] public float _bulletPower = 50;
    [SerializeField, Range(1.0f, 50.0f), Header("�e�̑��x")] public float _bulletSpeed = 1;
    [SerializeField, Range(1.0f, 50.0f), Header("�e�̑傫��")] public float _bulletSize = 1;
    [SerializeField, Range(1.0f, 100.0f), Header("�G��HP")] public float _enemyHP = 100;
    [SerializeField, Range(1.0f, 50.0f), Header("�G�̃X�s�[�h")] public float _enemySpeed = 1;//
    [SerializeField, Range(1.0f, 100.0f), Header("�G�̃p���[")] public float _enemyPower = 10;
    [SerializeField, Range(1.0f, 50.0f), Header("�}�b�v�̃X�s�[�h")] public float _mapSpeed = 1;



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
