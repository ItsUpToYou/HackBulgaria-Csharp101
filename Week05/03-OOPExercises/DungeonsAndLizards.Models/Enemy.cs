using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards.Models
{
    public class Enemy : IComponents
    {
        private int health;
        private int currHealth;
        private int mana;
        private int damage;
        private Weapon weapon;
        private Spell spell;

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
        }

        public Spell Spell
        {
            get
            {
                return this.spell;
            }
            set
            {
                this.spell = value;
            }
        }
        public Enemy(int healthEnemy, int manaEnemy, int damageEnemy)
        {
            this.health = healthEnemy;
            this.currHealth = healthEnemy;
            this.mana = manaEnemy;
            this.damage = damageEnemy;
        }

        public int Attack(Spell spell)
        {
            if (spell == null )
            {
                return this.damage ;
            }
            else
            {
                this.mana -= spell.ManaCost;
                return spell.Damage;
            }
        }

        public int Attack(Weapon weapon)
        {
            if (this.weapon == null)
            {
                return this.damage;
            }
            else
            {
                return weapon.Damage;
            }
        }

        public bool CanCast()
        {
            int manaCost = 0;
            if (this.Spell != null)
            {
                manaCost = this.Spell.ManaCost;
            }
            if (this.mana < manaCost)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetHealth()
        {
            return this.currHealth;
        }

        public int GetMana()
        {
            return this.mana;

        }

        public bool IsAlive()
        {
            if (this.currHealth <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void TakeDamage(int damageScore)
        {
            this.currHealth -= damageScore;
            if (this.currHealth < 0)
            {
                this.currHealth = 0;
            }
        }

        public bool TakeHealing(int healingPoints)
        {
            if (IsAlive())
            {
                if (GetHealth() < this.health)
                {
                    currHealth += healingPoints;

                    if (this.currHealth > this.health)
                    {
                        this.currHealth = this.health;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TakeMana(int manaPoints)
        {
            throw new NotImplementedException();
        }
    }
}
