using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Combat
{
    public class LookAt : MonoBehaviour
    {

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                transform.LookAt(collision.transform.position);
            }
        }
    }
}