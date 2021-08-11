using System;
using UnityEngine;
using FistVR;

namespace H3VR_Stuff
{
    public class RotateToPlayer : MonoBehaviour
    {
        public GameObject Item;

        public void Start()
        {
            Transform pPos = GM.CurrentPlayerBody.Head.transform;

            Vector3 v3Dir = Item.transform.position - pPos.position;
            float angle = Mathf.Atan2(v3Dir.x, v3Dir.z) * Mathf.Rad2Deg;
            Item.transform.eulerAngles = new Vector3(0, angle, 0);
        }
    }
}