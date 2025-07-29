using System;
using UnityEngine;

namespace LymiteDev
{
    public class XboxAirplane_Input : BaseAirplane_Input
    {
        protected override void HandleInput()
        {
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");

            yaw = Input.GetAxis("X_RH_Stick");
            throttle = Input.GetAxis("X_RV_Stick");
            
            //Shortcut for if else structure
            brake = Input.GetAxis("Fire1");

            if (Input.GetButtonDown("X_R_Bumper"))
            {
                flaps += 1;
            }

            if (Input.GetButtonDown("X_L_Bumper"))
            {
                flaps -= 1;
            }

            flaps = Mathf.Clamp(flaps, 0, maxFlapsIncrements);
        }
    }
}
