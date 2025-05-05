using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW
{
    public class PlayerController : MonoBehaviour
    {
        public Spawner spawner;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                spawner.Spawn();
            }
        }
    }
}
