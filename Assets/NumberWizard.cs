using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guessed_num;

	// Use this for initialization
	void Start () {
		max = 1000;
		min = 1;
		guessed_num = 500;
				
		print ("Welcome to my world! I am the Number Wizard!");
		print ("Pick a number between " + min + " to " + max + ". Don't tell me, I will determine what it is.");
		
		print ("The highest numnber you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guessed_num + "? Press Up arrow if it is greater, Press Down arrow if it is lesser. Enter if it is" + guessed_num + ".");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			min = guessed_num;
			NextGuess();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)){
			max = guessed_num;
			NextGuess();
		}
		if (Input.GetKeyDown (KeyCode.Return)){
			print ("Okay so your number was: " + guessed_num + ". Cool story bro.");
			print (" ");
			print ("----New Game Started----");
			Start ();
		}
	}
	
	void NextGuess(){
		guessed_num = (max + min) / 2;
		print ("Higher or lower than " + guessed_num + "?");
		print ("Press the Up arrow if Greater than " + guessed_num + ". Down if the number is lower, and return/enter if it is equal.");
		
	}
	
}
