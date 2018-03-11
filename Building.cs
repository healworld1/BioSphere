using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Building : MonoBehaviour {
	int sizeOccupied {
		get;
		set;
	}   // return the size a building will occupied
	int cost {
		get;
		set;
	}   // return the cost of the buildling;
	string showProperty ()  // show the property a building will have in the text
	bool availblility()// return the availbility of the building
}