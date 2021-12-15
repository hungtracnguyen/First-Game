using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Air.Core
{

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float movingSpeed = 2f;
        [SerializeField] float rotationSpeed;
        private float x;
        private float y;
        private Vector3 movement;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetInput();
            Move();
            Rotate();
        }

        // get the inputs from keyboard
        private void GetInput()
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
            movement = new Vector3(x, y, 0f).normalized;
        }

        // get movement to see if transform is moving or not
        public Vector3 GetMovement()
        {
            return movement;
        }

        // move the transform
        private void Move()
        {
            // local mmovement
            //transform.Translate(movement * Time.deltaTime * movingSpeed);   

            // world space movement
            transform.position += movement * Time.deltaTime * movingSpeed;
        }

        // rotate transform
        private void Rotate()
        {
            if (movement != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movement);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
        }
    }

}
