using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_ViggiCoin_v2._0
{
    class CTemporaryBlock:CBlock
    {
        private CPeer mSender;
        public CTemporaryBlock(CBlock Block, CPeer Sender):base(Block.Hash,Block.BlockNumber,Block.Transiction,Block.Nonce,Block.Timestamp,Block.Difficutly)
        {
            mSender = Sender;
        }
    }
}
