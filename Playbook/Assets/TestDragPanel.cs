using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestDragPanel : Draggable {



	// testing
	public override void OnBeginDrag(PointerEventData data)
	{
		var im = GetComponent<Image> ();
		if (!im) {
			return;
		}

		im.color = Color.red;
	}
	public override void OnEndDrag(PointerEventData data)
	{
		var im = GetComponent<Image> ();
		if (!im) {
			return;
		}
		im.color = Color.white;
	}

}
