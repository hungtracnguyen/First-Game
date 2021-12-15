using UnityEngine;

namespace Air.Combat
{

    [CreateAssetMenu(fileName = "Weapon", menuName = "CreateNewFunction/Weapon", order = 0)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] GameObject bulletPrefab = null;
        [SerializeField] float weaponDamage;

        public GameObject GetBulletPrefab()
        {
            return bulletPrefab;
        }

        public float GetWeaponDamage() => weaponDamage;

    }
}
