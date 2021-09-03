using System;
using FistVR;
using UnityEngine;

namespace H3VR_Stuff
{
	public class DamageInsideOf
	{
		public Vector3 point;
		public float radius;
		public float damage;

		public void fixedUpdate()
        {
			if(Vector3.Distance(GM.CurrentPlayerBody.transform.position, point) <= radius)
            {
				GM.CurrentPlayerBody.Health -= damage;
            }
        }
	}
}