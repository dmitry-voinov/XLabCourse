using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW
{
    public class PlayerControl : MonoBehaviour
    {
        public List<Refresh> villagers;
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var villagers in villagers)
                { 
                    villagers.ChangeTool();
                }
            }
        }
    }
}