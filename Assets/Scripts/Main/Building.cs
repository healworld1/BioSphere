using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Building : MonoBehaviour {
	int sizeOccupied {
		get;
		set;
	}   // return the size a building will occupied
	int cost {
		get;
		set;
	}   // return the cost of the buildling;
    abstract public string ShowProperty(); // show the property a building will have in the text

    abstract public bool Availblility();// return the availbility of the building
}