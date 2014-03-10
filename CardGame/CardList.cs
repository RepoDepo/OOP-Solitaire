using System;
using System.Collections.Generic;
using System.Collections;

namespace CardGame
{
	/*
 	* This class has a List <br>
 	* to store our cards
 	*/
	public class CardList
	{
		//ArrayList to hold cards
		private List<Cards> cardList;

		public CardList ()
		{
			//default constructor
			//no cards in the pile
			cardList = new List<Cards> ();
		}

		/* <summary>
		 * Bool isEmpty method <br>
		 * Returns a count of 0
		 * </summary>
		 */
		public override bool isEmpty ()
		{
			return cardList.Count == 0;
		}

		/* <summary>
		 * Adds a card to the pile
		 * @param: Cards card
		 * </summary>
		 */ 
		public override void AddToPile (Cards card)
		{
			if (cardList.Count == 0) {
				cardList.Add (card);
			} else {
				throw new NotImplementedException ();
			}
		}

		/* <summary>
		 * Get the bottom face up card
		 * </summary>
		 */ 
		public static string getBottomFaceUp(Cards c)
		{
			return cardList.RemoveAt (0);
		}

		/* <summary>
		 * Get the top face up card
		 * </summary>
		 */
		public static void getTopFaceUp(Cards c)
		{
			return cardList[cardList.Count - 1];
		}

		/* <summary>
		 * Removes the top face card and deals the next
		 * </summary>
		 */
		public void removetopFaceUpCard()
		{
			//remove at first index
			cardList.RemoveAt (0);
		}

		/* <summary>
		 * This method will accept a card <br>
		 * A card will be inserted at the first <br>
		 * position of a list
		 * </summary>
		 */
		public void acceptCard(Cards card)
		{
			if (cardList.Count != 0) {
				cardList.Insert (0, card);
			} else {
				AddToPile (card);
			}
		}

		/* <summary>
		 * Get total of all cards in the pile
		 * </summary>
		 */ 
		public override string getCount ()
		{
			return "There are " + (int)cardList.Count + "cards on the pile";
		}


	}
}

