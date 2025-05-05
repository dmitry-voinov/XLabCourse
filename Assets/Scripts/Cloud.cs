using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW
{
    public class Cloud : MonoBehaviour
    {
        [SerializeField] private ParticleSystem m_particleSystem;
        public void PlayFX()
        {
            m_particleSystem.Play();
        }

        public void StopFX()
        {
            m_particleSystem.Stop();
        }
    }
}