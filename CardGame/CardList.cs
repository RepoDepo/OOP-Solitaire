using System;
using System.Collections;
/*
 * This class has a List <br>
 * to store our cards
 */

namespace CardGame
{
	public class CardList
	{
		//ArrayList to hold cards
		private List<Cards> cardList;

		//get bottom faceup
		//get bottom FaceUp
		//get top faceUp
		//get bottom faceUp


		public CardList ()
		{
			cardList= new List<Cards>();
		}

		public void addCard(Cards c)
		{
			cardList.add (c);
		}

		public string getBottomFaceUp()
		{

		}

		public string getBottomFaceDown()
		{

		}

		public string getTopFaceUp()
		{

		}
		public string getBottomFaceDown()
		{

		}




	}
}

