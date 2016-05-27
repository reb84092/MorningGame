using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MorningGame.View;

namespace MorningGame.Model
{
	class Player
	{	
		// Animation representing the player
		public Animation PlayerAnimation;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		public bool Active;

		// Amount of hit points that player has
		public int Health;

		// Get the width of the player ship
		public int Width
		{
			get { return PlayerAnimation.FrameWidth; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerAnimation.FrameHeight; }
		}		

		public void Initialize(Animation animation, Vector2 position)
	
		{
			PlayerAnimation = animation;

			Position = position;

			Active = true;

			Health = 100;
		}
			



		public void Update()
		{
		}

		public void Draw(SpriteBatch spriteBatch)
		{ 
			PlayerAnimation.Draw (spriteBatch);
		}

	}

}