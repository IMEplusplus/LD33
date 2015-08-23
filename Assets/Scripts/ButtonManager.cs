using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

    public GameObject bridge;
    public GameObject bridgeColider;

    private bool locked = false;

	public void Activate()
    {
        if(!locked)
        {
            bridge. SetActive(!bridge.activeSelf);
            bridgeColider.SetActive(!bridgeColider.activeSelf);
        }
    }
}
