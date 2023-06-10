using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _muzzle;
    void Update()
    {
        Shot();
    }

    void Shot()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Instantiate(_bullet, _muzzle.position, Quaternion.identity);
        }
    }
}
