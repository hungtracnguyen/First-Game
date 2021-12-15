using Air.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Combat
{

    public class PlayerAction : MonoBehaviour
    {

        Weapon currentWeapon = null;
        private int speedUp = 1;

        public event Action OnShoot1;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }

            // increase the bullet prefab distance if the trasform is moving
            SpeedUp();

            //Debug.Log("the weapon is " + currentWeapon);
        }

        private void SpeedUp()
        {
            if (GetComponent<PlayerMovement>().GetMovement() == Vector3.zero)
            {
                speedUp = 1;
            }
            else
            {
                speedUp = 2;
            }
    }

        public Weapon SetWeapon(Weapon weapon)
        {
            return currentWeapon = weapon;
        }

        private void Shoot()
        {
            if (currentWeapon != null)
            {
                Instantiate(currentWeapon.GetBulletPrefab(), transform.position + transform.up * speedUp, transform.rotation);
                OnShoot1();
            }

        }
    }

}