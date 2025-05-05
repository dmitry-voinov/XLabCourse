using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW
{
    public class PlayerController : MonoBehaviour
    {
        public CloudController cloudController;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                cloudController.Action();
            }
        }
    }
}
