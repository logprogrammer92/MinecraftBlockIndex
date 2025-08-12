using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftBlockIndex.Block_additon_handling
{
    internal class AddBlock
    {
        Issue#16-addBlockDataVerification-Toast
        //object parameters for block addition
        public int BlockID { get; private set; } //Unique ID for block
        public required string BlockName { get; set; } //Name of block tied to ID
        public bool IsBurnable { get; set; } //Indicates if block can be burned by fire or lava
        public bool IsTransparent { get; set; } //Indicates if block is transparent ie glass, leaves
        public bool IsFull { get; set; } //Indicates if solid block ie dirt, stone as opposed to slabs or stairs (not full blocks)
        public bool EmitsLight { get; set; } //Indicates if block emits light (ie glowstone, sea lanterns)
        
        // Constructor with verification and automatic ID assignment
        public AddBlock(int blockID, string blockName, bool isBurnable, bool isTransparent, bool isFull, bool emitsLight)
        {
            if (string.IsNullOrWhiteSpace(blockName))
                throw new ArgumentException("Block name cannot be null or empty.", nameof(blockName));

            if (blockName.Length > 50)
                throw new ArgumentException("Block name must be 50 characters or fewer.", nameof(blockName));

            if (!blockName.All(c => char.IsLetterOrDigit(c) || c == ' '))
                throw new ArgumentException("Block name can only contain letters, digits, and spaces.", nameof(blockName));

            BlockID = blockID;
            BlockName = blockName;
            IsBurnable = isBurnable;
            IsTransparent = isTransparent;
            IsFull = isFull;
            EmitsLight = emitsLight;
        }
    }
}
