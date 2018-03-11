using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Building : MonoBehaviour {
    abstract class Building : MonoBehaviour
    {
        public bool Availblility = false;// return the availbility of the building
        public int sizeOccupied = 0;   // return the size a building will occupied
        public int cost = 0;   // return the cost of the buildling;
        abstract public string ShowProperty(); // show the property a building will have in the text
    }
}