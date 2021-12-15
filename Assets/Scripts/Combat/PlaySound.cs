using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Air.Core;

namespace Air.Combat
{
    public class PlaySound : MonoBehaviour
    {
        [SerializeField] AudioSource destroySFX = null;
        [SerializeField] AudioSource shootSFX = null;
        
        private void OnEnable()
        {
            GetComponent<Health>().OnDestroy += PlayDestroySFX;
            if(GetComponent<PlayerAction>() != null)
            {
                GetComponent<PlayerAction>().OnShoot1 += PlayShootSFX;
            }
        }

        private void OnDisable()
        {
            GetComponent<Health>().OnDestroy -= PlayDestroySFX;
            if (GetComponent<PlayerAction>() != null)
            {
                GetComponent<PlayerAction>().OnShoot1 -= PlayShootSFX;
            }
        }
            

        private void PlayDestroySFX()
        {
            destroySFX.Play();
        }

        private void PlayShootSFX()
        {
            shootSFX.Play();
        }
    }
}
