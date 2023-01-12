using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] private int _initialHealth = 100;
    private int _health;
    public int Health
    {
        get { return _health; }
    }

    private void Awake()
    {
        _health = _initialHealth;
        print("_health : " + _health);

    }

    public void GetHurt(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            _health = 0;
        }
    }
}
