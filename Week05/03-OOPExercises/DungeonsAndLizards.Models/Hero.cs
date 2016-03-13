using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards.Models
{
    public class Hero : IComponents
    {
        private string name;
        private string title;
        private int health;
        private int currentHealth;
        private int mana;
        private int currentMana;
        private int manaRegenRate;
        private Weapon weapon;
        private Spell spell;
        private int attackPoints;

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
        }

        public int ManaRegenRate
        {
            get
            {
                return this.manaRegenRate;
            }
        }

        public Hero(string nameHero, string titleHero, int healthHEro, int manaHero, int manaRegenRateHero)
        {
            this.name = nameHero;
            this.title = titleHero;
            this.health = healthHEro;
            this.currentHealth = health;
            this.mana = manaHero;
            this.currentMana = mana;
            this.manaRegenRate = manaRegenRateHero;
            this.attackPoints = 0;
    }

    public string KnownAs()
        {
            return string.Format("{0} the {1}", this.name, this.title);
        }

        public int GetHealth()
        {
            return this.currentHealth;
        }

        public int GetMana()
        {
            return this.currentMana;
        }

        public bool IsAlive()
        {
            if (currentHealth <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CanCast()
        {
            int manaCost = 0;
            if (this.Spell != null)
            {
                manaCost = this.Spell.ManaCost;
            }
            if (this.currentMana < manaCost)
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
            this.currentHealth -= damageScore;
            if (this.currentHealth < 0)
            {
                this.currentHealth = 0;
            }
        }

        public bool TakeHealing(int healingPoints)
        {
            if (IsAlive())
            {
                if (GetHealth() < this.health)
                {
                    currentHealth += healingPoints;

                    if (this.currentHealth > this.health)
                    {
                        this.currentHealth = this.health;
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
            if (IsAlive() && GetMana() < this.mana)
            {
                this.currentMana += manaPoints;
                if (currentMana > this.mana)
                {
                    currentMana = this.mana;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void Learn(Spell spell)
        {
            this.spell = spell;
        }

        public int Attack(Weapon weapon)
        {
            if (this.weapon == null)
            {
                return 0;
            }
            else
            {
                return weapon.Damage;
            }
        }

        public int Attack(Spell spell)
        {
            if (spell == null || (this.mana - spell.ManaCost) < 0)
            {
                return 0;
            }
            else
            {
                this.mana -= spell.ManaCost;
                return spell.Damage;
            }
        }
    }
}
