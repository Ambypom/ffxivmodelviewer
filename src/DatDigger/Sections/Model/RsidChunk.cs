﻿namespace DatDigger.Sections.Model
{
    public class RsidChunk : Chunk
    {
        public override void LoadData(BinaryReaderEx reader)
        {
            base.LoadData(reader);

            this.DisplayName = "<RSID>";
        }
    }
}
