using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int numElves;

	// Use this for initialization
	void Start () {
        numElves = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IncreaseElves()
    {
        numElves++;
    }

    public void DecreaseElves()
    {
        numElves--;
    }

    public bool NoElves()
    {
        return numElves == 0;
    }
}
