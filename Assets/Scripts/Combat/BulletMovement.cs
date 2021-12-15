using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Combat
{
    public class BulletMovement : MonoBehaviour
    {
        [SerializeField] float speed = 1f;
        [SerializeField] float timeToDestroy = 5;
        float timeTicking = Mathf.Infinity;

        private void Start()
        {
            timeTicking = 0;
        }
        void Update()
        {
            //move gameobject forward
            transform.Translate(Vector3.up * speed);

            // destroy gameobject after certain amount of time
            timeTicking += Time.deltaTime;
            if (timeTicking > timeToDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}
