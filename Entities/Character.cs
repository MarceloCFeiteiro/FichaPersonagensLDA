﻿namespace Entities
{
    public class Character
    {
        public uint Id { get; }

        public string Name { get; set; }

        public uint IdBreed { get; set; }

        public uint IdClass { get; set; }

        public uint IdElement { get; set; }

        public uint SpellCastSpeed { get; set; }

        public uint Exp { get; set; }

        public uint Constitution { get; set; }

        public uint AuraPower { get; set; }

        public uint IdStaticAttributes { get; set; }
    }
}