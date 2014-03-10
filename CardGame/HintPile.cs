using System;
using System.Collections.Generic;
using System.Collections;

namespace CardGame
{
	public class HintPile:CardPile
	{
		private List<Cards> pile = new List<Cards>();
		public HintPile ()
		{
			//default constructor
			//no cards in the pile
		}

		/* <summary>
		 * Bool isEmpty method <br>
		 * Returns a count of 0
		 * </summary>
		 */
		public override bool isEmpty ()
		{
			return pile.Count == 0;
		}

		/* <summary>
		 * Adds a card to the pile
		 * @param: Cards card
		 * </summary>
		 */ 
		public override void AddToPile (Cards card)
		{
			if (pile.Count == 0) {
				pile.Add (card);
			} else {
				throw new NotImplementedException ();
			}
		}

		/* <summary>
		 * Get total of all cards in the pile
		 * </summary>
		 */ 
		public override int getCount ()
		{
			return "There are " + pile.Count + "cards on the pile";
		}

		/* <summary>
		 * Get the last card from the pile
		 * </summary>
		 */ 
		public override Cards getLastCardInPile ()
		{
			return pile [pile.Count - 1];
			//throw new NotImplementedException ();
		}

		/* <summary>
		 * Deals next card from the pile
		 * Also return next card from the list <br>
		 * essentially removing it from the list
		 * </summary>
		 */ 
		public override Cards dealACard ()
		{
			Cards card = pile [0];
			pile.RemoveAt (0);
			return card;
		}
	}
}

