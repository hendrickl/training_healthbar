using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int _damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject + " collides with " + gameObject);

        if (other.gameObject.CompareTag("Player"))
        {
            Player player = other.gameObject.GetComponent<Player>();
            player.GetHurt(_damage);

            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Ally"))
        {
            Ally ally = other.gameObject.GetComponent<Ally>();
            ally.GetHurt(_damage);

            Destroy(gameObject);
        }
    }
}
