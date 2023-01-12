using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealtHAllyDisplay : MonoBehaviour
{
    private float _lastHP;

    [SerializeField] private TMP_Text _healthAllyText;
    [SerializeField] private Ally _ally;

    private void Awake()
    {
        _lastHP = _ally.Health;
    }

    private void Start()
    {
        if (_ally != null)
        {
            _healthAllyText.text = "Ally HP = " + _ally.Health;
        }
        else
        {
            _healthAllyText.text = "Ally not found";
        }
    }

    private void Update()
    {
        if (_ally.Health != _lastHP)
        {
            _healthAllyText.text = "Ally HP = " + _ally.Health;
            _lastHP = _ally.Health;
        }
    }
}
