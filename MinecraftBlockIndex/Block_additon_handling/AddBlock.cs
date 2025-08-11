using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftBlockIndex.Block_additon_handling
{
    internal class AddBlock
    {
        public AddBlock(string blockName, bool isBurnable, bool isTransparent, bool isFull, bool emitsLight)
        {
            BlockName = blockName;
            IsBurnable = isBurnable;
            IsTransparent = isTransparent;
            IsFull = isFull;
            EmitsLight = emitsLight;
        }
        public int BlockID { get; set; } //Unique ID for block
        public string BlockName { get; set; } //Name of block tied to ID
        public bool IsBurnable { get; set; } //Indicates if block can be burned by fire or lava
        public bool IsTransparent { get; set; } //Indicates if block is transparent ie glass, leaves
        public bool IsFull { get; set; } //Indicates if solid block ie dirt, stone as opposed to slabs or stairs (not full blocks)
        public bool EmitsLight { get; set; } //Indicates if block emits light (ie glowstone, sea lanterns)

    }
}
