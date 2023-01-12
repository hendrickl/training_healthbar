using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject _gameObj;
    [SerializeField] private int _initialHealth = 100;
    private int _health;
    public int Health
    {
        get { return _health; }
    }

    private void Start()
    {
        _health = _initialHealth;
        _gameObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _gameObj.transform.position = new Vector3(0, 0, 0);
    }
}
