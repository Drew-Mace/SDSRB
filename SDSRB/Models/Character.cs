using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDSRB.Pages
{

    [Table("CharactersTB")]
    public class Character
    {
       
        [Key]
        public int CharacterID { get; set; }
        // character name, orginaztion, background info
        public string Name { get; set; } 
        public string Org { get; set; }
        public string Background { get; set; }

        // Attributes
        public int Dexterity { get; set; }
        public int Resilience { get; set; }
        public int Intelligence { get; set; }
        public int Influence { get; set; }
        public int Poise { get; set; }
        public int Strength { get; set; }

        // need class (class/talent archetype)
        public string Class { get; set; }
        //use int for achetype (each class with have 1-n for archetype/ so it would be Assassin for class and 1 for rogue etc..)
        public int Archetype { get; set; }
        // inventory
        //skills (this could be handled by the attributes??)
        //skills may need to be it own thing, then they can be looped through)

    }
}
