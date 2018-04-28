using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public IngameGui ingameGui;
    public Player player;

	void Start () {
        ingameGui.Init();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
