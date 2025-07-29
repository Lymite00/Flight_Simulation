using System;
using UnityEngine;
using UnityEditor;

namespace LymiteDev
{
    [CustomEditor(typeof(BaseAirplane_Input))]
    public class BaseAirplaneInput_Editor : Editor
    {
        #region Variables

        [Header("Variables")]
        private BaseAirplane_Input targetInput;
        
        #endregion

        #region Builtin Methods

        private void OnEnable()
        {
            targetInput = (BaseAirplane_Input)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            string debugInfo = "";
            debugInfo += "Pitch= " + targetInput.Pitch + "\n";
            debugInfo += "Roll= " + targetInput.Roll + "\n";
            debugInfo += "Yaw= " + targetInput.Yaw + "\n";
            debugInfo += "Throttle= " + targetInput.Throttle + "\n";
            debugInfo += "Brake= " + targetInput.Brake + "\n";
            debugInfo += "Flaps= " + targetInput.Flaps + "\n";
            
            GUILayout.Space(20);
            EditorGUILayout.TextArea(debugInfo,GUILayout.Height(100));
            GUILayout.Space(20);
            
            Repaint();
        }

        #endregion
    }
}
