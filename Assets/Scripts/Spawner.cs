using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public void Spawn()
        {
            if (prefab == null) return;

            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
