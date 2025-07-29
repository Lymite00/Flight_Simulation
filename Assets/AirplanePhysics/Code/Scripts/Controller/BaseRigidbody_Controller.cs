using System;
using UnityEngine;

namespace LymiteDev
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(AudioSource))]
    public class BaseRigidbody_Controller : MonoBehaviour
    {
        #region Variables

        [Header("Variables")] 
        protected Rigidbody rb;
        protected AudioSource aSource;

        #endregion

        #region Builtin Methods

        public virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
            aSource = GetComponent<AudioSource>();

            if (aSource)
            {
                aSource.playOnAwake = false;
            }
        }

        private void FixedUpdate()
        {
            if (rb)
            {
                HandlePhysics();
            }
        }
        
        #endregion

        #region Custom Methods
        
        

        protected virtual void HandlePhysics()
        {
            // weight = mass * gravity
        }

        #endregion
    }
}