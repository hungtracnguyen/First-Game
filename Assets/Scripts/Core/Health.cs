using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Core
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoint = 100f;
        private float maxHealthPoint = 0f;
        SpriteRenderer sp;
        BoxCollider2D myBoxCollider;

        public event Action OnDestroy;

        private void Awake()
        {
            sp = GetComponent<SpriteRenderer>();
            myBoxCollider = GetComponent<BoxCollider2D>();
        }

        private void Start()
        {
            maxHealthPoint = healthPoint;
           
        }

        private void OnEnable()
        {
            OnDestroy += Die;
        }

        private void OnDisable()
        {
            OnDestroy -= Die;
        }

        public virtual void TakeDamage(float damage)
        {
            healthPoint -= damage;

            if(healthPoint <= 0)
            {
                
                OnDestroy();
                return;
            }
        }

        private void Die()
        {
            sp.enabled = false;
            myBoxCollider.enabled = false;

            if(GetComponentInChildren<ParticleSystem>() != null)
            {
                GetComponentInChildren<ParticleSystem>().Play();
            }

            Destroy(gameObject, 1f);
        }

        public float GetHealthFraction()
        {
            return healthPoint / maxHealthPoint;
        }
    }
}


