using FistVR;
using UnityEngine;

namespace H3VR_Stuff
{
    class PalySoundInRadiusOfSosig : MonoBehaviour
    {
        public AudioClip Sound = new AudioClip();
        public int Radius = 1;
        public bool OnlyPlayOnce = false;

        private Sosig[] sosigs = new Sosig[0];
        
        public void Awake()
        {
            // Initially set the known 
            updateSosigList();

            GM.CurrentSceneSettings.SosigKillEvent += OnSosigKill;
        }

        public void FixedUpdate()
        {
            // Check for sosig in radius
            foreach(Sosig sosig in sosigs)
            {
                float dist = Vector3.Distance(transform.position, sosig.transform.position);
                if (dist < Radius)
                    playSound();
            }
        }

        private void playSound()
        {
            // This will overlap with itself, needs a loop condition (AudioSource.loop = true?)
            AudioSource.PlayClipAtPoint(Sound, transform.position);
            if (OnlyPlayOnce == true)
                Destroy(this);
        }

        private void OnSosigKill(Sosig s)
        {
            updateSosigList();
        }

        private void updateSosigList()
        {
            sosigs = FindObjectsOfType<Sosig>();
        }
    }
}
