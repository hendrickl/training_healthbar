using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    // Scriptable obj instance
    public IntVariable PlayerHP;

    private float _lastHP;

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Player _player;

    private void Awake()
    {
        _lastHP = _player.Health;
    }

    private void Start()
    {
        if (_player != null)
        {
            _healthText.text = "Player HP = " + _player.Health;
        }
        else
        {
            _healthText.text = "Player not found";
        }
    }

    private void Update()
    {
        if (_player.Health != _lastHP)
        {
            _healthText.text = "Player HP = " + _player.Health;
            _lastHP = _player.Health;
        }
        Debug.Log(PlayerHP.Value);
    }
}
