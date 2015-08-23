using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

    public GameObject bridge;
    public GameObject bridgeColider;
    public GameObject elfPrefab;
    public Transform[] spawners;
    bool spawned;

    AudioSource audio;

    private bool locked = false;

    void Start()
    {
        GameObject explosion = GameObject.Find("Explosion");
        audio = explosion.GetComponent<AudioSource>();
        spawned = false;
    }

    public void Activate()
    {
        if(!locked)
        {
            audio.Play();
            bridge. SetActive(!bridge.activeSelf);
            bridgeColider.SetActive(!bridgeColider.activeSelf);

            //Monster Spawn
            if (!spawned)
            {
                foreach(Transform trans in spawners) {
                    Instantiate(elfPrefab, trans.position, Quaternion.identity);
                }
                spawned = true;
            }

        }
    }
}
