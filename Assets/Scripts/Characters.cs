using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] protected int _initialHealth = 100;
    [SerializeField] private IntVariable _health;

    public int Health
    {
        get { return _health.Value; }
    }

    private void Awake()
    {
        _health.Value = _initialHealth;
    }
    public void GetHurt(int damage)
    {
        _health.Value -= damage;

        if (_health.Value <= 0)
        {
            _health.Value = 0;
        }
    }
}
