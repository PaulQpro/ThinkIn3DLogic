using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Money : MonoBehaviour
{
    AudioSource sound;
    GameObject money;
    void Start()
    {
        sound = GetComponentInChildren<AudioSource>();
        money = GetComponentInChildren<MeshCollider>().gameObject;
    }
    void Update()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + .1F, 0);
    }
    public void OnPick()
    {
        sound.Play();
        money.SetActive(false);
    }
}
