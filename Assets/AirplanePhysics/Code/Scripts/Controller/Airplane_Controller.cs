using System.Collections.Generic;
using UnityEngine;

namespace LymiteDev
{
    public class Airplane_Controller : BaseRigidbody_Controller
    {
        #region Variables

        [Header("Base Airplane Properties")] 
        public BaseAirplane_Input input;

        public Transform centerOfGravity;
        
        [Tooltip("Weight is in LBS")]
        public float airplaneWeight = 800f;

        [Header("Engines")] 
        public List<Airplane_Engine> engines = new List<Airplane_Engine>();
        
        [Header("Wheels")] 
        public List<Airplane_Wheels> wheels = new List<Airplane_Wheels>();
        
        
        #endregion

        
        
        #region Constants

        private const float poundsToKilos = 0.453592f;

        #endregion

        
        
        #region Builtin Methods

        public override void Start()
        {
            base.Start();

            float finalMass = airplaneWeight * poundsToKilos;
            
            if (rb)
            {
                rb.mass = finalMass;
                if (centerOfGravity)
                {
                    rb.centerOfMass = centerOfGravity.localPosition;
                }
            }
            
            if (wheels!=null)
            {
                if (wheels.Count > 0)
                {
                    foreach (Airplane_Wheels wheel in wheels)
                    {
                        wheel.InitWheel();
                    }
                }
            }
        }

        #endregion
        
        
        
        #region Custom Methods

        protected override void HandlePhysics()
        {
            if (input)
            {
                HandleEngines();
                HandleAerodynamics();
                HandleSteering();
                HandleBrakes();
                HandleAltitude();   
            }
        }

        private void HandleEngines() 
        {
            if (engines!=null)
            {
                if (engines.Count > 0)
                {
                    foreach (Airplane_Engine engine in engines)
                    {
                        rb.AddForce(engine.CalculateForce(-input.Throttle));
                    }
                }
            }
        }
        
        private void HandleAltitude()
        {
            
        }

        private void HandleBrakes()
        {
            
        }

        private void HandleSteering()
        {
            
        }
        
        private void HandleAerodynamics()
        {
            
        }

        #endregion
    }
}