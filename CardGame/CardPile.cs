using System;
using System.Collections.Generic;
using System.Collections;

namespace CardGame
{
	public abstract class CardPile
	{
		/*
		 * <summary>
		 * Type: abstract class
		 * This class contains common behavioral patterns <br>
		 * that can be used by other classes
		 */ 
		public CardPile () {}

		//will get count of cards
		public abstract int getCount ();

		//will determine if empty
		public abstract bool isEmpty ();

		//will add a card to the pile
		public abstract void AddToPile(Cards card);

		//will return last card in the pile
		public abstract Cards getLastCardInPile();

		//will deal next card in the pile and remove it from pile
		public abstract Cards dealACard();
	} 
}

