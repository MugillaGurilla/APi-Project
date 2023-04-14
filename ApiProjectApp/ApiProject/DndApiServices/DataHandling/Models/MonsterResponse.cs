using System;
namespace ApiProject.DndApiServices.DataHandling.Models
{
    public class MonsterObject : IResponse
    {
        public string index { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string alignment { get; set; }
        public List<ArmorClass> armor_class { get; set; }
        public int hit_points { get; set; }
        public string hit_dice { get; set; }
        public string hit_points_roll { get; set; }
        public Speed speed { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public List<Proficiency> proficiencies { get; set; }
        public List<object> damage_vulnerabilities { get; set; }
        public List<object> damage_resistances { get; set; }
        public List<string> damage_immunities { get; set; }
        public List<object> condition_immunities { get; set; }
        public Senses senses { get; set; }
        public string languages { get; set; }
        public int challenge_rating { get; set; }
        public int xp { get; set; }
        public List<SpecialAbility> special_abilities { get; set; }
        public List<Action> actions { get; set; }
        public List<LegendaryAction> legendary_actions { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    public class Action
    {
        public string name { get; set; }
        public string multiattack_type { get; set; }
        public string desc { get; set; }
        public List<Action> actions { get; set; }
        public int? attack_bonus { get; set; }
        public List<Damage> damage { get; set; }
        public Dc dc { get; set; }
        public Usage usage { get; set; }
        public string action_name { get; set; }
        public int count { get; set; }
        public string type { get; set; }
    }

    public class ArmorClass
    {
        public string type { get; set; }
        public int value { get; set; }
    }

    public class Damage
    {
        public DamageType damage_type { get; set; }
        public string damage_dice { get; set; }
    }

    public class DamageType
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Dc
    {
        public DcType dc_type { get; set; }
        public int dc_value { get; set; }
        public string success_type { get; set; }
    }

    public class DcType
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class LegendaryAction
    {
        public string name { get; set; }
        public string desc { get; set; }
        public Dc dc { get; set; }
        public List<Damage> damage { get; set; }
    }

    public class Proficiency
    {
        public int value { get; set; }
        public Proficiency proficiency { get; set; }
    }

    public class Proficiency2
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }


    public class Senses
    {
        public string blindsight { get; set; }
        public string darkvision { get; set; }
        public int passive_perception { get; set; }
    }

    public class SpecialAbility
    {
        public string name { get; set; }
        public string desc { get; set; }
        public Usage usage { get; set; }
    }

    public class Speed
    {
        public string walk { get; set; }
        public string fly { get; set; }
        public string swim { get; set; }
    }

    public class Usage
    {
        public string type { get; set; }
        public int times { get; set; }
        public List<object> rest_types { get; set; }
        public string dice { get; set; }
        public int min_value { get; set; }
    }
}

