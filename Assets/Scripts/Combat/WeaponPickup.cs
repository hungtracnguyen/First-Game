using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Combat
{
    public class WeaponPickup : MonoBehaviour
    {
        [SerializeField] Weapon weapon = null;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PlayerAction>().SetWeapon(weapon);
            }
        }
    }
}
