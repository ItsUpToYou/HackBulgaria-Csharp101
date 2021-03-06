﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards.Models
{
    public class Weapon: ITreasure
    {
        private string name;
        private int damage;

        private int attack;
        private Hero hero;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
        }

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
}
