using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Core
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] Health health;
        [SerializeField] RectTransform foreground = null;
        private Canvas canvas = null;

        private void Start()
        {
            canvas = GetComponent<Canvas>();
        }

        private void Update()
        {
            
            
            if(health.GetHealthFraction() <= 0 || Mathf.Approximately(health.GetHealthFraction(), 1))
            {
                canvas.enabled = false;
                
            }
            else
            {
                canvas.enabled = true;;
                foreground.localScale = new Vector3(health.GetHealthFraction(), 1f, 1f);
            }
        }


    }
}
