using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Combat
{

    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] Weapon weapon = null;
        [SerializeField] CircleCollider2D circleCollider = null;
        [SerializeField] float degreeRotation = 360f;

        private void Awake()
        {
            circleCollider = GetComponent<CircleCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                //transform.LookAt(collision.transform.position, Vector3  );
                
                //Shoot();
            }
        }

        private void Shoot()
        {
            Instantiate(weapon.GetBulletPrefab(), transform.up, transform.rotation);
        }

    }

}