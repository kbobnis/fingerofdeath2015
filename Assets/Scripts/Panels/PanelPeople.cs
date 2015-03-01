﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PanelPeople : MonoBehaviour {

	public GameObject PersonPrefab;

	internal void SpawnPeople (List<PersonTemplate> personTemplates){

		PersonPrefab.SetActive(true);
		int i=0;
		foreach(PersonTemplate pt in personTemplates){

			GameObject personGameObject = Instantiate (PersonPrefab) as GameObject;
			personGameObject.transform.parent = transform;

			personGameObject.name = "person: " + i++ + ", x: " + pt.PositionX + ", y: " + pt.PositionY;

			personGameObject.AddComponent<Person>().Prepare(pt.PositionX, pt.PositionY );
			int personW = (int)(personGameObject.GetComponent<Image>().sprite.rect.width * AspectRatioKeeper.ActualScale);
			int personH = (int)(personGameObject.GetComponent<Image>().sprite.rect.height * AspectRatioKeeper.ActualScale);
			personGameObject.AddComponent<RealSize>().SetSize(personW, personH);
			personGameObject.GetComponent<Person>().StartMe();
		}

		PersonPrefab.SetActive(false);
	}

}
