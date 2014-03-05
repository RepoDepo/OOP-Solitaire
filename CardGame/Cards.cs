using System;

namespace CardGame
{
	class Cards
	{
		//variables
		private string name;
		private string number;
		private string color;
		private string suit;
		Boolean faceUp;

		public Cards(string name, string number, string color,
			string suit, Boolean faceUp)
		{
			this.name = name;
			this.number = number;
			this.color = color;
			this.suit = suit;
			this.faceUp = faceUp;

			if (name == "1.gif") {
				//A of clubs - black
				number = "A";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "10.gif") {
				//10 of clubs - black
				number = "10";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "2.gif") {
				//2 of clubs - black
				number = "2";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "3.gif") {
				//3 of clubs - black
				number = "3";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "4.gif") {
				//4 of clubs - black
				number = "4";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "5.gif") {
				//5 of clubs - black
				number = "5";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "6.gif") {
				//6 of clubs - black
				number = "6";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "7.gif") {
				//7 of clubs - black
				number = "7";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "8.gif") {
				//8 of clubs - black
				number = "8";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "9.gif") {
				//9 of clubs - black
				number = "9";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "11.gif") {
				//J of clubs - black
				number = "J";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "12.gif") {
				//K of clubs - black
				number = "K";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "13.gif") {
				//Q of clubs - black
				number = "Q";
				color = "black";
				suit = "club";
				faceUp = false;
			}
			if (name == "14.gif") {
				//A of diamonds - red
				number = "A";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "15.gif") {
				//10 of diamonds - red
				number = "10";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "16.gif") {
				//2 of diamonds - red
				number = "2";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "17.gif") {
				//3 of diamonds - red
				number = "3";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "18.gif") {
				//4 of diamonds - red
				number = "4";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "19.gif") {
				//5 of diamonds - red
				number = "5";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "20.gif") {
				//6 of diamonds - red
				number = "6";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "21.gif") {
				//7 of diamonds - red
				number = "7";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "22.gif") {
				//8 of diamonds - red
				number = "8";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "23.gif") {
				//9 of diamonds - red
				number = "9";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "24.gif") {
				//J of diamonds - red
				number = "J";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "25.gif") {
				//K of diamonds - red
				number = "K";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "26.gif") {
				//Q of diamonds - red
				number = "Q";
				color = "red";
				suit = "diamond";
				faceUp = false;
			}
			if (name == "27.gif") {
				//A of hearts - red
				number = "A";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "28.gif") {
				//10 of hearts - red
				number = "10";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "29.gif") {
				//2 of hearts - red
				number = "2";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "30.gif") {
				//3 of hearts - red
				number = "3";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "31.gif") {
				//4 of hearts - red
				number = "4";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "32.gif") {
				//5 of hearts - red
				number = "5";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "33.gif") {
				//6 of hearts - red
				number = "6";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "34.gif") {
				//7 of hearts - red
				number = "7";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "35.gif") {
				//8 of hearts - red
				number = "8";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "36.gif") {
				//9 of hearts - red
				number = "9";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "37.gif") {
				//J of hearts - red
				number = "J";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "38.gif") {
				//K of hearts - red
				number = "K";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "39.gif") {
				//Q of hearts - red
				number = "Q";
				color = "red";
				suit = "hearts";
				faceUp = false;
			}
			if (name == "40.gif") {
				//A of spades - black
				number = "A";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "41.gif") {
				//10 of spades - black
				number = "10";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "42.gif") {
				//2 of spades - black
				number = "2";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "43.gif") {
				//3 of spades - black
				number = "3";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "44.gif") {
				//4 of spades - black
				number = "4";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "45.gif") {
				//5 of spades - black
				number = "5";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "46.gif") {
				//7 of spades - black
				number = "7";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "47.gif") {
				//7 of spades - black
				number = "7";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "48.gif") {
				//8 of spades - black
				number = "8";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "49.gif") {
				//9 of spades - black
				number = "9";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "50.gif") {
				//J of spades - black
				number = "J";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "51.gif") {
				//K of spades - black
				number = "K";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
			if (name == "52.gif") {
				//Q of spades - black
				number = "Q";
				color = "black";
				suit = "spades";
				faceUp = false;
			}
		}

		public string getCardName()
		{
			return name;
		}

		public string getPathCard(){
			return "/Application/cards/" + name;
		}

		public string getDescription(){
			return name + "\n" + number + "\n" + color
				+ "\n" + suit + "\n" + faceUp;
		}

		public string getface(){
			return faceUp;
		}

		public void changeFace(Boolean newFace){
			if (newFace != faceUp) {
				newFace = faceUp;
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("testing!");
		}
	}
}
