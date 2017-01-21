using System;

namespace Client_ViggiCoin_v2._0
{
    public class CBlock
    {
        private string mHash;
        private ulong mBlockNumber; //serve?
        private string mTransiction;
        private ulong mNonce;
        private ulong mTimestamp;
        private ushort mDifficutly;
        private int mTargetMiningTime = 60;

        public CBlock()
        { }

        public CBlock(string Hash, ulong NumBlock, string Transiction, ulong Nonce, ulong Timestamp, ushort Difficutly)
        {
            mHash = Hash;
            mBlockNumber = NumBlock;
            mTransiction = Transiction;
            mNonce = Nonce;
            mTimestamp = Timestamp;
            mDifficutly = Difficutly;
        }

        /// <summary>
        /// Crea un nuovo oggetto CBlock usando una stringa che lo rappresenta.
        /// </summary>
        /// <param name="BlockString">Stringa che rappresenta l'oggetto CBlock.</param>
        public static CBlock Deserialize(string BlockString)
        {
            string[] blockField;
            BlockString=BlockString.Trim('{', '}');
            blockField = BlockString.Split(';');
            if (Program.DEBUG)
                CIO.DebugOut("Deserializing block number: "+ blockField[1]+".");
            return new CBlock(blockField[0], Convert.ToUInt64(blockField[1]), blockField[2], Convert.ToUInt64(blockField[3]), Convert.ToUInt64(blockField[4]), Convert.ToUInt16(blockField[5]));
        }

        public ulong BlockNumber
        {
            get { return mBlockNumber; }
        }
    }
}