﻿using Substrate.Nbt;

namespace NBTExplorer.Model
{
    public class TagByteArrayDataNode : TagDataNode
    {
        public TagByteArrayDataNode (TagNodeByteArray tag)
            : base(tag)
        { }

        protected new TagNodeByteArray Tag
        {
            get { return base.Tag as TagNodeByteArray; }
        }

        public override bool EditNode ()
        {
            return EditByteHexValue(Tag);
        }

        public override string NodeDisplay
        {
            get { return NodeDisplayPrefix + Tag.Data.Length + " bytes"; }
        }
    }
}
