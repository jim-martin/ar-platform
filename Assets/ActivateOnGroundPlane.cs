using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityARInterface;

public class ActivateOnGroundPlane : MonoBehaviour {

	void OnEnable()
	{
		ARInterface.planeAdded += PlaneAddedHandler;
		//ARInterface.planeUpdated += PlaneUpdatedHandler;
		//ARInterface.planeRemoved += PlaneRemovedHandler;
	}

	void OnDisable()
	{
		//ARInterface.planeAdded -= PlaneAddedHandler;
		//ARInterface.planeUpdated -= PlaneUpdatedHandler;
		//ARInterface.planeRemoved -= PlaneRemovedHandler;
	}

	void PlaneAddedHandler(BoundedPlane plane)
	{
		var newPosition = transform.localPosition;
		newPosition.y = plane.center.y;

		transform.position = newPosition;
		ARInterface.planeAdded -= PlaneAddedHandler;
	}
}
