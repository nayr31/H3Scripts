using FistVR;
using UnityEngine;

namespace H3VR_Stuff
{
    class GravitySetOnEnter : MonoBehaviour
    {
        public enum gravMode
        {
            Realistic,
            Playful,
            OnTheMoon,
            None
        }

        public gravMode Gravity_Mode;

        public void OnTriggerEnter(Collider other)
        {
           //GM.Options.SimulationOptions.PlayerGravityMode = (SimulationOptions.GravityMode) Gravity_Mode;
        }
    }
}
