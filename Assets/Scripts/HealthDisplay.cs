using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    Player _player;

    [SerializeField] private TMP_Text _healthText;

    private void Start()
    {
        _player = GetComponent<Player>();
        _healthText.text = "Player HP = " + _player.Health.ToString();
    }
}
