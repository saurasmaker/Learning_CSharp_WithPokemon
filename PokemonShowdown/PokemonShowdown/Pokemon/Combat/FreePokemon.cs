﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonShowdown.Pokemon
{
    class FreePokemon : OPokemon
    {
        #region Attributes

        private byte genre;
        private byte nature;
        private byte[] iVs;

        private PokeMove[] actualMoves; //
        private List<byte> learnedMoves; //Moves Id. Movements that the pokémon has learned throughout its life.
        private List<byte> willLearnByLevel; //Moves Id. 100 position vector. Each position represents a level. The number stored within each position represents the move the Pokémon will learn at that level.
        private List<byte> eggMoves; //Moves Id. Movements that the pokémon can learn by breeding.
        private List<byte> canLearnMoves; //Moves Id. Movements that the pokémon can learn byt MT or a tutor. 

        public bool Shyni { get; set; }
        
        #endregion




        #region Constructors
        public FreePokemon()
        {

        }


        #endregion



        #region Getters & Setters
        public byte[] IVs
        {
            get { return iVs; }
            set
            {
                for (byte i = 0; 0 < 5; ++i)
                    if (value[i] > 255)
                    {
                        Console.WriteLine("Not valid EVs {0} in position {1}", PokeStat.StatsNames[i], i);
                        return;
                    }
                    else iVs[i] = value[i];

            }
        }

        public byte Genre
        {
            get { return genre; }
            set {
                if (value < 2) genre = value;
                else genre = 0;      
            }
        }
        public byte Nature
        {
            get { return nature; }
            set {
                if (value < 25) nature = value;
                else nature = 0;      
            }
        }

        public PokeMove[] ActualMoves
        {
            get { if (actualMoves == null) actualMoves = new PokeMove[4]; return actualMoves; }
            set { actualMoves = value; }
        }




        #endregion
    }
}
