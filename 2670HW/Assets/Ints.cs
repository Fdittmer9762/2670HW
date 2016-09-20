using UnityEngine;
using System.Collections;

public class Ints : MonoBehaviour {

	public float firstNumber;
	public float secondNumber;

	void Start () {
		Add (firstNumber, secondNumber); //etc
		Subtract (firstNumber, secondNumber); //etc
		Multiply (firstNumber, secondNumber); //etc
		Dev (firstNumber, secondNumber); //etc
	}

	float Add(float x, float y){
		float temp = x + y;
		Debug.Log (x + " + " + y + " = " + temp);
		return temp;
	}

	float Subtract(float x, float y){
		float temp = x - y;
		Debug.Log (x + " - " + y + " = " + temp);
		return temp;
	}

	float Multiply (float x, float y){
		float temp = x * y;
		Debug.Log (x + " * " + y + " = " + temp);
		return temp;
	}

	float Dev(float x, float y){
		float temp = x / y;
		Debug.Log (x + " / " + y + " = " + temp);
		return temp;
	}
}
