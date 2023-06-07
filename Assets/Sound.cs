using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Sound : MonoBehaviour
    {
        public AudioSource AS;
        // Use this for initialization
        void Start()
        {
            AS = GetComponent<AudioSource>();
            AS.Play();
            AS.Play();
            AS.Play();
            AS.Play();
        }
    }
}