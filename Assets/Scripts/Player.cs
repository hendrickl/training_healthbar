using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
    }
}
