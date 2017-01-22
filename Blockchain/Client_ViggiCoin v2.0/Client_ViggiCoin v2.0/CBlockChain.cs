﻿using System.IO;

namespace Blockchain
{
    class CBlockChain
    {
        private CBlock mLastBlock=null; //ultimo blocco ricevuto
        private CBlock mLastValidBlock = null;  //ultimo blocco sicuramente valido
        #region Singleton
        private static CBlockChain instance;

        private CBlockChain()
        {
            Load();
        }

        public static CBlockChain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CBlockChain();
                }
                return instance;
            }
        }
        #endregion Singleton

        public CBlock LastBlock
        {
            get { return mLastBlock; }
        }

        public CBlock LastValidBlock
        {
            get { return mLastBlock; }
        }

        /// <summary>
        /// Carica l'ultimo blocco della blockchain.
        /// </summary>
        private void Load()
        {
            StreamReader file = new StreamReader("blockchain.txt");
            mLastValidBlock = CBlock.Deserialize(file.ReadLine());  

        }


        internal static bool Validate(CBlock b)
        {
            throw new System.NotImplementedException();
        }

        internal static void Add(CBlock b)
        {
            throw new System.NotImplementedException();
        }

        internal static void Add(CBlock[] b)
        {
            throw new System.NotImplementedException();
        }
    }
}