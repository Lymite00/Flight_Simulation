using UnityEditor;
using UnityEngine;

namespace LymiteDev
{
    [CustomEditor(typeof(XboxAirplane_Input))]
    public class XboxAirplaneInput_Editor : Editor
    {
        #region Variables

        [Header("Variables")]
        private XboxAirplane_Input targetInput;
        
        #endregion

        #region Builtin Methods

        private void OnEnable()
        {
            targetInput = (XboxAirplane_Input)target;
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