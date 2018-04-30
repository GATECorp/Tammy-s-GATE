using UnityEngine;
using system

namespace perso
{
    public class Character
    {
        public enum Charactertype
        {
            FIRE,
            WATER,
            EARTH,
            AIR
        };
        
        public enum Surfacedisplacementtype
        {
            WATER,
            EARTH
        }; 

        private Charactertype charactertype;
        private int damage;
        private int level;
        //public int life;
        private bool isKO;
        private string name;
        private Surfacedisplacementtype _surfacedisplacementtype;
        private GameObject player;
        public Vector3 position;
        
        public Character(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
        
        public Character(string name, int life, int damage, Charactertype charactertype)
        {
            this.charactertype = charactertype;
            this.life = life;
            this.damage = damage;
            isKO = false;
            level = 1;
        }

        public bool IsKO
        {
            get { return isKO; }
        }

        public int Life
        {
            get { return life; }
        }
        
        public void GetHurt(int damage)
        {
            life = life - damage;
            if (life <= 0)
            {
                isKO = true;
                life = 0;
            }
        }
        
        public void Heal(int life)
        {
            this.life = life;
            isKO = false;
        }

        public bool CanMoveInWater()
        {
            return _surfacedisplacementtype == Surfacedisplacementtype.WATER && charactertype == Charactertype.WATER;
        }
        
        
    }
}