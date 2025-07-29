using System;
using UnityEngine;

namespace LymiteDev
{
    public class BaseAirplane_Input : MonoBehaviour
    {
        #region Variables

        [Header("Variables")] 
        protected float pitch = 0f;
        protected float roll = 0f;
        protected float yaw = 0f;
        protected float throttle = 0f;
        protected float brake = 0f;

        public int maxFlapsIncrements = 2;
        protected int flaps = 0;

        public InputSO input;
        
        #endregion
        
        #region Properties

        //public float Pitch
        //{
        //    get { return pitch; }
        //}
        
        public float Pitch => pitch;
        public float Roll => roll;
        public float Yaw => yaw;
        public float Throttle => throttle;

        public int Flaps => flaps;
        public float Brake => brake;

        #endregion
        
        #region Builtin Methods

        private void Start()
        {
            
        }

        private void Update()
        {
            HandleInput();
        }

        #endregion

        #region Custom Methods

        protected virtual void HandleInput()
        {
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");

            yaw = Input.GetAxis("Yaw");
            throttle = Input.GetAxis("Throttle");
            
            //Shortcut for if else structure
            brake = Input.GetKey(input.brakeKey)? 1f : 0f;

            if (Input.GetKeyDown(input.flapIncreaseKey))
            {
                flaps += 1;
            }

            if (Input.GetKeyDown(input.flapDecreaseKey))
            {
                flaps -= 1;
            }

            flaps = Mathf.Clamp(flaps, 0, maxFlapsIncrements);
        }

        #endregion
    }
}