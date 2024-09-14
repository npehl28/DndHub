using System;
using System.Collections.Generic;
using System.Linq;
using DndHubApi.Data;
using DndHubApi.Models; // Adjust the namespace to match your project
using DndHubApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DndHubApi.Data
{
    public interface IDbSeeder
    {
        Task AsyncSeedDatabase();
    }

    public class DbSeeder : IDbSeeder
    {
        private readonly RaceDbContext _context;

        public DbSeeder(RaceDbContext context)
        {
            _context = context;
        }

        public async Task AsyncSeedDatabase()
        {
            // Clear the database
            Console.WriteLine("\n\n\n Begining Seeding Proccess!");

            try
            {
                _context.Database.ExecuteSqlRaw("DELETE FROM Subraces");
                _context.Database.ExecuteSqlRaw("DELETE FROM Races");
                _context.Database.ExecuteSqlRaw("DELETE FROM ASIs");
                _context.Database.ExecuteSqlRaw("DELETE FROM Traits");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Database has been cleared!");

            Console.WriteLine("Seeded 5e Races...");

            await AddRaces();

            Console.WriteLine("Database has been seeded successfully!\n\n\n");
        }

        private async Task AddRaces()
        {
            await AddDragonborn();
            await AddDwarf();
            await AddElf();
            await AddGnome();
            await AddHalfElf();
            await AddHalfOrc();
            await AddHuman();
            await AddVariantHuman();
            await AddTiefling();
        }

        private async Task AddDragonborn()
        {
            /*
            * ===== Dragonborn Traits =====
            */

            //Main Race

            var TraitAge = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Age",
                Description =
                    "Young dragonborn grow quickly. They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach adulthood by 15. They live to be around 80.",
            };

            var TraitAllignment = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Alignment",
                Description =
                    "Dragonborn tend towards extremes, making a conscious choice for one side or the other between Good and Evil (represented by Bahamut and Tiamat, respectively). More side with Bahamut than Tiamat (whose non-dragon followers are mostly kobolds), but villainous dragonborn can be quite terrible indeed. Some rare few choose to devote themselves to lesser dragon deities, such as Chronepsis (Neutral), and fewer still choose to worship Io, the Ninefold Dragon, who is all alignments at once.",
            };

            //Black Dragonborn Traits

            var TraitBlackDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to black dragons. You have resistance to acid damage.",
            };

            var TraitBlackBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 5 by 30 ft. line. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 acid damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Blue Dragonborn Traits

            var TraitBlueDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to blue dragons. You have resistance to lightning damage.",
            };

            var TraitBlueBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 5 by 30 ft. line. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 lightning damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Brass Dragonborn Traits

            var TraitBrassDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to brass dragons. You have resistance to fire damage.",
            };

            var TraitBrassBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 5 by 30 ft. line. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 fire damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Bronze Dragonborn Traits

            var TraitBronzeDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to Bronze dragons. You have resistance to lightning damage.",
            };

            var TraitBronzeBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 5 by 30 ft. line. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 lightning damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Copper Dragonborn Traits

            var TraitCopperDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to copper dragons. You have resistance to acid damage.",
            };

            var TraitCopperBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 5 by 30 ft. line. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 acid damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Gold Dragonborn Traits

            var TraitGoldDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to gold dragons. You have resistance to fire damage.",
            };

            var TraitGoldBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 15 ft. cone. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 fire damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Green Dragonborn Traits

            var TraitGreenDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to green dragons. You have resistance to poison damage.",
            };

            var TraitGreenBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 15 ft. cone. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 poison damage on a failed Constitution Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Red Dragonborn Traits

            var TraitRedDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description = "You are related to red dragons. You have resistance to fire damage.",
            };

            var TraitRedBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 15 ft. cone. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 fire damage on a failed Dexterity Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //Silver Dragonborn Traits

            var TraitSilverDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to silver dragons. You have resistance to cold damage.",
            };

            var TraitSilverBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 15 ft. cone. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 cold damage on a failed Constitution Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            //White Dragonborn Traits

            var TraitWhiteDraconicAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Draconic Ancestry",
                Description =
                    "You are related to white dragons. You have resistance to cold damage.",
            };

            var TraitWhiteBreathWeapon = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Breath Weapon",
                Description =
                    "You can use your action to exhale destructive energy in a 15 ft. cone. The DC of this saving throw is 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 cold damage on a failed Constitution Saving Throw, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
            };

            /*
            * ===== Dragonborn ASIs =====
            */

            var ASISTR2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "STR",
                IncreaseAmount = 2,
            };

            var ASICHA1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CHA",
                IncreaseAmount = 1,
            };

            /*
            * ===== Dragonborn Subraces =====
            */

            var SubraceBlack = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Black Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitBlackDraconicAncestry.Id,
                    TraitBlackBreathWeapon.Id,
                },
            };

            var SubraceBlue = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Blue Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitBlueDraconicAncestry.Id,
                    TraitBlueBreathWeapon.Id,
                },
            };

            var SubraceBrass = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Brass Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitBrassDraconicAncestry.Id,
                    TraitBrassBreathWeapon.Id,
                },
            };

            var SubraceBronze = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Bronze Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitBronzeDraconicAncestry.Id,
                    TraitBronzeBreathWeapon.Id,
                },
            };

            var SubraceCopper = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Copper Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitCopperDraconicAncestry.Id,
                    TraitCopperBreathWeapon.Id,
                },
            };

            var SubraceGold = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Gold Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitGoldDraconicAncestry.Id,
                    TraitGoldBreathWeapon.Id,
                },
            };

            var SubraceGreen = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Green Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitGreenDraconicAncestry.Id,
                    TraitGreenBreathWeapon.Id,
                },
            };

            var SubraceRed = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Red Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid> { TraitRedDraconicAncestry.Id, TraitRedBreathWeapon.Id },
            };

            var SubraceSilver = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Silver Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitSilverDraconicAncestry.Id,
                    TraitSilverBreathWeapon.Id,
                },
            };

            var SubraceWhite = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "White Dragonborn",
                Description = "",
                ASIIds = new List<Guid> { },
                TraitIds = new List<Guid>
                {
                    TraitWhiteDraconicAncestry.Id,
                    TraitWhiteBreathWeapon.Id,
                },
            };

            /*
            * ===== Dragonborn Main Race =====
            */

            var Dragonborn = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Dragonborn",
                Description =
                    "Born of dragons, as their name proclaims, the dragonborn walk proudly through a world that greets them with fearful incomprehension. Shaped by draconic gods or the dragons themselves, dragonborn originally hatched from dragon eggs as a unique race, combining the best attributes of dragons and humanoids.",
                Proficiencies = "",
                Languages = "Common, Draconic",
                Speed = 30,
                Size = "Medium",
                DarkVisionRange = 0,
                ASIIds = new List<Guid> { ASISTR2.Id, ASICHA1.Id },
                TraitIds = new List<Guid> { TraitAge.Id, TraitAllignment.Id },
                SubraceIds = new List<Guid>
                {
                    SubraceBlack.Id,
                    SubraceBlue.Id,
                    SubraceBrass.Id,
                    SubraceBronze.Id,
                    SubraceCopper.Id,
                    SubraceGold.Id,
                    SubraceGreen.Id,
                    SubraceRed.Id,
                    SubraceSilver.Id,
                    SubraceWhite.Id,
                },
            };

            /*
            * ===== Update DB =====
            */

            //Traits

            _context.Traits.AddRange(
                TraitAge,
                TraitAllignment,
                TraitBlackDraconicAncestry,
                TraitBlackBreathWeapon,
                TraitBlueDraconicAncestry,
                TraitBlueBreathWeapon,
                TraitBrassDraconicAncestry,
                TraitBrassBreathWeapon,
                TraitBronzeDraconicAncestry,
                TraitBronzeBreathWeapon,
                TraitCopperDraconicAncestry,
                TraitCopperBreathWeapon,
                TraitGoldDraconicAncestry,
                TraitGoldBreathWeapon,
                TraitGreenDraconicAncestry,
                TraitGreenBreathWeapon,
                TraitRedDraconicAncestry,
                TraitRedBreathWeapon,
                TraitSilverDraconicAncestry,
                TraitSilverBreathWeapon,
                TraitWhiteDraconicAncestry,
                TraitWhiteBreathWeapon
            );
            //ASIs

            _context.ASIs.AddRange(ASISTR2, ASICHA1);

            await _context.SaveChangesAsync();

            //Subraces

            _context.Subraces.AddRange(
                SubraceBlack,
                SubraceBlue,
                SubraceBrass,
                SubraceBronze,
                SubraceCopper,
                SubraceGold,
                SubraceGreen,
                SubraceRed,
                SubraceSilver,
                SubraceWhite
            );

            //Race

            _context.Races.Add(Dragonborn);

            await _context.SaveChangesAsync();
        }

        private async Task AddDwarf()
        {
            /*
           * ===== Dwarf Traits =====
           */

            // Common Traits for all Dwarves
            var TraitDarkvision = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Darkvision",
                Description =
                    "Accustomed to life underground, you have superior vision in dark and dim conditions.",
            };

            var TraitDwarvenResilience = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Dwarven Resilience",
                Description =
                    "You have advantage on saving throws against poison, and you have resistance against poison damage.",
            };

            var TraitDwarvenCombatTraining = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Dwarven Combat Training",
                Description =
                    "You have proficiency with the battleaxe, handaxe, throwing hammer, and warhammer.",
            };

            var TraitToolProficiency = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Tool Proficiency",
                Description =
                    "You gain proficiency with the artisan's tools of your choice: smith's tools, brewer's supplies, or mason's tools.",
            };

            var TraitStonecunning = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Stonecunning",
                Description =
                    "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check.",
            };

            var TraitDwarvenToughness = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Dwarven Toughness",
                Description =
                    "Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.",
            };

            var TraitDwarvenArmorTraining = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Dwarven Armor Training",
                Description = "You have proficiency with light and medium armor.",
            };

            /*
            * ===== Dwarf ASI =====
            */

            // Mountain Dwarf Subrace
            var ASISTR2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "STR",
                IncreaseAmount = 2,
            };

            // Hill Dwarf Subrace
            var ASIWIS1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "WIS",
                IncreaseAmount = 1,
            };

            // Ability Score Increases for Dwarves
            var ASICON2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CON",
                IncreaseAmount = 2,
            };

            /*
            * ===== Dwarf Subraces =====
            */


            var SubraceHillDwarf = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Hill Dwarf",
                Description =
                    "As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience.",
                ASIIds = new List<Guid> { ASIWIS1.Id },
                TraitIds = new List<Guid> { TraitDwarvenToughness.Id },
            };

            var SubraceMountainDwarf = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Mountain Dwarf",
                Description =
                    "As a mountain dwarf, you're strong and hardy, accustomed to a difficult life in rugged terrain.",
                ASIIds = new List<Guid> { ASISTR2.Id },
                TraitIds = new List<Guid> { TraitDwarvenArmorTraining.Id },
            };

            /*
            * ===== Dwarf Race =====
            */
            // Create the Dwarf race
            var Dwarf = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Dwarf",
                Description =
                    "Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal.",
                ASIIds = new List<Guid> { ASICON2.Id },
                TraitIds = new List<Guid>
                {
                    TraitDarkvision.Id,
                    TraitDwarvenResilience.Id,
                    TraitDwarvenCombatTraining.Id,
                    TraitToolProficiency.Id,
                    TraitStonecunning.Id,
                },
                Languages = "Common, Dwarvish",
                Speed = 25,
                Size = "Medium",
                Proficiencies = "",
                DarkVisionRange = 60,
                SubraceIds = new List<Guid> { SubraceHillDwarf.Id, SubraceMountainDwarf.Id },
            };

            /*
            * ===== Dwarf Update Db =====
            */

            // Add objects to the database
            _context.ASIs.AddRange(ASICON2, ASIWIS1, ASISTR2);
            _context.Traits.AddRange(
                TraitDarkvision,
                TraitDwarvenResilience,
                TraitDwarvenCombatTraining,
                TraitToolProficiency,
                TraitStonecunning,
                TraitDwarvenToughness,
                TraitDwarvenArmorTraining
            );
            _context.Subraces.AddRange(SubraceHillDwarf, SubraceMountainDwarf);
            _context.Races.Add(Dwarf);
            await _context.SaveChangesAsync();
        }

        private async Task AddElf()
        {
            /*
             * ===== Elf Traits =====
             */

            var TraitDarkvision = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Darkvision",
                Description =
                    "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.",
            };

            var TraitFeyAncestry = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Fey Ancestry",
                Description =
                    "You have advantage on saving throws against being charmed, and magic can't put you to sleep.",
            };

            var TraitTrance = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Trance",
                Description =
                    "Elves do not sleep. Instead, they meditate deeply, remaining semi-conscious for 4 hours a day.",
            };

            var TraitKeenSenses = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Keen Senses",
                Description = "You have proficiency in the Perception skill.",
            };

            /*
            * ===== Elf ASI =====
            */

            var ASIDEX2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "DEX",
                IncreaseAmount = 2,
            };

            // High Elf Subrace
            var ASIINT1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "INT",
                IncreaseAmount = 1,
            };

            // Dark Elf Subrace
            var ASICHA1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CHA",
                IncreaseAmount = 1,
            };

            // Wood Elf Subrace
            var ASIWIS1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "WIS",
                IncreaseAmount = 1,
            };

            /*
            * ===== Elf Subraces =====
            */

            var SubraceHighElf = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "High Elf",
                Description =
                    "High Elves have keen minds and mastery of basic magic. They are haughty and often reclusive, believing themselves superior to non-elves and other elves.",
                ASIIds = new List<Guid> { ASIINT1.Id },
                TraitIds = new List<Guid> { TraitKeenSenses.Id },
            };

            var SubraceDarkElf = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Dark Elf (Drow)",
                Description =
                    "Dark Elves (Drow) are descended from an earlier subrace of dark-skinned elves banished from the surface world for following the goddess Lolth down the path of evil.",
                ASIIds = new List<Guid> { ASICHA1.Id },
                TraitIds = new List<Guid>
                { /* Add Drow-specific traits here */
                },
            };

            var SubraceWoodElf = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Wood Elf",
                Description =
                    "Wood Elves are intuitive and fleet-footed, carrying themselves stealthily through their native forests.",
                ASIIds = new List<Guid> { ASIWIS1.Id },
                TraitIds = new List<Guid>
                { /* Add Wood Elf-specific traits here */
                },
            };

            /*
            * ===== Elf Race =====
            */

            var Elf = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Elf",
                Description =
                    "Elves are magical beings of otherworldly grace, living in places of ethereal beauty, and they love nature, magic, art, and music.",
                ASIIds = new List<Guid> { ASIDEX2.Id },
                TraitIds = new List<Guid>
                {
                    TraitDarkvision.Id,
                    TraitFeyAncestry.Id,
                    TraitTrance.Id,
                    TraitKeenSenses.Id,
                },
                Languages = "Common, Elvish",
                Speed = 30,
                Size = "Medium",
                SubraceIds = new List<Guid>
                {
                    SubraceHighElf.Id,
                    SubraceDarkElf.Id,
                    SubraceWoodElf.Id,
                },
                DarkVisionRange = 60,
                Proficiencies = "",
            };

            /*
            * ===== Elf Update Db =====
            */

            _context.ASIs.AddRange(ASIDEX2, ASIINT1, ASICHA1, ASIWIS1);
            _context.Traits.AddRange(
                TraitDarkvision,
                TraitFeyAncestry,
                TraitTrance,
                TraitKeenSenses
            );
            _context.Subraces.AddRange(SubraceHighElf, SubraceDarkElf, SubraceWoodElf);
            _context.Races.Add(Elf);

            await _context.SaveChangesAsync();
        }

        private async Task AddGnome()
        {
            /*
             * ===== Gnome Traits =====
             */

            var TraitDarkvision = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Darkvision",
                Description =
                    "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.",
            };

            var TraitGnomeCunning = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Gnome Cunning",
                Description =
                    "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.",
            };

            /*
             * ===== Gnome ASI =====
             */

            var ASIINT2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "INT",
                IncreaseAmount = 2,
            };

            // Forest Gnome Subrace
            var ASIDEX1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "DEX",
                IncreaseAmount = 1,
            };

            // Rock Gnome Subrace
            var ASICON1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CON",
                IncreaseAmount = 1,
            };

            /*
             * ===== Forest Gnome Traits =====
             */

            var TraitNaturalIllusionist = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Natural Illusionist",
                Description =
                    "You know the Minor Illusion cantrip. Intelligence is your spellcasting modifier for it.",
            };

            var TraitSpeakWithSmallBeasts = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Speak with Small Beasts",
                Description =
                    "Through sound and gestures, you may communicate simple ideas with Small or smaller beasts.",
            };

            /*
             * ===== Rock Gnome Traits =====
             */

            var TraitArtificersLore = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Artificer's Lore",
                Description =
                    "Whenever you make an Intelligence (History) check related to magical, alchemical, or technological items, you can add twice your proficiency bonus instead of any other proficiency bonus that may apply.",
            };

            var TraitTinker = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Tinker",
                Description =
                    "You have proficiency with artisan tools (tinker's tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours unless repaired.",
            };

            /*
             * ===== Gnome Subraces =====
             */

            var SubraceForestGnome = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Forest Gnome",
                Description =
                    "Forest gnomes have a natural knack for illusion and inherent quickness and stealth. They tend to live in hidden communities in sylvan forests.",
                ASIIds = new List<Guid> { ASIDEX1.Id },
                TraitIds = new List<Guid>
                {
                    TraitNaturalIllusionist.Id,
                    TraitSpeakWithSmallBeasts.Id,
                },
            };

            var SubraceRockGnome = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Rock Gnome",
                Description =
                    "Rock gnomes are inventive and hardier than other gnomes, with a natural inclination for tinkering.",
                ASIIds = new List<Guid> { ASICON1.Id },
                TraitIds = new List<Guid> { TraitArtificersLore.Id, TraitTinker.Id },
            };

            /*
             * ===== Gnome Race =====
             */

            var Gnome = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Gnome",
                Description =
                    "Gnomes are playful and inventive, forming close-knit communities and taking joy in life through invention, exploration, and play.",
                ASIIds = new List<Guid> { ASIINT2.Id },
                TraitIds = new List<Guid> { TraitDarkvision.Id, TraitGnomeCunning.Id },
                Languages = "Common, Gnomish",
                Speed = 25,
                Size = "Small",
                SubraceIds = new List<Guid> { SubraceForestGnome.Id, SubraceRockGnome.Id },
                DarkVisionRange = 60,
                Proficiencies = "",
            };

            /*
             * ===== Gnome Update Db =====
             */

            _context.ASIs.AddRange(ASIINT2, ASIDEX1, ASICON1);
            _context.Traits.AddRange(
                TraitDarkvision,
                TraitGnomeCunning,
                TraitNaturalIllusionist,
                TraitSpeakWithSmallBeasts,
                TraitArtificersLore,
                TraitTinker
            );
            _context.Subraces.AddRange(SubraceForestGnome, SubraceRockGnome);
            _context.Races.Add(Gnome);

            await _context.SaveChangesAsync();
        }

        public async Task AddHalfElf()
        {
            // Create ability score increases
            var ASICha2 = new ASI { AbilityScore = "Charisma", IncreaseAmount = 2 };

            var ASI1 = new ASI { AbilityScore = "Choose", IncreaseAmount = 1 };

            var ASI2 = new ASI { AbilityScore = "Choose", IncreaseAmount = 1 };

            // Create traits
            var TraitDarkvision = new Trait
            {
                Name = "Darkvision",
                Description =
                    "Thanks to your elven heritage, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",
            };

            var TraitFeyAncestry = new Trait
            {
                Name = "Fey Ancestry",
                Description =
                    "You have advantage on saving throws against being charmed, and magic can’t put you to sleep.",
            };

            var TraitSkillVersatility = new Trait
            {
                Name = "Skill Versatility",
                Description = "You gain proficiency in two skills of your choice.",
            };

            var TraitElfWeaponTraining = new Trait
            {
                Name = "Elf Weapon Training",
                Description =
                    "You have proficiency with the longsword, shortsword, shortbow, and longbow.",
            };

            var TraitCantrip = new Trait
            {
                Name = "Cantrip",
                Description =
                    "You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.",
            };

            var TraitFleetOfFoot = new Trait
            {
                Name = "Fleet of Foot",
                Description = "Your base walking speed increases to 35 feet.",
            };

            var TraitMaskOfTheWild = new Trait
            {
                Name = "Mask of the Wild",
                Description =
                    "You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena.",
            };

            var TraitDrowMagic = new Trait
            {
                Name = "Drow Magic",
                Description =
                    "You know the Dancing Lights cantrip. At 3rd level, you can cast Faerie Fire once per long rest. At 5th level, you can cast Darkness once per long rest. Charisma is your spellcasting ability for these spells.",
            };

            var TraitSwimSpeed = new Trait
            {
                Name = "Swim Speed",
                Description = "You have a swimming speed of 30 feet.",
            };

            // Create race
            var HalfElf = new Race
            {
                Name = "Half-Elf",
                Description =
                    "Walking in two worlds but truly belonging to neither, half-elves combine what some say are the best qualities of their elf and human parents: human curiosity, inventiveness, and ambition tempered by the refined senses, love of nature, and artistic tastes of the elves.",
                Speed = 30,
                Size = "Medium",
                DarkVisionRange = 60,
                ASIIds = new List<Guid> { ASICha2.Id, ASI1.Id, ASI2.Id },
                TraitIds = new List<Guid>
                {
                    TraitDarkvision.Id,
                    TraitFeyAncestry.Id,
                    TraitSkillVersatility.Id,
                    TraitElfWeaponTraining.Id,
                    TraitCantrip.Id,
                    TraitFleetOfFoot.Id,
                    TraitMaskOfTheWild.Id,
                    TraitDrowMagic.Id,
                    TraitSwimSpeed.Id,
                },
                SubraceIds = new List<Guid> { },
                Languages = "Common, Elven, Choose",
                Proficiencies = "",
            };

            // Add the race to the database
            _context.ASIs.AddRange(ASICha2, ASI1, ASI2);
            _context.Traits.AddRange(
                TraitDarkvision,
                TraitFeyAncestry,
                TraitSkillVersatility,
                TraitElfWeaponTraining,
                TraitCantrip,
                TraitFleetOfFoot,
                TraitMaskOfTheWild,
                TraitDrowMagic,
                TraitSwimSpeed
            );
            _context.Races.Add(HalfElf);
            await _context.SaveChangesAsync();
        }

        private async Task AddHalfOrc()
        {
            /*
            * ===== Half-Orc Traits =====
            */

            // Common Traits for Half-Orcs
            var TraitDarkvision = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Darkvision",
                Description =
                    "Thanks to your orc blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.",
            };

            var TraitMenacing = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Menacing",
                Description = "You gain proficiency in the Intimidation skill.",
            };

            var TraitRelentlessEndurance = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Relentless Endurance",
                Description =
                    "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can't use this feature again until you finish a long rest.",
            };

            var TraitSavageAttacks = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Savage Attacks",
                Description =
                    "When you score a critical hit with a melee weapon attack, you can roll one of the weapon's damage dice one additional time and add it to the extra damage of the critical hit.",
            };

            /*
            * ===== Half-Orc ASI =====
            */

            var ASISTR2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "STR",
                IncreaseAmount = 2,
            };

            var ASICON1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CON",
                IncreaseAmount = 1,
            };

            /*
            * ===== Half-Orc Race =====
            */
            var HalfOrc = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Half-Orc",
                Description =
                    "When alliances between humans and orcs are sealed by marriages, half-orcs are born. Some half-orcs rise to become proud chiefs of orc tribes, their human blood giving them an edge over their full-blooded orc rivals. Some venture into the world to prove their worth among humans and other more civilized races. Many of these become adventurers, achieving greatness for their mighty deeds and notoriety for their barbaric customs and savage fury.",
                ASIIds = new List<Guid> { ASISTR2.Id, ASICON1.Id },
                TraitIds = new List<Guid>
                {
                    TraitDarkvision.Id,
                    TraitMenacing.Id,
                    TraitRelentlessEndurance.Id,
                    TraitSavageAttacks.Id,
                },
                Languages = "Common, Orc",
                Speed = 30,
                Size = "Medium",
                Proficiencies = "Intimidation",
                DarkVisionRange = 60,
                SubraceIds = new List<Guid>(), // No subraces for Half-Orcs
            };

            /*
            * ===== Half-Orc Update Db =====
            */

            // Add objects to the database
            _context.ASIs.AddRange(ASISTR2, ASICON1);
            _context.Traits.AddRange(
                TraitDarkvision,
                TraitMenacing,
                TraitRelentlessEndurance,
                TraitSavageAttacks
            );
            _context.Races.Add(HalfOrc);
            await _context.SaveChangesAsync();
        }

        private async Task AddHuman()
        {
            /*
            * ===== Human ASI =====
            */
            var ASISTR1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "STR",
                IncreaseAmount = 1,
            };

            var ASIDEX1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "DEX",
                IncreaseAmount = 1,
            };

            var ASICON1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CON",
                IncreaseAmount = 1,
            };

            var ASIINT1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "INT",
                IncreaseAmount = 1,
            };

            var ASIWIS1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "WIS",
                IncreaseAmount = 1,
            };

            var ASICHA1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "CHA",
                IncreaseAmount = 1,
            };

            /*
            * ===== Human Race =====
            */
            var Human = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Human",
                Description =
                    "In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that's why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.",
                ASIIds = new List<Guid>
                {
                    ASISTR1.Id,
                    ASIDEX1.Id,
                    ASICON1.Id,
                    ASIINT1.Id,
                    ASIWIS1.Id,
                    ASICHA1.Id,
                },
                TraitIds = new List<Guid>(), // No special traits
                Languages = "Common, One extra language of your choice",
                Speed = 30,
                Size = "Medium",
                Proficiencies = "", // No specific proficiencies
                DarkVisionRange = 0, // No Darkvision for Humans
                SubraceIds = new List<Guid>(), // No subraces for Humans
            };

            /*
            * ===== Human Update Db =====
            */

            // Add objects to the database
            _context.ASIs.AddRange(ASISTR1, ASIDEX1, ASICON1, ASIINT1, ASIWIS1, ASICHA1);
            _context.Races.Add(Human);
            await _context.SaveChangesAsync();
        }

        private async Task AddVariantHuman()
        {
            /*
            * ===== Variant Human ASI =====
            */
            var ASI1 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "Any",
                IncreaseAmount = 1,
            };

            var ASI2 = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "Any",
                IncreaseAmount = 1,
            };

            /*
            * ===== Variant Human Traits =====
            */
            var SkillProficiency = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Skill Proficiency",
                Description = "You gain proficiency in one skill of your choice.",
            };

            var Feat = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Feat",
                Description = "You gain one feat of your choice.",
            };

            /*
            * ===== Variant Human Race =====
            */
            var VariantHuman = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Variant Human",
                Description =
                    "In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that's why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.",
                ASIIds = new List<Guid> { ASI1.Id, ASI2.Id },
                TraitIds = new List<Guid> { SkillProficiency.Id, Feat.Id },
                Languages = "Common, One extra language of your choice",
                Speed = 30,
                Size = "Medium",
                Proficiencies = "", // To be selected by the player
                DarkVisionRange = 0, // No Darkvision for Variant Human
                SubraceIds = new List<Guid>(), // No subraces for Variant Human
            };

            /*
            * ===== Variant Human Update Db =====
            */

            // Add objects to the database
            _context.ASIs.AddRange(ASI1, ASI2);
            _context.Traits.AddRange(SkillProficiency, Feat);
            _context.Races.Add(VariantHuman);
            await _context.SaveChangesAsync();
        }

        private async Task AddTiefling()
        {
            /*
            * ===== Tiefling ASI =====
            */
            var charismaASI = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "Charisma",
                IncreaseAmount = 2,
            };

            /*
            * ===== Tiefling Traits =====
            */
            var darkvision = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Darkvision",
                Description =
                    "Thanks to your infernal heritage, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",
            };

            var hellishResistance = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Hellish Resistance",
                Description = "You have resistance to fire damage.",
            };

            /*
            * ===== Bloodline of Asmodeus Subrace =====
            */
            var intelligenceASI_Asmodeus = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "Intelligence",
                IncreaseAmount = 1,
            };

            var infernalLegacy_Asmodeus = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Infernal Legacy",
                Description =
                    "You know the Thaumaturgy cantrip. At 3rd level, you can cast Hellish Rebuke once as a 2nd-level spell. At 5th level, you can cast Darkness once. Charisma is your spellcasting ability for these spells. You must finish a long rest to cast these spells again.",
            };

            var bloodlineAsmodeus = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Bloodline of Asmodeus",
                Description =
                    "The tieflings connected to Nessus command the power of fire and darkness, guided by a keener than normal intellect, as befits those linked to Asmodeus himself.",
                ASIIds = new List<Guid> { intelligenceASI_Asmodeus.Id },
                TraitIds = new List<Guid> { infernalLegacy_Asmodeus.Id },
            };

            /*
            * ===== Bloodline of Baalzebul Subrace =====
            */
            var intelligenceASI_Baalzebul = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "Intelligence",
                IncreaseAmount = 1,
            };

            var legacyOfMaladomini = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Legacy of Maladomini",
                Description =
                    "You know the Thaumaturgy cantrip. At 3rd level, you can cast Ray of Sickness once as a 2nd-level spell. At 5th level, you can cast Crown of Madness once. Charisma is your spellcasting ability for these spells. You must finish a long rest to cast these spells again.",
            };

            var bloodlineBaalzebul = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Bloodline of Baalzebul",
                Description =
                    "The crumbling realm of Maladomini is ruled by Baalzebul, who excels at corrupting those whose minor sins can be transformed into acts of damnation.",
                ASIIds = new List<Guid> { intelligenceASI_Baalzebul.Id },
                TraitIds = new List<Guid> { legacyOfMaladomini.Id },
            };

            // Similar subrace creation for other Tiefling bloodlines...
            // Example of Bloodline of Zariel
            var strengthASI_Zariel = new ASI
            {
                Id = Guid.NewGuid(),
                AbilityScore = "Strength",
                IncreaseAmount = 1,
            };

            var legacyOfAvernus = new Trait
            {
                Id = Guid.NewGuid(),
                Name = "Legacy of Avernus",
                Description =
                    "You know the Thaumaturgy cantrip. At 3rd level, you can cast Searing Smite once as a 2nd-level spell. At 5th level, you can cast Branding Smite once. Charisma is your spellcasting ability for these spells. You must finish a long rest to cast these spells again.",
            };

            var bloodlineZariel = new Subrace
            {
                Id = Guid.NewGuid(),
                Name = "Bloodline of Zariel",
                Description =
                    "Tieflings with a blood tie to Zariel are stronger than the typical tiefling and receive magical abilities that aid them in battle.",
                ASIIds = new List<Guid> { strengthASI_Zariel.Id },
                TraitIds = new List<Guid> { legacyOfAvernus.Id },
            };

            /*
            * ===== Tiefling Race =====
            */
            var tiefling = new Race
            {
                Id = Guid.NewGuid(),
                Name = "Tiefling",
                Description =
                    "To be greeted with stares and whispers, to suffer violence and insult on the street, to see mistrust and fear in every eye: this is the lot of the tiefling. And to twist the knife, tieflings know that this is because a pact struck generations ago infused the essence of Asmodeus, overlord of the Nine Hells, into their bloodline.",
                ASIIds = new List<Guid> { charismaASI.Id },
                TraitIds = new List<Guid> { darkvision.Id, hellishResistance.Id },
                Languages = "Common, Infernal",
                Speed = 30,
                Size = "Medium",
                DarkVisionRange = 60,
                SubraceIds = new List<Guid>
                {
                    bloodlineAsmodeus.Id,
                    bloodlineBaalzebul.Id,
                    bloodlineZariel.Id /* Add other bloodlines here */
                    ,
                },
                Proficiencies = "",
            };

            /*
            * ===== Tiefling Update Db =====
            */

            // Add objects to the database
            _context.ASIs.AddRange(
                charismaASI,
                intelligenceASI_Asmodeus,
                intelligenceASI_Baalzebul,
                strengthASI_Zariel
            );
            _context.Traits.AddRange(
                darkvision,
                hellishResistance,
                infernalLegacy_Asmodeus,
                legacyOfMaladomini,
                legacyOfAvernus
            );
            _context.Subraces.AddRange(bloodlineAsmodeus, bloodlineBaalzebul, bloodlineZariel);
            _context.Races.Add(tiefling);
            await _context.SaveChangesAsync();
        }
    }
}
