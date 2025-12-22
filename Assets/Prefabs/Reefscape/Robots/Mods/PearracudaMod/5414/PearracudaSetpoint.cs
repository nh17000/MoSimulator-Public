using UnityEngine;

namespace Prefabs.Reefscape.Robots.Mods.PearracudaMod._5414
{
    [CreateAssetMenu(fileName = "Setpoint", menuName = "Robot/Pearracuda Setpoint", order = 0)]
    public class PearracudaSetpoint : ScriptableObject
    {
        [Tooltip("Inches")] public float elevatorHeight;
        [Tooltip("Degrees")] public float armAngle;
    }
}