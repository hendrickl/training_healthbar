using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private IntVariable _initialHealth;
    [SerializeField] private IntVariable _health;

    public IntVariable Health
    {
        get { return _health; }
    }

    private void Awake()
    {
        _health = _initialHealth;
    }
    public void GetHurt(int damage)
    {
        /*
        _health -= damage;

        if (_health <= 0)
        {
            _health = 0;
        }
        */
    }
}
