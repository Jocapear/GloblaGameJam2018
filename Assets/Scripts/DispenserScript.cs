using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenserScript : MonoBehaviour {


	//DICTIONARY
	Dictionary<int, bool[]> myDictionary = new Dictionary<int, bool[]>();
        
    //END OF DICTIONARY 


	bool[][] code;
	int currentCount,currentLetter;
	string word;
	public GameObject text, explotion;

	// Use this for initialization
	void Start () {
		myDictionary.Add (1, new bool[2] {true,false} );
        myDictionary.Add (2, new bool[4] {false,true,true,true} );
        myDictionary.Add (3, new bool[4] {false,true,false,true} );
        myDictionary.Add (4, new bool[3] {false,true,true} );
        myDictionary.Add (5, new bool[1] {true} );
        myDictionary.Add (6, new bool[4] {true,true,false,true} );
        myDictionary.Add (7, new bool[3] {false,false,true} );
        myDictionary.Add (8, new bool[4] {true,true,true,true} );
        myDictionary.Add (9, new bool[2] {true,true} );
        myDictionary.Add (10, new bool[4] {true,false,false,false} );
        myDictionary.Add (11, new bool[3] {false,true,false} );
        myDictionary.Add (12, new bool[4] {true,false,true,true} );
        myDictionary.Add (13, new bool[2] {false,false} );
        myDictionary.Add (14, new bool[2] {false,true} );
        myDictionary.Add (15, new bool[3] {false,false,false} );
        myDictionary.Add (16, new bool[4] {true,false,false,true} );
        myDictionary.Add (17, new bool[4] {false,false,true,false} );
        myDictionary.Add (18,new bool[3] {true,false,true} );
        myDictionary.Add (19, new bool[3] {true,true,true} );
        myDictionary.Add (20, new bool[1] {false} );
        myDictionary.Add (21, new bool[3] {true,true,false} );
        myDictionary.Add (22, new bool[4] {true,true,true,false} );
        myDictionary.Add (23, new bool[3] {true,false,false} );
        myDictionary.Add (24, new bool[4] {false,true,true,false} );
        myDictionary.Add (25, new bool[4] {false,true,false,false} );
        myDictionary.Add (26, new bool[4] {false,false,true,true} );

		code = new bool [Random.Range(1,6)][];
		word = "";
		FillCode();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnColissionEnter(Collision c)
    {


	}

	void FillCode(){
		for (int i = 0; i < code.Length; i ++){
			int rdmLetter = Random.Range(1, 27);
			bool[] tmp = myDictionary[rdmLetter];
			code[i] = tmp;
			word += FillWord(rdmLetter);
		}
		currentLetter = 0;
		currentCount = 0;
		text.GetComponent<DispenserTextScript>().SetText(word);
	}

	public void EnterSignal(bool signal){
		if(code[currentCount][currentLetter] == signal){
			currentLetter++;
			if (currentLetter >= code[currentCount].Length){

				currentCount += 1;
				currentLetter = 0;
                eraseLetter();
                text.GetComponent<DispenserTextScript>().SetText(word);
            }
			if (currentCount >= code.Length){

                GameObject particle = Instantiate(explotion);
                particle.transform.position = text.transform.position;
				currentCount = 0;
                Destroy(gameObject);
                Destroy(particle, 3.0f);
			}
		}
		else{
			currentLetter = 0;
			Debug.Log("Mal");
		}
			
	}

	string FillWord(int number){
		if (number==1)
			return ("A");
		else if (number==2)
			return ("B");
		else if (number==3)
			return ("C");
		else if (number==4)
			return ("D");
		else if (number==5)
			return ("E");
		else if (number==6)
			return ("F");
		else if (number==7)
			return ("G");
		else if (number==8)
			return ("H");
		else if (number==9)
			return ("I");
		else if (number==10)
			return ("J");
		else if (number==11)
			return ("K");
		else if (number==12)
			return ("L");
		else if (number==13)
			return ("M");
		else if (number==14)
			return ("N");
		else if (number==15)
			return ("O");
		else if (number==16)
			return ("P");
		else if (number==17)
			return ("Q");
		else if (number==18)
			return ("R");
		else if (number==19)
			return ("S");
		else if (number==20)
			return ("T");
		else if (number==21)
			return ("U");
		else if (number==22)
			return ("V");
		else if (number==23)
			return ("W");
		else if (number==24)
			return ("X");
		else if (number==25)
			return ("Y");
		else
			return ("Z");
		
	}

    void eraseLetter()
    {
        string temp = word;
        word = "";
        for (int i = 0; i < temp.Length; i++)
        {
            if (i != 0)
            {
                word += temp[i];
            }
        }
    }


}
