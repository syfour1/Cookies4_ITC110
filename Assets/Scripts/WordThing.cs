using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordThing : MonoBehaviour
{
	string[] words = {"Pancakes", "Are", "Delicious", "But", "You", "Should", "Not", "Eat", "Them", "Every", "Day"};
	
	public string ChooseNewWord()
	{
		return words[Random.Range(0, 11)];
	}
}
