using FistVR;
using UnityEngine;

namespace H3VR_Stuff
{
    class RotateTwoPoints : MonoBehaviour
    {
        public GameObject Item_To_Rotate = new GameObject();
        public Vector3 startRot = new Vector3(0, 0, 0), endRot = new Vector3(0, 0, 0);
        public float rotSpeedMult = 1;
        public float baseSpeed = 1;

        public void FixedUpdate()
        {
            //determine rotation direction
            if(Item_To_Rotate.transform.position == endRot)
            {
                Vector3 storedPos = startRot;
                startRot = endRot;
                endRot = storedPos;
            }

            //determine rotation speed
            float distS = Vector3.Distance(startRot, Item_To_Rotate.transform.position);
            float distE = Vector3.Distance(endRot, Item_To_Rotate.transform.position);

            var speedToRotate = baseSpeed + distS < distE ? Mathf.Abs(distS) : Mathf.Abs(distE);

            //preform the rotation
            Item_To_Rotate.transform.Rotate(Vector3.Lerp(startRot, endRot, speedToRotate * Time.deltaTime * rotSpeedMult));
        }
    }
}
