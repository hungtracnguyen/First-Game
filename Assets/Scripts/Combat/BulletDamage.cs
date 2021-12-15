using Air.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Combat
{
    public class BulletDamage : MonoBehaviour
    {
        [SerializeField] Weapon weapon;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Health>() != null)
            {
                collision.GetComponent<Health>().TakeDamage(weapon.GetWeaponDamage());
                Destroy(gameObject);
            }
        }
    }
}
