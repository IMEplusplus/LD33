using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

    public GameObject bridge;
    public GameObject bridgeColider;

    AudioSource audio;

    private bool locked = false;

    void Start()
    {
        GameObject explosion = GameObject.Find("Explosion");
        audio = explosion.GetComponent<AudioSource>();
    }

    public void Activate()
    {
        if(!locked)
        {
            audio.Play();
            bridge. SetActive(!bridge.activeSelf);
            bridgeColider.SetActive(!bridgeColider.activeSelf);
        }
    }
}
