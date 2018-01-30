using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {Beggining, Encounter, Pokeball_1, Berry, Wait_1, Happy_Riolu, Wait_2, Pokeball_2, Caught,
						Stage_2_I, Stage_2_Q, Training, Battle_1, Pokecenter_1, Evolve, Training_1, Gym, Battle_2, Pokecenter_2, Pokecenter_3, Quick_Attack, Protect, Aura_Sphere, Victory};
	private States myState;
	int Riolu_HP = 3;
	int Happiness = 0;
	bool UseProtect = false;
	
	// Use this for initialization
	void Start () {
		myState = States.Beggining;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.Beggining) 		{Beggining ();}
		else if (myState == States.Encounter) 		{Encounter ();}
		else if (myState == States.Pokeball_1) 		{Pokeball_1();}
		else if (myState == States.Wait_1) 			{Wait_1();}
		else if (myState == States.Berry) 			{Berry();}
		else if (myState == States.Happy_Riolu) 	{Happy_Riolu();}
		else if (myState == States.Wait_2) 			{Wait_2();}
		else if (myState == States.Pokeball_2) 		{Pokeball_2();}
		else if (myState == States.Caught) 			{Caught();}
		else if (myState == States.Stage_2_I) 		{Stage_2_I();}
		else if (myState == States.Stage_2_Q) 		{Stage_2_Q();}
		else if (myState == States.Training) 		{Training();}
		else if (myState == States.Battle_1) 		{Battle_1();}
		else if (myState == States.Pokecenter_1) 	{Pokecenter_1();}
		else if (myState == States.Evolve) 			{Evolve();}
		else if (myState == States.Training_1) 		{Training_1();}
		else if (myState == States.Gym) 			{Gym();}
		else if (myState == States.Battle_2) 		{Battle_2();}
		else if (myState == States.Pokecenter_2) 	{Pokecenter_2();}
		else if (myState == States.Pokecenter_3) 	{Pokecenter_3();}
		else if (myState == States.Quick_Attack) 	{Quick_Attack();}
		else if (myState == States.Protect) 		{Protect();}
		else if (myState == States.Aura_Sphere) 	{Aura_Sphere();}
		else if (myState == States.Victory) 		{Victory();}
	}
	
	void Beggining () {
		Riolu_HP = 3;
		Happiness = 0;
		UseProtect = false;
		text.text = "There you were, on a calm afternoon, looking for a wild Riolu, " +
					"when, suddenly, you catch a glimpse of a dazzling light coming from the corner of your eye.\n" +
					"You decide to follow it, wondering what it " +
					"could be.\n\n'What the... ?' A SHINY RIOLU!!!\n\n" +
					"Press C to continue";
		if (Input.GetKeyDown (KeyCode.C)) {myState = States.Encounter;}
	}
					
	void Encounter() {
		text.text = "You finally found a Riolu, and a shiny one! In your bag there are pokeballs " +
					"and berries. What do you do?\n\n" +
					"Press P for Pokeball; B for Berry; W to Wait";
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.Pokeball_1;}
		if (Input.GetKeyDown (KeyCode.W)) {myState = States.Wait_1;}
		if (Input.GetKeyDown (KeyCode.B)) {myState = States.Berry;}		
	}
	void Pokeball_1() { 
		text.text = "You grab your pokeball and look at it. For some reason, professor Maple's words " +
					"appear in your head. 'Don't you even think of throwing the ball the moment you " +
					"see a pokemon! First, you need to weaken of befriend it!'\n\n" +
					"Press R to put it back";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Encounter;} 
	}
	void Berry() {
		text.text = "According to professor Maple, this is Riolu's favorite snack. You decide to offer it, hoping " +
					"to befriend the pokemon.\n\n" +
					"Press A to approach; R to put it back";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Encounter;}
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.Happy_Riolu;}  
	}
	void Wait_1() {
		text.text = "You decide to wait for an opportunity. Afterall, you can't spoil this unique chance.\n\n" +
					"Press R if you are ready";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Encounter;} 
	}
	void Happy_Riolu() {
		text.text = "Altough hesitant at first, the Riolu gladly accepts your offer. You notice a huge smile on his face. " +
					"The plan was a success! What do you do now?\n\n" +
					"Press P for Pokeball; W to Wait";
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.Pokeball_2;}
		if (Input.GetKeyDown (KeyCode.W)) {myState = States.Wait_2;}  
	}
	void Wait_2() {
		text.text = "You hesitate out of excitement. There is only one thing left to do now.\n\n" +
					"Press R if you are ready";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Happy_Riolu;} 
	}
	void Pokeball_2() {
		text.text = "You take a final look at your pokeball. This is it, the moment you were waiting for. You are ready.\n\n" +
					"Press T to throw the Pokeball";
		if (Input.GetKeyDown (KeyCode.T)) {myState = States.Caught;} 
	}
	void Caught() {
		text.text = "Riolu was so happy it let itself get caught. Congratulations! You got a Shiny Riolu! \n\n" +
					"Press C to continue your adventure";
		if (Input.GetKeyDown (KeyCode.C)) {myState = States.Stage_2_I;} 
	}
	void Stage_2_I() {
		text.text = "Having caught your Riolu, you return home to tell everyone about it. After talking with professor Maple, you begin to question yourself.\n" + 
					"'What should I do now?\n" + "Professor Maple! Can I ask you a question?'\n\n" + 
					"Press T to talk with Professor Maple";
		if (Input.GetKeyDown (KeyCode.T)) {myState = States.Stage_2_Q;} 
	}
	void Stage_2_Q() {
		text.text = "'Hum... That's it! You should challenge Axel, the town's Gym Leader!\n" + "However, you aren't strong enough yet.\n" + 
					"Why don't you go train your Riolu and evolve it into a Lucario first?'\n" + "Be careful not to overtrain! Riolu won't evolve if you let him faint!'\n\n" +
					"Press L to look for a place to train";
		if (Input.GetKeyDown (KeyCode.L)) {myState = States.Training;} 
	}
	void Training() {
		if (Happiness == 5) {myState = States.Evolve;}
		else { text.text = "You find a place swarming with pokemon, also noticing a Pokemon Center nearby. It's the perfect spot to train! What do you do?\n\n" +
							"Riolu's HP: " + Riolu_HP + "\n" + "Riolu's Happiness: " + Happiness + "\n\n" + 
							"Press B to Battle; P to visit the Pokemon Center";
				if (Input.GetKeyDown (KeyCode.B)) {myState = States.Battle_1;}
				if (Input.GetKeyDown (KeyCode.P)) {myState = States.Pokecenter_1;}
			}
	}
	void Pokecenter_1() {
		text.text = "You visit the Pokemon Center. Nurse Joy takes your Riolu and heals it back to perfect health. Ready to battle!\n\n" +
					"Press R to return to the training spot";
		Riolu_HP = 3;
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Training;} 
	}
	void Battle_1() {
		if (Riolu_HP == 3) {text.text = "Riolu is animated, easily overcoming its opponent. You shout to encourage it, even though it seems there is no need...\n\n" +
							"Press R to return to the training spot"; }
		if (Riolu_HP == 2) {text.text = "Altough still lively and stronger than it's foe, you notice Riolu is a bit tired. Maybe he should rest before battling again...\n\n" + 
							"Press R to return to the training spot"; }
		if (Riolu_HP == 1) {text.text = "Riolu tries it's best not to let you down. However, after defeating it's enemy, he also faints.\n\n" + 
							"Press R to return to the training spot"; 
							Happiness = (-1); }
		if (Riolu_HP == 0) {text.text = "Riolu is in no condition to battle! Take it to the nearest Pokemon Center!\n\n" + 
							"Press R to return to the training spot";
							Happiness = (-1); }
		if (Input.GetKeyDown (KeyCode.R)) {
				if (Riolu_HP == 0) {Riolu_HP = 1; myState = States.Training; Riolu_HP = Riolu_HP - 1; Happiness = Happiness + 1;}
				else {myState = States.Training; Riolu_HP = Riolu_HP - 1; Happiness = Happiness + 1;}
		} 
	}
	void Evolve() {
		text.text = "Hm...? What is this light? Can it be?\n\n" + "Congratulations! Your Riolu evolved into a Lucario!\n\n" + "You are now ready to challenge Axel!\n\n" +
					"Press C to continue";
		if (Input.GetKeyDown (KeyCode.C)) {myState = States.Training_1;} 
	}
	void Training_1() {
		text.text = "Your objective here is completed, Riolu has evolved into Lucario. What do you do?\n\n" +
					"Press C to challenge the Gym Leader; B to Battle; P to visit the Pokemon Center";
		if (Input.GetKeyDown (KeyCode.C)) {myState = States.Gym;}
		if (Input.GetKeyDown (KeyCode.B)) {myState = States.Battle_2;} 
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.Pokecenter_2;} 
	}
	void Battle_2() {
		text.text = "Lucario seems bored, easily overpowering his opponents. Maybe you should try to give him a challenge!\n\n" + 
					"Press R to return to the training spot";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Training_1;} 
	}
	void Pokecenter_2() {
		text.text = "You visit the Pokemon Center. Nurse Joy takes your Lucario and heals it back to perfect health. Ready to face Axel!\n\n" +
					"Press R to return to the training spot";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Training_1;} 
	}
	void Gym() {
		text.text = "You and Lucario arrive at the Gym, eager to meet the Gym Leader. It is time to battle!\n\nAxel sents out a Steelix!\n\n'Lucario, use ...\n\n" +
					"... Protect!' (P)\n... Quick Attack!' (Q)\n... Aura Sphere!' (A)";
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.Protect;}
		if (Input.GetKeyDown (KeyCode.Q)) {myState = States.Quick_Attack;} 
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.Aura_Sphere;}
	}
	void Pokecenter_3() {
		text.text = "You visit the Pokemon Center. Nurse Joy takes your Lucario and heals it back to perfect health. Ready to face Axel!\n\n" +
				"Press C to challenge the Gym Leader";
		UseProtect = false;
		if (Input.GetKeyDown (KeyCode.C)) {myState = States.Gym;} 
	}
	void Quick_Attack() {
		text.text = "Lucario used Quick Attack!\nIt's not very effective...\n\nSteelix used Earthquake!\nIt was super effective!\nLucario fainted.\n\n" +
					"Press P to visit the Pokemon Center";
		if (Input.GetKeyDown (KeyCode.P)) {myState = States.Pokecenter_3;} 
	}
	void Protect() {
		if (UseProtect == false) {
			text.text = "Lucario uses Protect!\n\nSteelix uses Earthquake!\nLucario protected itself!\n\n" + 
						"Press Q for Quick Attack; P for Protect; A for Aura Sphere";
			if (Input.GetKeyDown (KeyCode.Q)) {myState = States.Quick_Attack;}
			if (Input.GetKeyDown (KeyCode.P)) {UseProtect = true; myState = States.Protect;}
			if (Input.GetKeyDown (KeyCode.A)) {myState = States.Aura_Sphere;} 
		}
		else {
			text.text = "Lucario uses Protect! But it failed!\n\nSteelix uses Earthquake!\nIt was super effective!\nLucario fainted.\n\n" +
						"Press P to visit the Pokemon Center";
			if (Input.GetKeyDown (KeyCode.P)) {myState = States.Pokecenter_3;}
		}
	}
	void Aura_Sphere() {
		text.text = "Lucario uses Aura Sphere!\nA critical hit!\nIt's super effective!\nSteelix fainted!\n\nYou won against Gym Leader Axel!\n\n" +
					"Press R to receive your Gym Badge";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Victory;} 
	}
	void Victory() {
		text.text = "Axel awards you with the Ground Badge. Congratulations! You are now the town's strongest trainer!\n\nEveryone admires and praises you, " +
					"as if there was nothing else to do now. Little did they know your adventure throughout the world just began!\n\n" +
					"Press R to restart the game";
		if (Input.GetKeyDown (KeyCode.R)) {myState = States.Beggining;} 
	}
}