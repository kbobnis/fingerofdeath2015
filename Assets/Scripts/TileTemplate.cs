﻿using UnityEngine;
using System.Collections;

public enum Version{
	_1,
	_2
}

public class TileTemplate  {

	public TileType TileType;
	public Rotation Rotation;
	public Version _Version;

	public TileTemplate(TileType tt, Rotation r) {
		TileType = tt;
		Rotation = r;
	}

	internal static TileTemplate FromJsonInt(int id) {
		return new TileTemplate(TileType.FromJsonInt(id), Rotation.FromJsonInt(id));
	}


}
