﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {

	public GameObject PanelMinigame;
	public GameObject PanelPeople;
	public GameObject PanelTiles;
	public static Game Me;

	void Awake() {
		Me = this;

		List<List<TileTemplate>> tiles =  MapReader.LoadMapFromJson(Resources.Load<TextAsset>("Maps/testmap").text);


		PanelMinigame.GetComponent<PanelMinigame>().Prepare(tiles);
		PanelPeople.GetComponent<PanelPeople> ().SpawnPeople ();
	}
	
}
