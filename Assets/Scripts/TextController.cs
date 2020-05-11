using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using States;


public class TextController : MonoBehaviour
{

    public Text text;
    
	private Context myState;

    private LanguageFactory languageFactory;

    private Language language;

    // Use this for initialization
    public void Start() {
        //initial state
        //Using design patterns to be easier to mantain and add more states and not violed the Open Closed principle
        //Abstract Factory design patter for help to the creation of different languages and the State design pattern to replace the enum state machine
        languageFactory = new LanguageFactory();
        // uncomment to starting using english
        language = languageFactory.getLanguage("english");
        // uncomment to starting using spanish
        //language = languageFactory.getLanguage("spanish");
        myState = new Context(language.getState("cell"));
        
        // without the language factory
        // using  only the state design pattern
        //myState = new Context(new Cell_EN());
    }

    // Update is called once per frame
    public void Update() {
        // Press 1 to switch to english
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            language = languageFactory.getLanguage("english");
            //print(myState.state.ToString());
            myState = new Context(language.getState(myState.state.ToString()));
        } // Press 2 to switch to spanish
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            language = languageFactory.getLanguage("spanish");
            myState = new Context(language.getState(myState.state.ToString()));
        }

        myState.Request();
        text.text = myState.state.story;
    }

}