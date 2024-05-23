namespace RotationSolver.DiscordBot;

internal static class Resource
{
    public static readonly List<(string, uint)> DutyAndImage =
    [
        ("the Thousand Maws of TotoRak", 112005),
        ("the TamTara Deepcroft", 112002),
        ("Copperbell Mines", 112003),
        ("Sastasha", 112001),
        ("the Aurum Vale", 112014),
        ("Haukke Manor", 112006),
        ("Halatali", 112004),
        ("Brayflox's Longstop", 112007),
        ("the Sunken Temple of Qarn", 112009),
        ("the Wanderer's Palace", 112010),
        ("the Stone Vigil", 112012),
        ("Cutter's Cry", 112011),
        ("Dzemael Darkhold", 112013),
        ("Amdapor Keep", 112015),
        ("Castrum Meridianum", 112016),
        ("the Praetorium", 112017),
        ("Pharos Sirius", 112027),
        ("Copperbell Mines (Hard)", 112025),
        ("Haukke Manor (Hard)", 112026),
        ("Brayflox's Longstop (Hard)", 112048),
        ("Halatali (Hard)", 112049),
        ("the Lost City of Amdapor", 112042),
        ("Hullbreaker Isle", 112058),
        ("the TamTara Deepcroft (Hard)", 112059),
        ("the Stone Vigil (Hard)", 112060),
        ("the Sunken Temple of Qarn (Hard)", 112068),
        ("Snowcloak", 112066),
        ("Sastasha (Hard)", 112067),
        ("Amdapor Keep (Hard)", 112077),
        ("the Wanderer's Palace (Hard)", 112078),
        ("the Great Gubal Library", 112091),
        ("the Keeper of the Lake", 112076),
        ("Neverreap", 112093),
        ("the Vault", 112090),
        ("the Fractal Continuum", 112094),
        ("the Dusk Vigil", 112087),
        ("Sohm Al", 112088),
        ("the Aetherochemical Research Facility", 112092),
        ("the Aery", 112089),
        ("Pharos Sirius (Hard)", 112117),
        ("Saint Mocianne's Arboretum", 112116),
        ("Basic Training: Enemy Parties", 111006),
        ("Under the Armor", 111001),
        ("Basic Training: Enemy Strongholds", 111007),
        ("Hero on the Half Shell", 111008),
        ("Pulling Poison Posies", 111002),
        ("Stinging Back", 111003),
        ("All's Well that Ends in the Well", 111005),
        ("Flicking Sticks and Taking Names", 111004),
        ("More than a Feeler", 111009),
        ("Annoy the Void", 111010),
        ("Shadow and Claw", 111011),
        ("Long Live the Queen", 111012),
        ("Ward Up", 111013),
        ("Solemn Trinity", 111014),
        ("the Bowl of Embers", 112008),
        ("the Navel", 112018),
        ("the Howling Eye", 112019),
        ("the Bowl of Embers (Hard)", 112021),
        ("the Navel (Hard)", 112022),
        ("the Howling Eye (Hard)", 112023),
        ("the Bowl of Embers (Extreme)", 112028),
        ("the Navel (Extreme)", 112029),
        ("the Howling Eye (Extreme)", 112030),
        ("Thornmarch (Hard)", 112031),
        ("Thornmarch (Extreme)", 112050),
        ("the Minstrel's Ballad: Ultima's Bane", 112032),
        ("The Gilded Araya", 112536),
        ("Special Event I", 112320),
        ("Special Event II", 112358),
        ("the Whorleater (Hard)", 112051),
        ("the Whorleater (Extreme)", 112052),
        ("A Relic Reborn: the Chimera", 112053),
        ("A Relic Reborn: the Hydra", 112055),
        ("Battle on the Big Bridge", 112054),
        ("the Striking Tree (Hard)", 112062),
        ("the Striking Tree (Extreme)", 112063),
        ("the Akh Afah Amphitheatre (Hard)", 112073),
        ("the Akh Afah Amphitheatre (Extreme)", 112074),
        ("the Dragon's Neck", 112075),
        ("Urth's Fount", 112065),
        ("the Chrysalis", 112081),
        ("Battle in the Big Keep", 112080),
        ("Thok ast Thok (Hard)", 112103),
        ("Thok ast Thok (Extreme)", 112107),
        ("the Limitless Blue (Hard)", 112104),
        ("the Limitless Blue (Extreme)", 112105),
        ("the Singularity Reactor", 112106),
        ("the Minstrel's Ballad: Thordan's Reign", 112122),
        ("the Labyrinth of the Ancients", 112033),
        ("the Binding Coil of Bahamut - Turn 1", 112043),
        ("the Binding Coil of Bahamut - Turn 2", 112044),
        ("the Binding Coil of Bahamut - Turn 3", 112045),
        ("the Binding Coil of Bahamut - Turn 4", 112046),
        ("the Binding Coil of Bahamut - Turn 5", 112047),
        ("the Second Coil of Bahamut - Turn 1", 112038),
        ("the Second Coil of Bahamut - Turn 2", 112039),
        ("the Second Coil of Bahamut - Turn 3", 112040),
        ("the Second Coil of Bahamut - Turn 4", 112041),
        ("Syrcus Tower", 112061),
        ("the Second Coil of Bahamut (Savage) - Turn 1", 112038),
        ("the Second Coil of Bahamut (Savage) - Turn 2", 112039),
        ("the Second Coil of Bahamut (Savage) - Turn 3", 112040),
        ("the Second Coil of Bahamut (Savage) - Turn 4", 112041),
        ("the Final Coil of Bahamut - Turn 1", 112069),
        ("the Final Coil of Bahamut - Turn 2", 112070),
        ("the Final Coil of Bahamut - Turn 3", 112071),
        ("the Final Coil of Bahamut - Turn 4", 112072),
        ("the World of Darkness", 112079),
        ("Alexander - The Fist of the Father", 112095),
        ("Alexander - The Cuff of the Father", 112096),
        ("Alexander - The Arm of the Father", 112097),
        ("Alexander - The Burden of the Father", 112098),
        ("Alexander - The Fist of the Father (Savage)", 112099),
        ("Alexander - The Cuff of the Father (Savage)", 112100),
        ("Alexander - The Arm of the Father (Savage)", 112101),
        ("Alexander - The Burden of the Father (Savage)", 112102),
        ("the Void Ark", 112118),
        ("the Borderland Ruins (Secure)", 112064),
        ("Seal Rock (Seize)", 112108),
        ("the Diadem (Easy)", 112119),
        ("the Diadem", 112384),
        ("the Diadem (Hard)", 112121),
        ("Containment Bay S1T7", 112126),
        ("Containment Bay S1T7 (Extreme)", 112127),
        ("Alexander - The Fist of the Son", 112128),
        ("Alexander - The Cuff of the Son", 112129),
        ("Alexander - The Arm of the Son", 112130),
        ("Alexander - The Burden of the Son", 112131),
        ("the Lost City of Amdapor (Hard)", 112124),
        ("the Antitower", 112125),
        ("Alexander - The Fist of the Son (Savage)", 112132),
        ("Alexander - The Cuff of the Son (Savage)", 112133),
        ("Alexander - The Arm of the Son (Savage)", 112134),
        ("Alexander - The Burden of the Son (Savage)", 112135),
        ("Avoid Area of Effect Attacks", 112141),
        ("Execute a Combo to Increase Enmity", 112141),
        ("Execute a Combo in Battle", 112141),
        ("Accrue Enmity from Multiple Targets", 112141),
        ("Engage Multiple Targets", 112141),
        ("Execute a Ranged Attack to Increase Enmity", 112141),
        ("Engage Enemy Reinforcements", 112141),
        ("Assist Allies in Defeating a Target", 112141),
        ("Defeat an Occupied Target", 112141),
        ("Avoid Engaged Targets", 112141),
        ("Interact with the Battlefield", 112141),
        ("Heal an Ally", 112141),
        ("Heal Multiple Allies", 112141),
        ("Final Exercise", 112141),
        ("a Spectacle for the Ages", 112145),
        ("the Weeping City of Mhach", 112162),
        ("the Final Steps of Faith", 112160),
        ("the Minstrel's Ballad: Nidhogg's Rage", 112161),
        ("Sohr Khai", 112163),
        ("Hullbreaker Isle (Hard)", 112164),
        ("a Bloody Reunion", 0),
        ("the Palace of the Dead (Floors 1-10)", 112166),
        ("the Palace of the Dead (Floors 11-20)", 112167),
        ("the Palace of the Dead (Floors 21-30)", 112168),
        ("the Palace of the Dead (Floors 31-40)", 112169),
        ("the Palace of the Dead (Floors 41-50)", 112170),
        ("the Aquapolis", 0),
        ("the Fields of Glory (Shatter)", 112165),
        ("the Haunted Manor", 112196),
        ("Xelphatol", 112186),
        ("Containment Bay P1T6", 112201),
        ("Containment Bay P1T6 (Extreme)", 112202),
        ("Alexander - The Eyes of the Creator", 112188),
        ("Alexander - The Breath of the Creator", 112189),
        ("Alexander - The Heart of the Creator", 112190),
        ("Alexander - The Soul of the Creator", 112191),
        ("Alexander - The Eyes of the Creator (Savage)", 112192),
        ("Alexander - The Breath of the Creator (Savage)", 112193),
        ("Alexander - The Heart of the Creator (Savage)", 112194),
        ("Alexander - The Soul of the Creator (Savage)", 112195),
        ("One Life for One World", 0),
        ("the Triple Triad Battlehall", 112197),
        ("the Great Gubal Library (Hard)", 112187),
        ("LoVM: Player Battle (RP)", 112199),
        ("LoVM: Tournament", 112200),
        ("LoVM: Player Battle (Non-RP)", 112198),
        ("the Diadem Hunting Grounds (Easy)", 112119),
        ("the Diadem Hunting Grounds", 112120),
        ("the Palace of the Dead (Floors 51-60)", 112171),
        ("the Palace of the Dead (Floors 61-70)", 112172),
        ("the Palace of the Dead (Floors 71-80)", 112173),
        ("the Palace of the Dead (Floors 81-90)", 112174),
        ("the Palace of the Dead (Floors 91-100)", 112175),
        ("the Palace of the Dead (Floors 101-110)", 112176),
        ("the Palace of the Dead (Floors 111-120)", 112177),
        ("the Palace of the Dead (Floors 121-130)", 112178),
        ("the Palace of the Dead (Floors 131-140)", 112179),
        ("the Palace of the Dead (Floors 141-150)", 112180),
        ("the Palace of the Dead (Floors 151-160)", 112181),
        ("the Palace of the Dead (Floors 161-170)", 112182),
        ("the Palace of the Dead (Floors 171-180)", 112183),
        ("the Palace of the Dead (Floors 181-190)", 112184),
        ("the Palace of the Dead (Floors 191-200)", 112185),
        ("Baelsar's Wall", 112214),
        ("Dun Scaith", 112203),
        ("Sohm Al (Hard)", 112215),
        ("The Carteneau Flats: Heliodrome", 0),
        ("Containment Bay Z1T9", 112212),
        ("Containment Bay Z1T9 (Extreme)", 112213),
        ("the Diadem - Trials of the Fury", 112221),
        ("the Diadem - Trials of the Matron", 112222),
        ("Shisui of the Violet Tides", 112227),
        ("The Temple of the Fist", 112233),
        ("It's Probably a Trap", 0),
        ("the Sirensong Sea", 112226),
        ("the Royal Menagerie", 112244),
        ("Bardam's Mettle", 112228),
        ("Doma Castle", 112229),
        ("Castrum Abania", 112230),
        ("the Pool of Tribute", 112242),
        ("the Pool of Tribute (Extreme)", 112245),
        ("With Heart and Steel", 0),
        ("Naadam", 0),
        ("Ala Mhigo", 112231),
        ("Blood on the Deck", 0),
        ("The Face of True Evil", 0),
        ("Matsuba Mayhem", 0),
        ("The Battle on Bekko", 0),
        ("Deltascape V1.0", 112234),
        ("Deltascape V2.0", 112235),
        ("Deltascape V3.0", 112236),
        ("Deltascape V4.0", 112237),
        ("Deltascape V1.0 (Savage)", 112238),
        ("Deltascape V2.0 (Savage)", 112239),
        ("Deltascape V3.0 (Savage)", 112240),
        ("Deltascape V4.0 (Savage)", 112241),
        ("Curious Gorge Meets His Match", 0),
        ("In Thal's Name", 0),
        ("Kugane Castle", 112232),
        ("Emanation", 112243),
        ("Emanation (Extreme)", 112246),
        ("Our Unsung Heroes", 0),
        ("The Heart of the Problem", 0),
        ("Dark as the Night Sky", 0),
        ("the Lost Canals of Uznair", 0),
        ("The Resonant", 0),
        ("Raising the Sword", 0),
        ("The Orphans and the Broken Blade", 0),
        ("Our Compromise", 0),
        ("Dragon Sound", 0),
        ("When Clans Collide", 0),
        ("Interdimensional Rift", 0),
        ("the Hidden Canals of Uznair", 0),
        ("Astragalos", 112257),
        ("the Minstrel's Ballad: Shinryu's Domain", 112258),
        ("the Drowned City of Skalla", 112255),
        ("the Unending Coil of Bahamut (Ultimate)", 112261),
        ("the Royal City of Rabanastre", 112256),
        ("Return of the Bull", 0),
        ("the Forbidden Land, Eureka Anemos", 112275),
        ("Hells' Lid", 112264),
        ("the Fractal Continuum (Hard)", 112263),
        ("Sigmascape V1.0", 112265),
        ("Sigmascape V2.0", 112267),
        ("Sigmascape V3.0", 112269),
        ("Sigmascape V4.0", 112271),
        ("the Jade Stoa", 112273),
        ("the Jade Stoa (Extreme)", 112274),
        ("Sigmascape V1.0 (Savage)", 112266),
        ("Sigmascape V2.0 (Savage)", 112268),
        ("Sigmascape V3.0 (Savage)", 112270),
        ("Sigmascape V4.0 (Savage)", 112272),
        ("the Valentione's Ceremony", 112262),
        ("the Great Hunt", 112289),
        ("the Great Hunt (Extreme)", 112290),
        ("Chocobo Race: Tutorial", 112086),
        ("Race 1 - Hugging the Inside", 112085),
        ("Race 2 - Keep Away", 112084),
        ("Race 3 - Inability", 112086),
        ("Race 4 - Heavy Hooves", 112085),
        ("Race 5 - Defending the Rush", 112084),
        ("Race 6 - Road Rivals", 112086),
        ("Race 7 - Field of Dreams", 112084),
        ("Race 8 - Playing Both Ends", 112085),
        ("Race 9 - Stamina", 112086),
        ("Race 10 - Cat and Mouse", 112084),
        ("Race 11 - Mad Dash", 112086),
        ("Race 12 - Bag of Tricks", 112085),
        ("Race 13 - Tag Team", 112086),
        ("Race 14 - Heavier Hooves", 112084),
        ("Race 15 - Ultimatum", 112085),
        ("Chocobo Race: Sagolii Road", 112086),
        ("Chocobo Race: Costa del Sol", 112084),
        ("Chocobo Race: Tranquil Paths", 112085),
        ("the Swallow's Compass", 112283),
        ("Castrum Fluminis", 112291),
        ("the Minstrel's Ballad: Tsukuyomi's Pain", 112292),
        ("the Weapon's Refrain (Ultimate)", 112296),
        ("Heaven-on-High  (Floors 1-10)", 112298),
        ("Heaven-on-High  (Floors 11-20)", 112299),
        ("Heaven-on-High  (Floors 21-30)", 112300),
        ("Heaven-on-High  (Floors 31-40)", 112301),
        ("Heaven-on-High  (Floors 41-50)", 112302),
        ("Heaven-on-High  (Floors 51-60)", 112303),
        ("Heaven-on-High  (Floors 61-70)", 112304),
        ("Heaven-on-High  (Floors 71-80)", 112305),
        ("Heaven-on-High  (Floors 81-90)", 112306),
        ("Heaven-on-High  (Floors 91-100)", 112307),
        ("the Ridorana Lighthouse", 112286),
        ("Stage 1: Tutorial", 112114),
        ("Stage 2: Hatching a Plan", 112114),
        ("Stage 3: The First Move", 112115),
        ("Stage 4: Little Big Beast", 112115),
        ("Stage 5: Turning Tribes", 112115),
        ("Stage 6: Off the Deepcroft", 112115),
        ("Stage 7: Rivals", 112115),
        ("Stage 8: Always Darkest", 112115),
        ("Stage 9: Mine Your Minions", 112115),
        ("Stage 10: Children of Mandragora", 112115),
        ("Stage 11: The Queen and I", 112115),
        ("Stage 12: Breakout", 112115),
        ("Stage 13: My Name Is Cid", 112115),
        ("Stage 14: Like a Nut", 112115),
        ("Stage 15: Urth's Spout", 112115),
        ("Stage 16: Exodus", 112115),
        ("Stage 17: Over the Wall", 112115),
        ("Stage 18: The Hunt", 112115),
        ("Stage 19: Battle on the Bitty Bridge", 112115),
        ("Stage 20: Guiding Light", 112115),
        ("Stage 21: Wise Words", 112115),
        ("Stage 22: World of Poor Lighting", 112115),
        ("Stage 23: The Binding Coil", 112115),
        ("Stage 24: The Final Coil", 112115),
        ("LoVM: Master Battle", 112109),
        ("LoVM: Master Battle (Hard)", 112110),
        ("LoVM: Master Battle (Extreme)", 112111),
        ("LoVM: Master Tournament", 112200),
        ("the Forbidden Land, Eureka Pagos", 112308),
        ("Emissary of the Dawn", 0),
        ("the Calamity Retold", 112297),
        ("Saint Mocianne's Arboretum (Hard)", 112310),
        ("the Burn", 112311),
        ("the Shifting Altars of Uznair", 0),
        ("Alphascape V1.0", 112312),
        ("Alphascape V2.0", 112313),
        ("Alphascape V3.0", 112314),
        ("Alphascape V4.0", 112315),
        ("Alphascape V1.0 (Savage)", 112316),
        ("Alphascape V2.0 (Savage)", 112317),
        ("Alphascape V3.0 (Savage)", 112318),
        ("Alphascape V4.0 (Savage)", 112319),
        ("Kugane Ohashi", 112320),
        ("Hells' Kier", 112321),
        ("Hells' Kier (Extreme)", 112322),
        ("the Forbidden Land, Eureka Pyros", 112323),
        ("Hidden Gorge", 112335),
        ("Leap of Faith", 112520),
        ("The Will of the Moon", 0),
        ("All's Well That Starts Well", 112332),
        ("the Ghimlyt Dark", 112333),
        ("Much Ado About Pudding", 112332),
        ("Waiting for Golem", 112332),
        ("Gentlemen Prefer Swords", 112332),
        ("The Threepenny Turtles", 112332),
        ("Eye Society", 112332),
        ("A Chorus Slime", 112332),
        ("Bomb-edy of Errors", 112332),
        ("To Kill a Mockingslime", 112332),
        ("A Little Knight Music", 112332),
        ("Some Like It Excruciatingly Hot", 112332),
        ("The Plant-om of the Opera", 112332),
        ("Beauty and a Beast", 112332),
        ("Blobs in the Woods", 112332),
        ("The Me Nobody Nodes", 112332),
        ("Sunset Bull-evard", 112332),
        ("The Sword of Music", 112332),
        ("Midsummer Night's Explosion", 112332),
        ("On a Clear Day You Can Smell Forever", 112332),
        ("Miss Typhon", 112332),
        ("Chimera on a Hot Tin Roof", 112332),
        ("Here Comes the Boom", 112332),
        ("Behemoths and Broomsticks", 112332),
        ("Amazing Technicolor Pit Fiends", 112332),
        ("Dirty Rotten Azulmagia", 112332),
        ("the Orbonne Monastery", 112334),
        ("the Wreath of Snakes", 112339),
        ("the Wreath of Snakes (Extreme)", 112340),
        ("the Forbidden Land, Eureka Hydatos", 112338),
        ("Air Force One", 112337),
        ("Novice Mahjong (Full Ranked Match)", 112336),
        ("Advanced Mahjong (Full Ranked Match)", 112336),
        ("Four-player Mahjong (Full Match, Kuitan Enabled)", 112336),
        ("Messenger of the Winds", 0),
        ("a Requiem for Heroes", 0),
        ("Dohn Mheg", 112343),
        ("Four-player Mahjong (Full Match, Kuitan Disabled)", 112336),
        ("the Qitana Ravel", 112344),
        ("Amaurot", 112347),
        ("Eden's Gate: Resurrection", 112350),
        ("Eden's Gate: Resurrection (Savage)", 112351),
        ("the Twinning", 112348),
        ("Malikah's Well", 112345),
        ("The Dancing Plague", 112358),
        ("the Dancing Plague (Extreme)", 112359),
        ("Mt. Gulg", 112346),
        ("Akadaemia Anyder", 112349),
        ("The Crown of the Immaculate", 112360),
        ("the Crown of the Immaculate (Extreme)", 112361),
        ("Holminster Switch", 112342),
        ("The Hardened Heart", 0),
        ("The Lost and the Found", 0),
        ("Coming Clean", 0),
        ("Legend of the Not-so-hidden Temple", 0),
        ("Eden's Gate: Inundation", 112354),
        ("Eden's Gate: Inundation (Savage)", 112355),
        ("Eden's Gate: Descent", 112352),
        ("Eden's Gate: Descent (Savage)", 112353),
        ("Nyelbert's Lament", 0),
        ("The Dying Gasp", 112362),
        ("The Dungeons of Lyhe Ghiah", 0),
        ("Eden's Gate: Sepulture", 112356),
        ("Eden's Gate: Sepulture (Savage)", 112357),
        ("The Hunter's Legacy", 0),
        ("The Grand Cosmos", 112373),
        ("The Minstrel's Ballad: Hades's Elegy", 112372),
        ("The Epic of Alexander (Ultimate)", 112374),
        ("Papa Mia", 112332),
        ("Lock up Your Snorters", 112332),
        ("Dangerous When Dead", 112332),
        ("Red, Fraught, and Blue", 112332),
        ("The Catch of the Siegfried", 112332),
        ("The Copied Factory", 112375),
        ("Onsal Hakair (Danshig Naadam)", 112376),
        ("Vows of Virtue, Deeds of Cruelty", 0),
        ("As the Heart Bids", 0),
        ("Anamnesis Anyder", 112378),
        ("Eden's Verse: Fulmination", 112385),
        ("Eden's Verse: Fulmination (Savage)", 112386),
        ("Cinder Drift", 112379),
        ("Cinder Drift (Extreme)", 112380),
        ("Eden's Verse: Furor", 112387),
        ("Eden's Verse: Furor (Savage)", 112388),
        ("Ocean Fishing", 112383),
        ("the Bozja Incident", 0),
        ("A Sleep Disturbed", 0),
        ("Memoria Misera (Extreme)", 112381),
        ("Eden's Verse: Iconoclasm", 112389),
        ("Eden's Verse: Iconoclasm (Savage)", 112390),
        ("Eden's Verse: Refulgence", 112391),
        ("Eden's Verse: Refulgence (Savage)", 112392),
        ("The Bozjan Southern Front", 112401),
        ("the Puppets' Bunker", 112400),
        ("the Heroes' Gauntlet", 112399),
        ("the Seat of Sacrifice", 112402),
        ("the Seat of Sacrifice (Extreme)", 112403),
        ("Sleep Now in Sapphire", 0),
        ("Faded Memories", 0),
        ("the Shifting Oubliettes of Lyhe Ghiah", 0),
        ("Matoya's Relict", 112406),
        ("Eden's Promise: Litany", 112409),
        ("Eden's Promise: Litany (Savage)", 112410),
        ("Eden's Promise: Umbra", 112407),
        ("Eden's Promise: Umbra (Savage)", 112408),
        ("Eden's Promise: Anamorphosis", 112411),
        ("Eden's Promise: Anamorphosis (Savage)", 112412),
        ("Anything Gogo's", 112332),
        ("Triple Triad Open Tournament", 112415),
        ("Triple Triad Invitational Parlor", 112416),
        ("Eden's Promise: Eternity", 112413),
        ("Eden's Promise: Eternity (Savage)", 112414),
        ("Delubrum Reginae", 112417),
        ("Delubrum Reginae (Savage)", 112418),
        ("Castrum Marinum", 112419),
        ("Castrum Marinum (Extreme)", 112420),
        ("The Great Ship Vylbrand", 0),
        ("Fit for a Queen", 0),
        ("Novice Mahjong (Quick Ranked Match)", 112336),
        ("Advanced Mahjong (Quick Ranked Match)", 112336),
        ("Four-player Mahjong (Quick Match, Kuitan Enabled)", 112336),
        ("Four-player Mahjong (Quick Match, Kuitan Disabled)", 112336),
        ("Paglth'an", 112428),
        ("Zadnor", 112432),
        ("The Tower at Paradigm's Breach", 112431),
        ("Death Unto Dawn", 0),
        ("The Cloud Deck", 112429),
        ("The Cloud Deck (Extreme)", 112430),
        ("The Tower of Zot", 112435),
        ("the Stigma Dreamscape", 112442),
        ("The Tower of Babil", 112436),
        ("The Aitiascope", 112439),
        ("Ktisis Hyperboreia", 112438),
        ("Dragonsong's Reprise (Ultimate)", 112469),
        ("Vanaspati", 112437),
        ("The Mothercrystal", 112445),
        ("The Minstrel's Ballad: Hydaelyn's Call", 112446),
        ("The Dead Ends", 112440),
        ("In from the Cold", 0),
        ("Smileton", 112441),
        ("Worthy of His Back", 0),
        ("The Final Day", 112447),
        ("The Phantoms' Feast", 112456),
        ("Endwalker", 0),
        ("To Calmer Seas", 0),
        ("Asphodelos: The Fourth Circle", 112454),
        ("Asphodelos: The Fourth Circle (Savage)", 112455),
        ("The Dark Inside", 112443),
        ("The Minstrel's Ballad: Zodiark's Fall", 112444),
        ("As the Heavens Burn", 0),
        ("A Path Unveiled", 0),
        ("Asphodelos: The Third Circle", 112452),
        ("Asphodelos: The Third Circle (Savage)", 112453),
        ("Asphodelos: The First Circle", 112448),
        ("Asphodelos: The First Circle (Savage)", 112449),
        ("Asphodelos: The Second Circle", 112450),
        ("Asphodelos: The Second Circle (Savage)", 112451),
        ("A Frosty Reception", 0),
        ("Sage's Focus", 0),
        ("The Harvest Begins", 0),
        ("Ever March Heavensward", 0),
        ("The Killing Art", 0),
        ("Life Ephemeral, Path Eternal", 0),
        ("Laid to Rest", 0),
        ("The Excitatron 6000", 0),
        ("The Gift of Mercy", 0),
        ("the Aetherfont", 112521),
        ("The Lunar Subterrane", 112543),
        ("the Porta Decumana", 112468),
        ("The Palaistra", 112472),
        ("The Volcanic Heart", 112472),
        ("Cloud Nine", 112472),
        ("Alzadaal's Legacy", 112465),
        ("Forlorn Glory", 0),
        ("The Minstrel's Ballad: Endsinger's Aria", 112467),
        ("Crystalline Conflict (Custom Match - The Palaistra)", 112473),
        ("Crystalline Conflict (Custom Match - The Volcanic Heart)", 112474),
        ("Crystalline Conflict (Custom Match - Cloud Nine)", 112475),
        ("Cape Westwind", 0),
        ("Aglaia", 112466),
        ("Devastation", 0),
        ("The Sil'dihn Subterrane", 112493),
        ("the Fell Court of Troia", 112481),
        ("Storm's Crown", 112482),
        ("Storm's Crown (Extreme)", 112483),
        ("Abyssos: The Fifth Circle", 112484),
        ("Abyssos: The Fifth Circle (Savage)", 112485),
        ("Where Everything Begins", 0),
        ("Abyssos: The Seventh Circle", 112488),
        ("Abyssos: The Seventh Circle (Savage)", 112489),
        ("Another Sil'dihn Subterrane", 112494),
        ("Another Sil'dihn Subterrane (Savage)", 112495),
        ("Abyssos: The Sixth Circle", 112486),
        ("Abyssos: The Sixth Circle (Savage)", 112487),
        ("Abyssos: The Eighth Circle", 112490),
        ("Abyssos: The Eighth Circle (Savage)", 112491),
        ("the Steps of Faith", 0),
        ("Mount Ordeals", 112503),
        ("Lapis Manalis", 112502),
        ("Eureka Orthos (Floors 1-10)", 112507),
        ("Eureka Orthos (Floors 11-20)", 112508),
        ("Eureka Orthos (Floors 21-30)", 112509),
        ("Eureka Orthos (Floors 31-40)", 112510),
        ("Eureka Orthos (Floors 41-50)", 112511),
        ("Eureka Orthos (Floors 51-60)", 112512),
        ("Eureka Orthos (Floors 61-70)", 112513),
        ("Eureka Orthos (Floors 71-80)", 112514),
        ("Eureka Orthos (Floors 81-90)", 112515),
        ("Eureka Orthos (Floors 91-100)", 112516),
        ("Generational Bonding", 0),
        ("The Omega Protocol (Ultimate)", 112518),
        ("The Shifting Gymnasion Agonon", 0),
        ("An Unforeseen Bargain", 0),
        ("Euphrosyne", 112505),
        ("The Clockwork Castletown", 112472),
        ("Crystalline Conflict (Custom Match - The Clockwork Castletown)", 112517),
        ("Mount Ordeals (Extreme)", 112504),
        ("Anabaseios: The Ninth Circle", 112524),
        ("Anabaseios: The Ninth Circle (Savage)", 112525),
        ("Anabaseios: The Tenth Circle", 112526),
        ("Anabaseios: The Tenth Circle (Savage)", 112527),
        ("Anabaseios: The Eleventh Circle", 112528),
        ("Anabaseios: The Eleventh Circle (Savage)", 112529),
        ("Anabaseios: The Twelfth Circle", 112530),
        ("Anabaseios: The Twelfth Circle (Savage)", 112531),
        ("Mount Rokkon", 112533),
        ("Another Mount Rokkon", 112534),
        ("Another Mount Rokkon (Savage)", 112535),
        ("A Golden Opportunity", 112332),
        ("The Voidcast Dais", 112522),
        ("The Voidcast Dais (Extreme)", 112523),
        ("Blunderville", 112552),
        ("Memory of Embers", 0),
        ("The Game Is Afoot", 0),
        ("Aloalo Island", 112549),
        ("Thaleia", 112546),
        ("The Singularity Reactor (Unreal)", 112547),
        ("The Abyssal Fracture", 112544),
        ("The Abyssal Fracture (Extreme)", 112545),
        ("The Red Sands", 112472),
        ("Crystalline Conflict (Custom Match - The Red Sands)", 112548),
        ("Another Aloalo Island", 112550),
        ("Another Aloalo Island (Savage)", 112551),
    ];
}