using CrowdControl.Common;
using JetBrains.Annotations;
using ConnectorType = CrowdControl.Common.ConnectorType;

namespace CrowdControl.Games.Packs.DeepRockGalacticRequiredByAll;

[UsedImplicitly]
public class DeepRockGalacticRequiredByAll : FileEffectPack
{
    public override string ReadFile => "FSD\\Mods\\CC\\output.txt";
    public override string WriteFile => "FSD\\Mods\\CC\\input.txt";
    public static string ReadyCheckFile = "FSD\\Mods\\CC\\connector.txt";

    public override ISimpleTCPPack.MessageFormat MessageFormat => ISimpleTCPPack.MessageFormat.CrowdControlLegacyIntermediate;

    public DeepRockGalacticRequiredByAll(UserRecord player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler) { }

    public override Game Game { get; } = new("Deep Rock Galactic", "DeepRockGalacticRequiredByAll", "PC", ConnectorType.FileConnector);

    //Parameters
    private readonly ParameterDef TargetsMain = new("Target Player", "targetPlayerType",
        new Parameter("Host", "1"),
        new Parameter("Random Teammate", "2"),
        new Parameter("All", "3")
    );
    private readonly ParameterDef TargetsRestricted = new("Target Player", "targetPlayerType",
        new Parameter("Host", "1"),
        new Parameter("Random Teammate", "2")
    );

    public override EffectList Effects => new List<Effect>
    {
        //Enemy - Glyphids Spawn
        new("Spawn Grunt [M]", "grunt_normal") { Price = 10, Quantity = 10, Category = "Enemy / Glyphid", Description = "Spawns a Grunt" },
        new("Spawn Slasher [M]", "grunt_slasher") { Price = 20, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns a Slasher" },
        new("Spawn Guard [M]", "grunt_guard") { Price = 20, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns a Guard" },
        new("Spawn Acid Spitter [M]", "grunt_spitter") { Price = 50, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns an Acid Spitter" },
        new("Spawn Web Spitter [M]", "grunt_webber") { Price = 50, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns a Webber" },
        new("Spawn Warden [M]", "grunt_warden") { Price = 100, Category = "Enemy / Glyphid", Description = "Spawns a Warden" },
        new("Spawn Swarmers [M]", "grunt_swarmers") { Price = 10, Quantity = 10, Category = "Enemy / Glyphid", Description = "Spawns a couple swarmers (Quantity x2)" },
        new("Spawn Praetorian [M]", "grunt_praetorian") { Price = 150, Quantity = 3, Category = "Enemy / Glyphid", Description = "Spawns an Praetorian" },
        new("Spawn Opressor [M]", "grunt_opressor") { Price = 250, Category = "Enemy / Glyphid", Description = "Spawns an Opressor" },
        new("Spawn Stingtail [M]", "grunt_stingtail") { Price = 200, Category = "Enemy / Glyphid", Description = "Spawns an Stingtail" },
        new("Spawn Septic Spreader [M]", "grunt_lobber") { Price = 200, Category = "Enemy / Glyphid", Description = "Spawns an Septic Spreader" },
        new("Spawn Menace [M]", "grunt_menace") { Price = 150, Category = "Enemy / Glyphid", Description = "Spawns an Menace" },
        new("Spawn Exploder [M]", "grunt_exploder") { Price = 50, Quantity = 5, Category = "Enemy / Glyphid", Description = "Spawns an Exploder" },
        new("Spawn Stalker [M]", "grunt_stalker") { Price = 250, Category = "Enemy / Glyphid", Description = "Spawns the Glyphid Stalker" }, //Season 5
        new("Spawn Bulk Detonator [M]", "grunt_bulk") { Price = 500, Category = "Enemy / Glyphid", Description = "Spawns a Bulk Detonator" },
        new("Spawn Crassus Bulk Detonator [M]", "grunt_bulk_gold") { Price = 750, Category = "Enemy / Glyphid", Description = "Spawns a Crassus Bulk Detonator" },
        new("Spawn Ghost Bulk Detonator [M]", "grunt_bulk_ghost") { Price = 1000, Category = "Enemy / Glyphid", Description = "Spawns a Ghost Bulk Detonator" },
        new("Spawn Dreadnaught (Boss) [M]", "grunt_dreadnaught") { Price = 1000, Category = "Enemy / Glyphid", Description = "Spawns the Glyphid Dreadnaught" },
        new("Spawn Arbalest (Boss) [M]", "grunt_twin_a") { Price = 500, Category = "Enemy / Glyphid", Description = "Spawns the Dreadnaught Twin Arbalest" },
        new("Spawn Lacerator (Boss) [M]", "grunt_twin_b") { Price = 500, Category = "Enemy / Glyphid", Description = "Spawns the Dreadnaught Twin Lacerator" },
        new("Spawn Hiveguard (Boss) [M]", "grunt_hiveguard") { Price = 1000, Category = "Enemy / Glyphid", Description = "Spawns the Dreadnaught Hiveguard" },

        //Enemy - Mactera
        new("Spawn Mactera Shooter [M]", "mactera_normal") { Price = 25, Quantity = 5, Category = "Enemy / Mactera", Description = "Spawns a Mactera Shooter" },
        new("Spawn Mactera Grabber [M]", "mactera_grabber") { Price = 100, Category = "Enemy / Mactera", Description = "Spawns a Mactera Greabber" },
        new("Spawn Mactera Goo Bomber [M]", "mactera_goobomber") { Price = 100, Category = "Enemy / Mactera", Description = "Spawns a Mactera Goo Bomber" },
        new("Spawn Mactera Tri-Jaw [M]", "mactera_trijaw") { Price = 100, Category = "Enemy / Mactera", Description = "Spawns a Mactera TriJaw" },
        new("Spawn Mactera Brundle [M]", "mactera_brundle") { Price = 50, Category = "Enemy / Mactera", Description = "Spawns a Mactera Brundle" },

        //Enemy - RockPox
        new("Spawn Rockpox Larva [M]", "rockpox_larva") { Price = 10, Quantity = 10, Category = "Enemy / RockPox", Description = "Spawns Some RockPox Larva (Quantity x2)" },
        new("Spawn Rockpox Grunt [M]", "rockpox_grunt") { Price = 50, Quantity = 5, Category = "Enemy / RockPox", Description = "Spawns a RockPox Grunt" },
        new("Spawn Rockpox Exploder [M]", "rockpox_exploder") { Price = 75, Quantity = 5, Category = "Enemy / RockPox", Description = "Spawns a RockPox Exploder" },
        new("Spawn Rockpox Spitter [M]", "rockpox_spitter") { Price = 75, Quantity = 5, Category = "Enemy / RockPox", Description = "Spawns a RockPox Spitter" },
        new("Spawn Rockpox Praetorian [M]", "rockpox_praetorian") { Price = 175, Quantity = 3, Category = "Enemy / RockPox", Description = "Spawns a RockPox Praetorian" },
        new("Spawn Rockpox Goo Bomber [M]", "rockpox_goobomber") { Price = 125, Category = "Enemy / RockPox", Description = "Spawns a RockPox Goo Bomber" },
        new("Spawn Rockpox Naedocyte Breeder [M]", "rockpox_breeder") { Price = 200, Category = "Enemy / RockPox", Description = "Spawns a RockPox Naedocyte Breeder" },
        new("Spawn Rockpox Corruptor (Boss) [M]", "rockpox_corruptor") { Price = 750, Category = "Enemy / RockPox", Description = "Spawns a RockPox Corruptor" },

        //Enemy - Rivals
        new("Spawn Rival Shredders [M]", "rival_shredders") { Price = 10, Quantity = 5, Category = "Enemy / Rivals", Description = "Spawns a small group of Rival Shredders (Quantity x2)" },
        new("Spawn Rival Patrol Bot [M]", "rival_patrolbot") { Price = 100, Quantity = 3, Category = "Enemy / Rivals", Description = "Spawns a Patrol Bot" },
        new("Spawn Rival Prospector Drone (Boss) [M]", "rival_prospector") { Price = 500, Category = "Enemy / Rivals", Description = "Spawns a Prospector Bot" },
        new("Spawn Rival Nemesis (Boss) [M]", "rival_nemesis") { Price = 500, Category = "Enemy / Rivals", Description = "Spawns a Nemesis" },

        //Enemy - Naedocyte
        new("Spawn Naedocyte Shockers [M]", "jelly_shockers") { Price = 10, Quantity = 5, Category = "Enemy / Naedocyte", Description = "Spawns a small group of Shockers (Quantity x3)" },
        new("Spawn Naedocyte Breeder [M]", "jelly_breeder") { Price = 150, Category = "Enemy / Naedocyte", Description = "Spawns a Naedocyte Breeder" },

        //Enemy - Other
        new("Spawn Nayaka Trawler [M]", "enemy_trawler") { Price = 150, Category = "Enemy / Other", Description = "Spawns a Nayaka Trawler" },
        new("Spawn Q'ronar Youngling [M]", "enemy_youngling") { Price = 100, Quantity = 3, Category = "Enemy / Other", Description = "Spawns a Q'ronar Youngling" },
        new("Spawn Q'ronar Shellback [M]", "enemy_shellback") { Price = 200, Category = "Enemy / Other", Description = "Spawns a Q'ronar Shellback" },
        new("Spawn Korlok Tyrant Weed (Boss) [M]", "enemy_tyrantweed") { Price = 500, Category = "Enemy / Other", Description = "Spawns a Tyrant Weed" },
        new("Spawn BET-C (Boss) [M]", "enemy_betc") { Price = 500, Category = "Enemy / Other", Description = "Spawns a BET-C" },
        new("Spawn Cave Leech [M]", "enemy_leech") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Cave Leech" },
        new("Spawn Spitball Infector [M]", "enemy_spitballer") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Spitball Infector" },
        new("Spawn Barrage Infector [M]", "enemy_barrageinfector") { Price = 150, Category = "Enemy / Other", Description = "Spawns a Barrage Infector Plant" }, //Season 5
        new("Spawn Vartok Scale Bramble [M]", "enemy_scalebramble") { Price = 150, Category = "Enemy / Other", Description = "Spawns a Vartok Scale Bramble Plant" }, //Season 5
        new("Spawn Brood Nexus [M]", "enemy_broodnexus") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Brood Nexus" },
        new("Spawn Stabber Vine [M]", "enemy_stabber") { Price = 100, Category = "Enemy / Other", Description = "Spawns a Stabber Vine" },
        new("Spawn Deeptora Wasp Nest [M]", "enemy_wasps") { Price = 50, Category = "Enemy / Other", Description = "Spawns a hive of Wasps" },
        new("Spawn Crawler [M]", "enemy_crawler") { Price = 150, Quantity = 5, Category = "Enemy / Other", Description = "Spawns a crawler from the deep core" }, //Season 5

        //Enemy - Custom
        new("Spawn Hunter Grabber [M]", "custom_huntergrabber") { Price = 100, Quantity = 2, Category = "Enemy / Custom", Description = "Spawns an Invisible Fast Grabber" },
        new("Spawn Mega Bulk [M]", "sggx_megabulk") { Price = 500, Category = "Enemy / Custom", Description = "Spawns a Mega Sized Bulk with Random Types" },
        new("Spawn Jumpscare Bulk [M]", "custom_jumpscarebulk") { Price = 500, Category = "Enemy / Custom", Description = "Spawns a Mega Sized Bulk with Random Types" },
        new("Spawn Anxious Nuke Bug [M]", "custom_anxiousnukebug") { Price = 250, Category = "Enemy / Custom", Description = "Spawns an anxious lootbug that if given too little pets will explode, or too many pets will explode!" },
        new("Spawn Egg Menace [M]", "custom_eggmenace") { Price = 300, Category = "Enemy / Custom", Description = "Spawns a menace that shoots explosive and phermoned swarmer eggs!" },
        new("Spawn Wonky Grunts [M]", "custom_wonkygrunts") { Price = 50, Quantity = 10, Category = "Enemy / Custom", Description = "Spawns a random slasher or guard glyphid with randomized x y z dimensions" },
        new("Spawn Nesting Glyphids [M]", "custom_nestedglyphids") { Price = 300, Category = "Enemy / Custom", Description = "Spawns an Opressor, that splits into 2 Praetorians, then 4 grunts, then 8 swarmers!" },
        new("Spawn Cluster Bulk [M]", "custom_clusterbulk") { Price = 500, Category = "Enemy / Custom", Description = "Spawns a bulk that when killed drops a lot of cluster bomb explosions! Huge AoE!" },
        new("Spawn Reaper [M]", "sggx_reaper") { Price = 1000, Category = "Enemy / Custom", Description = "Spawns a reaper slasher. It hunts the team for the whole mission respawning after death and getting stronger with each death!" },
        new("Spawn Thiccbug [M]", "sggx_thiccbug") { Price = 200, Category = "Enemy / Custom", Description = "Spawns a Lootbug that steals the team's gold. They can get it back if they kill it. It also has a growing slappable booty." },

        //Critters
        new("Spawn Lootbug [M]", "critter_lootbug") { Price = 10, Quantity = 10, Category = "Critter", Description = "Spawns a Lootbug" },
        new("Spawn Naedocyte Cave Cruiser [M]", "critter_cavecruiser") { Price = 5, Category = "Critter", Description = "Spawns a Cave Cruiser" },
        new("Spawn Cave Vine [M]", "critter_cavevine") { Price = 5, Category = "Critter", Description = "Spawns a Cave Vine" },
        new("Spawn Silicate Harvester [M]", "critter_harvester") { Price = 10, Category = "Critter", Description = "Spawns a Silicate Harvester" },
        new("Spawn Cave Angel [M]", "critter_caveangel") { Price = 25, Quantity = 5,  Category = "Critter", Description = "Spawns a Cave Angel" },
        new("Spawn Fester Flea [M]", "critter_flea") { Price = 25, Quantity = 10, Category = "Critter", Description = "Spawns a Fester Flea" },

        //Helpful Items - Custom
        new("Give Molly a Gun! [M]", "custom_battlemolly") { Price = 200, Category = "Helpful / Custom", Description = "Spawns a minehead turret attached to each Mule / Mini-Mule!" },
        new("Spawn Pet Shredder [M]", "custom_petshredder") { Price = 200, Category = "Helpful / Custom", Description = "Spawns a friendly pet shredder with your name! (Lasts Mission Duration)" },
        new("Boost Molly! [M]", "custom_mollybooster") { Price = 100, Category = "Helpful / Custom", Duration = 30, Description = "Makes Molly go Turbo Speed for 30s!" },
        new("Roulettebug [M]", "custom_roulettebug") { Price = 100, Category = "Helpful / Custom", Description = "Spawn a Lootbug that spawns 1 of 10 events when it dies!" },
        new("Medi Battery [M]", "custom_medibattery") { Price = 250, Category = "Helpful / Custom", Description = "Spawn a Medibattery that can revive players after they get enough kills (If one exists instead add 100 kills to it's charge)." },

        //Helpful Items - Vanilla
        new("Spawn Minehead Sentry [M]", "helpful_battlesentry") { Price = 100, Quantity = 3, Category = "Helpful / Vanilla", Description = "Spawns a minehead turret!" },
        new("Spawn Floodlight [M]", "helpful_floodlight") { Price = 50, Category = "Helpful / Vanilla", Description = "Spawns a floodlight!" },
        new("Spawn Resupply Pod [M]", "helpful_resupply") { Price = 100, Quantity = 2, Category = "Helpful / Vanilla", Description = "Spawns a resupply for the team!" },

        //Fun Effects
        //Beer Effects
        new("Drunk Target [A]", "beer_drunk") { Price = 200, Parameters = TargetsMain, Category = "Beer",  Duration = 15, Description = "Makes target drunk for 15s" },
        new("Target Random Beer [A]", "beer_random") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Random Beer Effect." },
        new("Target Flintlock Delight [A]", "beer_flintlock") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Flintlock Delight Beer Effect." },
        new("Target Malt Rockbeaerer [A]", "beer_rockbearer") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Malt Rockbearer Beer Effect." },
        new("Target Underhill Deluxe [A]", "beer_underhill") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Underhill Deluxe Beer Effect." },
        new("Target Blackreach Blonde [A]", "beer_blackreach") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Blackreach Blonde Beer Effect." },
        new("Target Gut Wrecker [A]", "beer_gutwrecker") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Gut Wrecker Beer Effect." },
        new("Target Burning Love [A]", "beer_burning") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Burning Love Beer Effect." },
        new("Target Arkenstout [A]", "beer_arkenstout") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Arkenstout Beer Effect." },
        new("Target Mactera Brew [A]", "beer_mactera") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Mactera Brew Beer Effect." },
        new("Target Blacklock Lager [A]", "beer_blacklock") { Price = 100, Parameters = TargetsMain, Category = "Beer", Description = "Gives the Target a Blacklock Lager Beer Effect." },
        new("Target Seasoned Moonrider [A]", "beer_moonrider") { Price = 100, Parameters = TargetsRestricted, Category = "Beer", Description = "Gives the Target a Seasoned Moonrider Beer Effect." },

        //Target Effects
        new("Spawn Shield Target [M]", "target_shield") { Price = 100, Parameters = TargetsRestricted, Category = "Event", Duration = 10, Description = "Spawns a shield for the target!" },
        new("Spawn Red Sugar On Target [M]", "target_redsugar") { Price = 100, Category = "Event", Description = "Spawns red sugar on the target!" },
        new("Spawn Target Confetti [A]", "target_confetti") { Price = 10, Parameters =TargetsMain, Category = "Event", Description = "Spawns confetti on the target!" },

        //Full Team
        new("Spawn Shield All [M]", "all_shield") { Price = 200, Category = "Event", Duration = 10, Description = "Spawns a shield for everyone!" },
        new("Spawn Red Sugar All [M]", "all_redsugar") { Price = 200, Category = "Event", Description = "Spawns a Red Sugar Crystal for everyone!" },

        //Events
        new("Slomo Mode [M]", "event_slomo") { Price = 150, Category = "Event", Duration = 15, Description = "Put the game in slow motion for 15s" },
        new("Fastmo Mode [M]", "event_fastmo") { Price = 150, Category = "Event", Duration = 15, Description = "Put the game in fast motion for 15s" },
        new("EMP All Shields [M]", "event_emp") { Price = 250, Category = "Event", Description = "EMP the entire team's shields!" },
        new("Shuffle All Players [M]", "event_shuffleplayers") { Price = 200, Category = "Event", Description = "Randomly shuffle all player locations! (Does not work on solo player Game)" },
        new("Gather All Players On Target [M]", "event_gatherplayers") { Price = 200, Parameters = TargetsRestricted, Category = "Event", Description = "Randomly shuffle all player locations! (Does not work on solo player Game)" },
        new("Drop Tactical Nuke! [M]", "sggx_tacticalnuke") { Price = 500, Category = "Event", Description = "Drops a Nuke on the host's location with a small warning delay!", SessionCooldown = 60},

        //Custom Bosses
        new("Hydra Bulk Boss [M]", "sggx_hydrabulk") { Price = 1000, Category = "Enemy / Boss", Description = "Spawns a Boss Bulk that splits into more smaller bulks as it dies! (Until Micro Hydra Bulks)", SessionCooldown = 60},

        //Holidays
        //Halloween
        new("Jaco Grunt [M]", "x_halloween_grunt") { Price = 25, Quantity = 5, Category = "Halloween", Description = "Spawn a Halloween themed grunt guard!" },
        new("Jaco Shooter [M]", "x_halloween_shooter") { Price = 25, Quantity = 5, Category = "Halloween", Description = "Spawn a Halloween themed mactera shooter!" },
        new("Little Ghost [M]", "x_halloween_shredder") { Price = 25, Quantity = 5, Category = "Halloween", Description = "Spawn a Halloween themed shredders (x2)" },
        new("Halloween Pet [M]", "x_halloween_pet") { Price = 25, Parameters = TargetsRestricted, Category = "Halloween", Description = "Spawn a friendly pet shredder to guard your target!" },
        new("Pumpkin Patch [M]", "x_halloween_pumpkinpatch") { Price = 100, Category = "Halloween", Description = "Spawn a pumpkin patch that spawns halloween themed enemies at random." },
        new("Candle Lobber [M]", "x_halloween_candlelobber") { Price = 100, Category = "Halloween", Description = "Spawn a candle wax lobber! Careful it burns!" },
        new("Witch Warden [M]", "x_halloween_witchwarden") { Price = 100, Category = "Halloween", Description = "Spawn a warden with a witchy theme and stronger magic!" },
        new("True Slasher [M]", "x_halloween_trueslasher") { Price = 500, Category = "Halloween", Description = "Send an unkillable slasher glyphid in a hockey mask to hunt the team!" },
        new("Horror [A]", "halloween_horror") { Price = 50, Category = "Halloween", Parameters = TargetsMain, Duration = 20, Description = "Send visual horrors to the target player." },

        //Extended Content - New Generic Enemies
        new("Spawn Frosty Exploder [M]", "sggc_enemy_frostyexploder") { Price = 100, Parameters = TargetsMain, Category = "Expansion / Enemy", Description = "Spawns an Exploder that freezes players it explodes on!" },
        new("Spawn Crushing Grabber [M]", "sggc_enemy_crushinggrabber") { Price = 150, Parameters = TargetsRestricted, Category = "Expansion / Enemy", Description = "Spawns a grabber that deals rapid crushing damage!" },
        new("Spawn Exploding Grabber [M]", "sggc_enemy_explodinggrabber") { Price = 150, Parameters = TargetsRestricted, Category = "Expansion / Enemy", Description = "Spawns a grabber that has a chance to self detonate once it grabs a target!" },
        new("Spawn Goo Swarmer [M]", "sggc_enemy_gooswarmer") { Price = 50, Quantity = 5, Category = "Expansion / Enemy", Description = "Spawns swarmers that pop into slowing goo when they die. (Quantity x2)" },
        new("Spawn Swarmer Brundle [M]", "sggc_enemy_swarmerbrundle") { Price = 200, Category = "Expansion / Enemy", Description = "Spawns a mactera brundle that drops goo swarmers periodically." },
        new("Spawn Alpha Zombie [M]", "sggc_enemy_alphazombie") { Price = 500, Category = "Expansion / Enemy", Description = "Spawns a rockpox infected grunt, that can infect other grunts. Infected enemies respawn after death." },
        new("Spawn Leech Bulk [M]", "sggc_enemy_leechbulk") { Price = 750, Category = "Expansion / Enemy", Description = "A Bulk with weakpoints growing cave leeches! Be careful it has a large range!" },
        new("Spawn Un-Bulk [M]", "sggc_enemy_unbulk") { Price = 250, Category = "Expansion / Enemy", Description = "Spawns a bulk that Unexplodes, and pulls things in creating terrain! It deals no damage itself." },
        new("Spawn Void Carver Bulk [M]", "sggc_enemy_voidcarver") { Price = 500, Category = "Expansion / Enemy", Description = "Spawns a Void Carver bulk. The Bulk instantly deletes 60m of terrain when it dies! (Expect a tiny lag spike)", SessionCooldown = 60 },
        new("Spawn Treasure Goblin [M]", "sggc_enemy_treasuregoblin") { Price = 250, Category = "Expansion / Enemy", Description = "Spawns a Treasure Goblin. It'll run and throw explosives, but kill it and take it's gold!"},
        new("Spawn American Praetorian [M]", "sggc_enemy_american") { Price = 300, Category = "Expansion / Enemy", Description = "Spawns a Praetorian with USA colors, freedom music, and a freedom turret."},
        new("Spawn Canadian Grunt [M]", "sggc_enemy_canadian") { Price = 100, Quantity = 3, Category = "Expansion / Enemy", Description = "Spawns a Canadian Grunt thats really sorry about fighting, it also is immune to the cold."},
        new("Spawn Ninja Slasher [M]", "sggc_enemy_japan") { Price = 200, Quantity = 2, Category = "Expansion / Enemy", Description = "Spawns a slasher that can substitute and teleport!"},
        new("Spawn D4-terra [M]", "sggc_enemy_d4terra") { Price = 100, Quantity = 2, Category = "Expansion / Enemy", Description = "Spawns a D4 mactera that rolls a D4 for effect when it dies!"},
        new("Spawn D6-Bulk [M]", "sggc_enemy_d6bulk") { Price = 500, Category = "Expansion / Enemy", Description = "Spawns a Bulk that rolls a D6 on death for what it's buds will spawn!"},
        new("Spawn Cluster Bulk [M]", "sggc_enemy_clusterb") { Price = 500, Category = "Expansion / Enemy", Description = "Spawns a Bulk that explodes into 8, then 4 more explosions! (Dangerous for low end PCs)"},
        new("Spawn Cluster Bulk XL [M]", "sggc_enemy_clusterbxl") { Price = 600, Category = "Expansion / Enemy", Description = "Spawns a Cluster Bulk that explodes an extra 4x! (Dangerous for most PCs)"},
        new("Spawn Cluster Bulk XXL [M]", "sggc_enemy_clusterbxxl") { Price = 700, Category = "Expansion / Enemy", Description = "Spawns a Cluster Bulk XL that explodes an extra 3x! (Dangerous for all PCs)"},
        new("Spawn Cluster Lootbug [M]", "sggc_enemy_clusterlootbug") { Price = 50, Quantity = 3, Category = "Expansion / Enemy", Description = "Spawns a Lootbug that drops a cluster grenade on death."},

        //Extended Content - New Bosses
        new("EyeSore Boss [M]", "sggc_boss_eyesore") { Price = 750, Category = "Expansion / Boss", Description = "Spawns a googly eyed hive that spawns googly eyed enemies!" },
        new("Hive Bulk Boss [M]", "sggc_boss_hivebulk") { Price = 1000, Category = "Expansion / Boss", Description = "Spawns a bulk that produces mini bulks over time. The mini bulks are defective and have modified traits." },
        new("Pog Lord Boss [M]", "sggc_boss_poglord") { Price = 750, Category = "Expansion / Boss", Description = "Spawns a googly eyed glowing spitballer! Here to show it's pogglets a good fight!" },
        new("Plague Dread Boss [M]", "sggc_boss_plaguedread") { Price = 750, Category = "Expansion / Boss", Description = "Spawns a plague dreadnaught that totally doesnt have a second phase..." },
        new("Puffy Swarmer Boss [M]", "sggc_boss_puffyswarmer") { Price = 400, Category = "Expansion / Boss", Description = "Spawns a swarmer that gets bigger and deals more damage as it takes damage." },
        new("Bearly There Exploder Boss [M]", "sggc_boss_bearlythere") { Price = 600, Category = "Expansion / Boss", Description = "Spawns an exploder that spawns clones and runs away. Kill it before getting overwhelmed." },
        new("King and Queen Stingtails Boss [M]", "sggc_boss_kandqsting") { Price = 750, Category = "Expansion / Boss", Description = "Spawns a King Fire stingtail, and Queen Ince Stingtail. They heal each other, and one gets stronger when the other dies!" },
        new("Untotsus Boss [M]", "sggc_boss_untotsus") { Price = 500, Category = "Expansion / Boss", Description = "Spawns a bulk that then spawns more bulks on death, that then spawn cursed grunts!" },
        new("Twlich Boss [M]", "sggc_boss_twlich") { Price = 1000, Category = "Expansion / Boss", Description = "Spawns an unkillable slow moving enemy that will harass the players until half of the team goes down." },

        //Extended Content - New Events
        new("Strapped Bomb [M]", "sggc_event_strappedbomb") { Price = 500, Category = "Expansion / Event", Description = "Spawns a bomb strapped to a random player. After the timer they blow up taking enemies and allies with them!" },
        new("Tunnel Bomb Landmines [M]", "sggc_event_tunnelbomb") { Price = 200, Quantity = 5, Category = "Expansion / Event", Description = "Spawns a tunnel bomb. A boxed bomb with a 5 second proximity timer! Watch Out!" },
        new("EXTERMINATUS! [M]", "sggc_event_exterminatus") { Price = 1000, Category = "Expansion / Event", Description = "Spawns an orbital lazer strike after 20 a second warning. Wipes out everything in a massive area including the terrain. (Highly Dangerous)" },

        //Extended Content - Player Auras
        new("Player Aura - Beserk [M]", "sggc_aura_beserk") { Price = 100, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that gives nearby dwarves beserk! (30s)" },
        new("Player Aura - Burning [M]", "sggc_aura_burning") { Price = 200, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that burns nearby dwarves. (30s)" },
        new("Player Aura - Freezing [M]", "sggc_aura_freezing") { Price = 200, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that freezes nearby dwarves. (30s)" },
        new("Player Aura - Gooey [M]", "sggc_aura_gooey") { Price = 200, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that slows nearby dwarves. (30s)" },
        new("Player Aura - Electric [M]", "sggc_aura_electric") { Price = 200, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that drains shields on nearby dwarves. (30s)" },
        new("Player Aura - Toxic [M]", "sggc_aura_toxic") { Price = 200, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that deals radiation damage to nearby dwarves. (30s)" },
        new("Player Aura - Gravity [M]", "sggc_aura_gravity") { Price = 300, Category = "Expansion / Player Aura", Description = "Gives a random player an aura that pulls all dwarves towards them. (30s)" },
        new("Player Aura - Lovers Binding [M]", "sggc_aura_lovers") { Price = 400, Category = "Expansion / Player Aura", Description = "Gives 2 Players the lovers aura. While near each other they heal, but if one goes down they both do." },

        //Extended Content - New Helpful
        new("C4R-E Package [M]", "sggc_help_c4re") { Price = 250, Category = "Expansion / Helpful", Description = "Spawns a friendly BET-C that can shield you when you salute her!" },
        new("Drop Medic Pod [M]", "sggc_help_medicpod") { Price = 150, Category = "Expansion / Helpful", Description = "Spawns a resupply pod that instead of giving supplies has a healing aura. It has a limited charge." },
        new("Drop Shield Pod [M]", "sggc_help_shieldpod") { Price = 150, Category = "Expansion / Helpful", Description = "Spawns a resupply pod that instead of giving supplies boosts shield regen in the area. It has a limited charge." },
        new("Drop Military Pod [M]", "sggc_help_militarypod") { Price = 200, Category = "Expansion / Helpful", Description = "Spawns a resupply pod gives supplies and friendly shredders, as well as comes with a turret attached!" },
        new("Summon Blood Shard [M]", "sggc_help_bloodshard") { Price = 150, Category = "Expansion / Helpful", Description = "Spawns a blood shard that will revive players when they kill enough enemies." },
        new("Spawn Medi-Bulk [M]", "sggc_help_medibulk") { Price = 200, Category = "Expansion / Helpful", Description = "Spawns a bulk that heals on explosion from eating too much red sugar." },

        //Rival Enemies
        new("Spawn Rival Grunt [M]", "sggr_enemy_grunt") { Price = 10, Quantity = 5, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Grunt" },
        new("Spawn Rival Exploder [M]", "sggr_enemy_exploder") { Price = 50, Quantity = 5, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Exploder using phase bombs" },
        new("Spawn Rival Opressor [M]", "sggr_enemy_opressor") { Price = 100, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Opressor with armor and drills" },
        new("Spawn Rival Spitter [M]", "sggr_enemy_spitter") { Price = 50, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Spitter that fires rockets!" },
        new("Spawn Rival Swarmer [M]", "sggr_enemy_swarmer") { Price = 10, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Swarmers. They spawn in sets of 3." },
        new("Spawn Rival Warden [M]", "sggr_enemy_warden") { Price = 100, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Warden that shields all enemis flying, rival, and glyphid." },
        new("Spawn Rival Saw Bulk [M]", "sggr_enemy_sawbulk") { Price = 300, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Bulk with sawblade launcher. It also explodes into ripsaws on death." },
        new("Spawn Rival Bomb Bulk [M]", "sggr_enemy_bombbulk") { Price = 300, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Bulk with lazer turrets and a phase bomb dispenser!" },
        new("Spawn Rival Mactera [M]", "sggr_enemy_mactera") { Price = 25, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Mactera" },
        new("Spawn Rival Trijaw [M]", "sggr_enemy_trishot") { Price = 75, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Trijaw" },
        new("Spawn Rival Grabber [M]", "sggr_enemy_grabber") { Price = 100, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival Grabber that can teleport" },
        new("Spawn Rival Bomber [M]", "sggr_enemy_bomber") { Price = 75, Category = "Expansion / Rivals", Description = "Spawns a Custom Rival bomber that drops dangerous objects" },
        new("Spawn Rival Light Eater [M]", "sggr_enemy_lighteater") { Price = 50, Category = "Expansion / Rivals", Description = "Spawns a Custom Enemy that eats lights. Prioritizing Scout Flares, then eating regular flares." },

        //Rival Bosses
        new("Spawn Rival Boss G4R-E [M]", "sggr_boss_gary") { Price = 400, Category = "Expansion / Rivals", Description = "Spawns a Custom Boss Nemesis called Gary." },
        new("Spawn Rival Boss KR4K3N [M]", "sggr_boss_kraken") { Price = 750, Category = "Expansion / Rivals", Description = "Spawns a Custom Boss Omen Tower Fight!" },
        new("Spawn Rival Boss K4R-E [M]", "sggr_boss_k4re") { Price = 300, Category = "Expansion / Rivals", Description = "Spawns a Custom Boss patrol bot that spawns protectors each phase." },
        new("Spawn Rival Boss K4R-N [M]", "sggr_boss_k4rn") { Price = 300, Category = "Expansion / Rivals", Description = "Spawns a Custom Boss patrol bot that spawns tentacles each phase." },
        new("Spawn Rival Drop Event [M]", "sggr_boss_gnomedrop") { Price = 750, Category = "Expansion / Rivals", Description = "Spawns a Custom Boss event! Survive until the timer / hp bar runs out!" },

        //Xmas Set
        new("Spawn Present Grunt [M]", "x_xmas_grunt") { Price = 10, Quantity = 5, Category = "Xmas", Description = "Spawns a Custom Xmas grunt wrapped in a present" },
        new("Spawn Bulb Shooter [M]", "x_xmas_bulbshooter") { Price = 50, Category = "Xmas", Description = "Spawns a Custom mactera shooter that can freeze dwarves" },
        new("Spawn Snowmad [M]", "x_xmas_snowmad") { Price = 250, Category = "Xmas", Description = "Spawns a custom snowman enemy that runs at players and tries to freeze them! If pinged it will be stopped temporarily." }
    };

    static bool IsReady()
    {
        if (File.Exists(ReadyCheckFile))
        {
            string readyTest = File.ReadAllText(ReadyCheckFile);

            if (String.IsNullOrEmpty(readyTest))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }

    }

}