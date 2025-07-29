using UnityEngine;

[CreateAssetMenu(menuName = "Inputs", fileName = "Keycodes")]
public class InputSO : ScriptableObject
{
    [Header("Keycodes")] 
    public KeyCode brakeKey = KeyCode.Space;
    public KeyCode flapIncreaseKey = KeyCode.F;
    public KeyCode flapDecreaseKey = KeyCode.G;
}
