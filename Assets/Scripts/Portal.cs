﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

	void OnMouseDown () {
		Player player = Manager.manager.GetPlayer();
		if (player != null) {
				if (!player.IsMoving())
					player.Move(transform.position);
		}
	}
}
