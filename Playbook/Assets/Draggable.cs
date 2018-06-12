using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : EventTrigger
{
	public override void OnDrag(PointerEventData data)
	{
		transform.position += (Vector3)data.delta;
	}
		


}
