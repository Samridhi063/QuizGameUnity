using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour {

	public Text answerText;    
	private AnswerData answerData;
	private GameController gameController;
    
    // Use this for initialization
    void Start () 
	{
		gameController = FindObjectOfType<GameController> ();
	}
	public void Setup(AnswerData data)
	{
		answerData = data;
		answerText.text = answerData.answerText;
	}
	public void HandleClick()
	{
        ColorBlock cb = GetComponent<Button>().colors;
        Debug.Log(answerData.isCorrect);
        if (answerData.isCorrect)
        {
            Debug.Log("green");
            cb.pressedColor = Color.green;
            GetComponent<Button>().colors = cb;
        }
        else if (!answerData.isCorrect)
        {
            Debug.Log("red");
            cb.pressedColor = Color.red;
            GetComponent<Button>().colors = cb;
        }
		gameController.AnswerButtonClicked (answerData.isCorrect);        

	}
}