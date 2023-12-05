using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour
{
	private List<string> originalWords = new List<string>()
	{
		"Pancakes", "Are", "Delicious", "But", "You", "Should", "Not", "Eat", "Them", "Every", "Day", "This", "Is", "Not", "New", "News", "How", "Come", "You", "Never", "Knew", "This", "Well",
	};
	
	private List<string> workingWords = new List<string>();
	
	private int iterator = 0;
	
	private void Awake()
	{
		workingWords.AddRange(originalWords);
		//Shuffle(workingWords);
		ConverToLower(workingWords);
	}
	
	private void Shuffle(List<string> list)
	{
		for(int i = 0; i < list.Count; i++)
		{
			int random = Random.Range(i, list.Count);
			string temporary = list[i];
			
			list[i] = list[random];
			list[random] = temporary;
		}
	}
	
	private void ConverToLower(List<string> list)
	{
		for(int i = 0; i < list.Count; i++)
			list[i] = list[i].ToLower();
	}
	
	public string GetWord()
	{
		string newWord = string.Empty;
		
		if(workingWords.Count != 0)
		{
			newWord = workingWords[iterator];
			workingWords.Remove(newWord);
			//iterator++;
		}
		return newWord;
	}
}