using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class recognition : MonoBehaviour
{

    public static KeywordRecognizer keywordRecognizer;
	public int number;
	public static string correctNumber;
	public static bool activatedestruction;
	public static int count = 0;  
	public static Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
	public static int first_entry = 0;
	public bool complete; 

	public void Start()
	{

		if (first_entry == 0) { 
			//ersätt Random.range() med det specifika "answer" int'en

			//Debug.Log (keywords.ToList();
			//keywords.Clear();
			//keywords.Remove (correctNumber);
			for (int i = 0; i <= 100; i++) {
				string parsedNumber = NumberToWords (i);
				keywords.Add (parsedNumber, () => {
					Debug.Log ("Done"); 
					GoCalled ();

				});
			}
			keywordRecognizer = new KeywordRecognizer (keywords.Keys.ToArray ());
			keywordRecognizer.OnPhraseRecognized += keywordRecognizerOnphraseRecognized;
			keywordRecognizer.Start ();
		}



		//if (ChangeColor.first_entry == 0) {
		//	keywordRecognizer.Stop ();
		//}

		first_entry = first_entry + 1;

	}

    void keywordRecognizerOnphraseRecognized(PhraseRecognizedEventArgs args)
    {
		correctNumber = NumberToWords(ChangeColor.answer); 
        System.Action keywordAction;

		Debug.Log ("I heard: " + args.text);
		Debug.Log ("Correct is: " + correctNumber);

		if (keywords.TryGetValue (args.text, out keywordAction)) {
			Debug.Log ("complete");
			if (args.text == correctNumber) {

				//activatedestruction = false;
				keywordAction.Invoke ();

			} else {
				Debug.Log ("wrong answer");
			}
		} else {
			Debug.Log("Word not recognized");
		}
    }

    void GoCalled()
    {
        //gör ngt när rätt svar finns.
		print(ChangeColor.answer +" is correct");
		activatedestruction = true;

		GameObject.DestroyObject(ChangeColor.g);

		count += 1; 


    }

    public static string NumberToWords(int number)
    {

		string words = "";

		if (number == 0) {
			return "zero";
		}

		/*
        if (number < 0)
            return "minus " + NumberToWords(System.Math.Abs(number));

        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }
		*/
        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }
		

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }

	public static void StopKeywordRecognizer(){
		//keywordRecognizer.Stop();
	}

}
