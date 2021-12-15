using System.Collections;
using UnityEngine;

namespace Air.Combat
{
    
    public class CurveBulletMovement : MonoBehaviour
    {

        [SerializeField] float speed = 1f;
        [SerializeField] float timeToDestroy = 5f;
        float timeTicking = Mathf.Infinity;

        [SerializeField] float curveDistance = 1f;
        [SerializeField] float curveTime = 1f;

        private void Start()
        {
            timeTicking = 0;
        }
        void Update()
        {
            //move gameobject forward
            transform.Translate(Vector3.up * speed);

            //curve movement
            if(curveTime > timeTicking)
            {
            transform.position += new Vector3(curveDistance, 0f, 0f);
            } else
            {
            transform.position += new Vector3(-curveDistance, 0f, 0f);
            }

            // destroy gameobject after certain amount of time
            timeTicking += Time.deltaTime;
            if (timeTicking > timeToDestroy)
            {
                Destroy(gameObject);
            }
        }
    }

}