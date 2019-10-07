﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundItem : Interactable {
	public ItemSO Item;

	protected override void Awake() {
		base.Awake();
		OnMouseClick += CollectItem;
		//TODO: not sure that it shoud be there
		Item = Instantiate(Item);
	}

	void CollectItem() {
		//TODO: add fly animation
		//TODO: or show special frame around new items
		//TODO: Play pickup anim
		if(GameManager.Instance.Player.Inventory.AddItem(Item))
			Destroy(gameObject);
	}
}
