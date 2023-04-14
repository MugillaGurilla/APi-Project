using System;
namespace ApiProject.DndApiServices.DataHandling.Models
{
    // Class here refers to a DnD class NOT (!!!) a C# class
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DndClassObject : IResponse
    {
        internal string index { get; set; }
        internal string name { get; set; }
        internal int hit_die { get; set; }
        internal List<ProficiencyChoice> proficiency_choices { get; set; }
        internal List<Proficiency> proficiencies { get; set; }
        internal List<SavingThrow> saving_throws { get; set; }
        internal List<StartingEquipment> starting_equipment { get; set; }
        internal List<StartingEquipmentOption> starting_equipment_options { get; set; }
        internal string class_levels { get; set; }
        internal MultiClassing multi_classing { get; set; }
        internal List<Subclass> subclasses { get; set; }
        internal Spellcasting spellcasting { get; set; }
        internal string spells { get; set; }
        internal string url { get; set; }
    }

    internal class AbilityScore
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Choice
    {
        public string desc { get; set; }
        public int choose { get; set; }
        public string type { get; set; }
        public From from { get; set; }
    }

    internal class Equipment
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class EquipmentCategory
    {
        public string name { get; set; }
        public string index { get; set; }
        public string url { get; set; }
    }

    internal class From
    {
        public string option_set_type { get; set; }
        public List<Option> options { get; set; }
        public EquipmentCategory equipment_category { get; set; }
    }

    internal class Info
    {
        public string name { get; set; }
        public List<string> desc { get; set; }
    }

    internal class Item
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Item2
    {
        public string option_type { get; set; }
        public Choice choice { get; set; }
        public int? count { get; set; }
        public Of of { get; set; }
    }

    internal class MultiClassing
    {
        public List<Prerequisite> prerequisites { get; set; }
        public List<Proficiency> proficiencies { get; set; }
    }

    internal class Of
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Option
    {
        public string option_type { get; set; }
        public Item item { get; set; }
        public List<Item> items { get; set; }
        public Choice choice { get; set; }
        public int? count { get; set; }
        public Of of { get; set; }
    }

    internal class Prerequisite
    {
        public AbilityScore ability_score { get; set; }
        public int minimum_score { get; set; }
    }

    internal class Proficiency
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class ProficiencyChoice
    {
        public string desc { get; set; }
        public int choose { get; set; }
        public string type { get; set; }
        public From from { get; set; }
    }


    internal class SavingThrow
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Spellcasting
    {
        public int level { get; set; }
        public SpellcastingAbility spellcasting_ability { get; set; }
        public List<Info> info { get; set; }
    }

    internal class SpellcastingAbility
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class StartingEquipment
    {
        public Equipment equipment { get; set; }
        public int quantity { get; set; }
    }

    internal class StartingEquipmentOption
    {
        public string desc { get; set; }
        public int choose { get; set; }
        public string type { get; set; }
        public From from { get; set; }
    }

    internal class Subclass
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }


}

