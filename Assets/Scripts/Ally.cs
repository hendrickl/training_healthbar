using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : Characters
{
    [SerializeField] private int _followDistance;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _player;

    private void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) > _followDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
        }
    }
}
