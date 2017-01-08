using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class recognition : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    public int number;
	public static bool activatedestruction;
	public static int count = 0;  
	Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    public void Start()
    {
        //ersätt Random.range() med det specifika "answer" int'en
		string correctNumber = NumberToWords(ChangeColor.answer);
		Debug.Log ("start");

		//Debug.Log (keywords.ToList();
		keywords.Clear();
		//keywords.Remove (correctNumber);
		keywords.Add(correctNumber, () =>
        {
			Debug.Log ("Done"); 
			activatedestruction = false;

            GoCalled();
        });

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += keywordRecognizerOnphraseRecognized;
        keywordRecognizer.Start();
    }

    void keywordRecognizerOnphraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }

    void GoCalled()
    {
        //gör ngt när rätt svar finns.
		print(ChangeColor.answer +" is correct");
		keywords.Clear ();
		activatedestruction = true;

		GameObject.DestroyObject(ChangeColor.g);

		count = count + 1; 

    }

    public static string NumberToWords(int number)
    {

        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(System.Math.Abs(number));

        string words = "";

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

}
