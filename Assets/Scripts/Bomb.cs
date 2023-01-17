using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int _damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        Characters CharacterToHurt = other.GetComponent<Characters>();

        if (CharacterToHurt)
        {
            CharacterToHurt.GetHurt(_damage);
            Destroy(gameObject);
        }
    }
}
