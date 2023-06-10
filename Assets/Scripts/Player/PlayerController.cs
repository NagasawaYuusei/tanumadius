using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    float _maxPlayerHP = 100;
    float _currentPlayerHP;
    Rigidbody2D _rb;
    PlayerState _state = PlayerState.Move;

    public PlayerState State => _state;

    private void Awake()
    {
        _maxPlayerHP = ParameterController.Instance._playerHP;
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _currentPlayerHP = _maxPlayerHP;
    }

    public void AddDamege(float damage)
    {
        _currentPlayerHP -= damage;
    }

    public void HealHP(float value)
    {
        _currentPlayerHP += value;
        if(_currentPlayerHP > _maxPlayerHP)
        {
            _currentPlayerHP = _maxPlayerHP;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController ec;
        if(collision.TryGetComponent(out ec))
        {
            AddDamege(ec.EnemyPower);
            _rb.velocity = Vector2.zero;
            _rb.AddForce(Vector2.left, ForceMode2D.Impulse);
            _state = PlayerState.KnockBack;
            StartCoroutine(KnockBack());
        }
    }

    IEnumerator KnockBack()
    {
        yield return new WaitForSeconds(1);
        _state = PlayerState.Move;
    }

    public enum PlayerState
    {
        None,
        Move,
        KnockBack
    }
}
