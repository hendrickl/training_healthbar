using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] private int _initialHealth = 100;
    [SerializeField] private int _followDistance;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _player;
    // Sciptable obj
    [SerializeField] private IntVariable _health;

    public int Health
    {
        get { return _health.Value; }
    }

    private void Awake()
    {
        _health.Value = _initialHealth;
    }

    private void Update()
    {
        FollowPlayer();
    }

    public void GetHurt(int damage)
    {
        _health.Value -= damage;

        if (_health.Value <= 0)
        {
            _health.Value = 0;
        }
    }

    public void FollowPlayer()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) > _followDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
        }
    }
}
