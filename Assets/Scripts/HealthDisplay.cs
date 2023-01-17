using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    private float _lastHP;

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Player _player;
    // Scriptable obj instance
    [SerializeField] private IntVariable _hp;

    private void Awake()
    {
        _lastHP = _hp.Value;
    }

    private void Start()
    {
        if (_player != null)
        {
            _healthText.text = "Player HP = " + _hp.Value;
        }
        else
        {
            _healthText.text = "Player not found";
        }
    }

    private void Update()
    {
        if (_hp.Value != _lastHP)
        {
            _healthText.text = "Player HP = " + _hp.Value;
            _lastHP = _hp.Value;
        }
        Debug.Log(_hp.Value);
    }
}
