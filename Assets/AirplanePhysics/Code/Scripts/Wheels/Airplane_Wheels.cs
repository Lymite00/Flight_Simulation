using System;
using UnityEngine;

namespace LymiteDev
{
    [RequireComponent(typeof(WheelCollider))]
    public class Airplane_Wheels : MonoBehaviour
    {
        #region Variables
        
        private WheelCollider wheelCol;
        
        #endregion

        #region Builtin Methods

        private void Start()
        {
            wheelCol = GetComponent<WheelCollider>();
        }

        #endregion

        #region Custom Methods

        public void InitWheel()
        {
            if (wheelCol)
            {
                wheelCol.motorTorque = 0.00000000001f;
            }
        }

        #endregion
    }
}